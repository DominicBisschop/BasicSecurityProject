using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSecurity___PEOpdracht
{
    public partial class DecrypteerForm : Form
    {
        private string selectedFile = "";
        private DES des;
        private RSA rsa;
        private bool keyLoad = false;
        private bool hashMatch = false;

        public DecrypteerForm()
        {
            InitializeComponent();
            rsa = new RSA();
            des = new DES();

            ambianceControlBox.EnableMaximize = false;
            ambianceControlBox.Location = new Point(this.Width - 49, 13);
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            selectFileAction(openFileDialog.FileName);

           
        }
        private void selectFileAction(string fileLocation)
        {
            if (fileLocation != "")
            {
                selectedFile = fileLocation;
                selectedFileLabel.Text = "File selected: " + fileLocation;
                decryptTextButton.Enabled = true;
                decryptFileButton.Enabled = true;
                decryptTextBox.Enabled = true;
            }
            else
            {
                selectedFileLabel.Text = "No file selected";
                selectedFile = "";
                decryptTextButton.Enabled = false;
                decryptFileButton.Enabled = false;
                decryptTextBox.Enabled = false;
            }
        }
        private void selectFileButton_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void selectFileButton_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                {
                    // Code to read the contents of the text file
                    if (File.Exists(fileLoc))
                    {
                        selectFileAction(fileLoc);
                    }
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try { 
            if (File.Exists(selectedFile) && keyLoad && hashMatch)
            {
                
                   byte[] fileContent = File.ReadAllBytes(selectedFile);
                    
                   string dec = des.DecrypteerBericht(fileContent);
                   decryptTextBox.Text = dec;
                
            }
            else if (!File.Exists(selectedFile))
            {
                MessageBox.Show("No file selected. Please select a file");
            }
            else if (!hashMatch)
            {
                MessageBox.Show("The hash does not match or is not selected! Please select another hash");
            }
            else if (!keyLoad)
            {
                MessageBox.Show("There is no or a wrong key selected. Please select another key");
            }
            else{
                MessageBox.Show("No file selected. Please select a file");
            }
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                decryptTextBox.Text = "";
                
                MessageBox.Show("Something went wrong, did you select the right user to decrypt the key?");
            }
        }
        private void decryptFileButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(selectedFile) && keyLoad && hashMatch)
            {
                byte[] fileContent = File.ReadAllBytes(selectedFile);
                string dec = des.DecrypteerBericht(fileContent);
                    using(StreamWriter writer = new StreamWriter(selectedFile + ".Decrypted.txt"))
                        writer.Write(dec);
                    System.Diagnostics.Process.Start(Properties.Settings.Default.SharedFolder);
            }
            else if (!File.Exists(selectedFile))
            {
                MessageBox.Show("No file selected. Please select a file");
            }
            else if (!keyLoad)
            {
                MessageBox.Show("There is no or a wrong key selected. Please select another key");
            }
            else if (!hashMatch)
            {
                MessageBox.Show("The hash does not match! Please select another hash");
            }
            else
            {
                MessageBox.Show("Unexpected error, please try again");
            }
        }
        private void selectKeyButton_Click(object sender, EventArgs e)
        {
            // 0 = A
            // 1 = B

            if (toggleABAmbiance.Toggled == true)
            {
                rsa.Persoon = 0; //set to A
            }
            else
            {
                rsa.Persoon = 1; //set to B
            }
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName))
            {
                try {
                    byte[] encryptedKey = File.ReadAllBytes(openFileDialog.FileName);
                    byte[] decryptedKey = rsa.DecrypteerBericht(encryptedKey);
                   // byte[] decryptedBytes = new byte[decryptedKey.Length * sizeof(char)];
                    //System.Buffer.BlockCopy(decryptedKey.ToCharArray(), 0, decryptedBytes, 0, decryptedBytes.Length);
                    des.Key = decryptedKey;
                
                selectKeyLabel.Text = "Key loaded";
                keyLoad = true;
                }
                catch (Exception ex)
                {
                    selectKeyLabel.Text = "Error with key selection, please try again";
                    keyLoad = false;
                }
            }
            else { 
                selectKeyLabel.Text = "No key loaded";
                keyLoad = false;
            }

        }

        private void toggleABAmbiance_ToggledChanged()
        {
            selectKeyLabel.Text = "No selected key";
            selectHashLabel.Text = "No selected hash";
            keyLoad = false;
            hashMatch = false;
        }

        private void succesAmbianceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.SharedFolder);
        }

        private void selectHashButton_Click(object sender, EventArgs e)
        {
            if (toggleABAmbiance.Toggled == true)
            {
                rsa.Persoon = 0; //set to A
            }
            else
            {
                rsa.Persoon = 1; //set to B
            }
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName) && File.Exists(selectedFile))
            {
                try
                {
                    byte[] data = File.ReadAllBytes(selectedFile);
                    byte[] hash = File.ReadAllBytes(openFileDialog.FileName);
                    if (rsa.RSAVerifySign(hash, data))
                    {
                        selectHashLabel.Text = "Hash matches!";
                        hashMatch = true;
                    }
                    else
                    {
                        selectHashLabel.Text = "Hash does not match! Please select another file";
                        hashMatch = false;
                    }
                }
                catch (Exception ex)
                {
                    selectHashLabel.Text = "Error with hash selection, please try again";
                    hashMatch = false;
                }
            }
            else
            {
                selectHashLabel.Text = "No Hash loaded";
                hashMatch = false;
            }
        }

       

     

    }
}
