using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BasicSecurity___PEOpdracht
{
    class RSA
    {
        // 0 = A
        // 1 = B
        private int persoon = 0;
        private string homeFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public int Persoon
        {
            get { return persoon;}
            set { persoon = value; }
        }

        public byte[] EncrypteerBericht(byte[] dataToEncrypt)
        {
            byte[] encryptedData = new byte[0];
            try
            {
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024))
                {

                    StreamReader reader;

                    if (persoon == 0)
                    {
                        reader = new StreamReader(homeFolder + "/Keys/PublicB.txt");
                    }
                    else
                    {
                        reader = new StreamReader(homeFolder + "/Keys/PublicA.txt");
                    }

                    String key = reader.ReadLine();

                    reader.Close();
                    RSA.FromXmlString(key);

                    encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                }
                
            }
            catch (Exception ex)
            {
                //Catch this exception in case the encryption did 
                //not succeed.
                Console.WriteLine("Encryption failed." + ex.Message);
            }

            return encryptedData;
        }

        public byte[] DecrypteerBericht(byte[] encrypted)
        {
            byte[] decryptedData = new byte[0];
            try
            {
 
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024))
                {
                    StreamReader reader;

                    if (persoon == 0)
                    {
                        reader = new StreamReader(homeFolder + "/Keys/PrivateA.txt");
                    }
                    else
                    {
                        reader = new StreamReader(homeFolder + "/Keys/PrivateB.txt");
                    }

                    String key = reader.ReadToEnd();

                    reader.Close();
                    RSA.FromXmlString(key);
                    decryptedData = RSADecrypt(encrypted, RSA.ExportParameters(true), false);
                }

            }
            catch (ArgumentNullException)
            {
                //Catch this exception in case the encryption did 
                //not succeed.
                Console.WriteLine("Decryption failed.");

            }
            return decryptedData;
        }
        public byte[] RSASign(byte[] dataToSign)
        {
            byte[] sign = new byte[0];
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024))
            {
                StreamReader reader;
                if (persoon == 0)
                {
                    reader = new StreamReader(homeFolder + "/Keys/PrivateA.txt");
                }
                else
                {
                    reader = new StreamReader(homeFolder + "/Keys/PrivateB.txt");
                }

                String key = reader.ReadLine();

                reader.Close();
                RSA.FromXmlString(key);
                sign = RSA.SignData(dataToSign, new SHA1CryptoServiceProvider());
                //encryptedDataSigned = RSAEncrypt(encryptedData, RSA.ExportParameters(true), false);
            }
            return sign;
        }
        public bool RSAVerifySign(byte[] sign, byte[] dataToVerify)
        {
            bool verifySign = false;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024))
                {
                    StreamReader reader;

                    if (persoon == 0)
                    {
                        reader = new StreamReader(homeFolder + "/Keys/PublicB.txt");
                    }
                    else
                    {
                        reader = new StreamReader(homeFolder + "/Keys/PublicA.txt");
                    }

                    String key = reader.ReadToEnd();

                    reader.Close();
                    RSA.FromXmlString(key);
                    verifySign = RSA.VerifyData(dataToVerify, new SHA1CryptoServiceProvider(), sign);
                    //encryptedData = RSADecrypt(encryptedSigned, RSA.ExportParameters(false), false);
                }
            return verifySign;
        }
        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider. 
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024))
                {

                    //Import the RSA Key information. This only needs 
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.   
                    //OAEP padding is only available on Microsoft Windows XP or 
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException   
            //to the console. 
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider. 
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024))
                {
                    //Import the RSA Key information. This needs 
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);
                    Console.WriteLine(RSA.ToXmlString(true));
                    //Decrypt the passed byte array and specify OAEP padding.   
                    //OAEP padding is only available on Microsoft Windows XP or 
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException   
            //to the console. 
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }
    }
}
