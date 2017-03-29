using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace BasicSecurity___PEOpdracht
{
    class DES
    {
        private Byte[] key;

        public Byte[] Key { get { return key; } set { key = value; } }

        public byte[] EncrypteerBericht(String message)
        {
            String decryptedString = "";
            byte[] encrypted = new byte[0];
            try
            {
                // Create a new instance of the TripleDESCryptoServiceProvider 
                // class.  This generates a new key and initialization  
                // vector (IV). 
                using (TripleDESCryptoServiceProvider myTripleDES = new TripleDESCryptoServiceProvider())
                {
                    // Encrypt the string to an array of bytes. 
                    encrypted = EncryptStringToBytes(message, myTripleDES.Key, myTripleDES.IV);

                    Key = myTripleDES.Key;

                    //Display the original data and the decrypted data.
                    //Console.WriteLine(Convert.ToBase64String(encrypted));
               //     decryptedString = System.Text.Encoding.UTF8.GetString(encrypted);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

            return encrypted;
        }

        public string DecrypteerBericht(Byte[] encrypted)
        {
            try
            {
                // Create a new instance of the TripleDESCryptoServiceProvider 
                // class.  This generates a new key and initialization  
                // vector (IV). 
                using (TripleDESCryptoServiceProvider myTripleDES = new TripleDESCryptoServiceProvider())
                {
                    // Decrypt the bytes to a string. 
                    myTripleDES.Key = this.key;
                    string decrypted = DecryptStringFromBytes(encrypted, myTripleDES.Key, myTripleDES.IV);

                    //Display the original data and the decrypted data.
                    return decrypted;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                throw new Exception("Error in DES decryption"); 
            }
        }

        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            // Create an TripleDESCryptoServiceProvider object 
            // with the specified key and IV. 
            using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
            {
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;
                tdsAlg.Mode = CipherMode.ECB;
                tdsAlg.Padding = PaddingMode.PKCS7;
                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV);
            /*    ICryptoTransform encr = tdsAlg.CreateEncryptor();
                byte[] bytes = new byte[plainText.Length * sizeof(char)];
                System.Buffer.BlockCopy(plainText.ToCharArray(), 0, bytes, 0, bytes.Length);
                encrypted = encr.TransformFinalBlock(bytes,0,bytes.Length);
                tdsAlg.Clear();*/
                // Create the streams used for encryption. 
               using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
        
            }

            // Return the encrypted bytes from the memory stream. 
            return encrypted;
        }

        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            // Declare the string used to hold 
            // the decrypted text. 
            string plaintext = null;

            // Create an TripleDESCryptoServiceProvider object 
            // with the specified key and IV. 
            using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
            {
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;
                tdsAlg.Mode = CipherMode.ECB;
                tdsAlg.Padding = PaddingMode.PKCS7;
                // Create a decrytor to perform the stream transform.
         /*       ICryptoTransform encr = tdsAlg.CreateDecryptor();
                
                byte[] bytes = encr.TransformFinalBlock(cipherText, 0, cipherText.Length);
                char[] chars = new char[bytes.Length / sizeof(char)];
                System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
                plaintext = new string(chars);
                tdsAlg.Clear();*/
               ICryptoTransform decryptor = tdsAlg.CreateDecryptor(tdsAlg.Key, tdsAlg.IV);

                // Create the streams used for decryption. 
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream 
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            
            }

            return plaintext;

        }
    }
}
