using System;
using System.Drawing;
using System.IO;
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
                selectedFileLabel.Text = "Bestand geselecteerd: " + fileLocation;
                decryptTextButton.Enabled = true;
                decryptFileButton.Enabled = true;
                decryptTextBox.Enabled = true;
            }
            else
            {
                selectedFileLabel.Text = "Geen bestand geselecteerd";
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
                MessageBox.Show("Geen bestand geselecteerd. Kies een bestand.");
            }
            else if (!hashMatch)
            {
                MessageBox.Show("De hash matched niet of is nog niet geselecteerd!");
            }
            else if (!keyLoad)
            {
                MessageBox.Show("De sleutel matched niet of is nog niet geselecteerd!");
            }
            else{
                MessageBox.Show("Geen bestand geselecteerd. Kies een bestand.");
            }
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                decryptTextBox.Text = "";
                
                MessageBox.Show("Er is iets misgegaan, is de juiste gebruiker gekozen om te decrypteren?");
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
                MessageBox.Show("Geen bestand geselecteerd. Kies een bestand.");
            }
            else if (!keyLoad)
            {
                MessageBox.Show("De sleutel matched niet of is nog niet geselecteerd!");
            }
            else if (!hashMatch)
            {
                MessageBox.Show("De hash matched niet of is nog niet geselecteerd!");
            }
            else
            {
                MessageBox.Show("Er heeft zich een fout voorgedaan, probeer het opnieuw.");
            }
        }
        private void selectKeyButton_Click(object sender, EventArgs e)
        {
            if (toggleABAmbiance.Toggled == true)
            {
                rsa.Persoon = 0;
            }
            else
            {
                rsa.Persoon = 1;
            }
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName))
            {
                try {
                    byte[] encryptedKey = File.ReadAllBytes(openFileDialog.FileName);
                    byte[] decryptedKey = rsa.DecrypteerBericht(encryptedKey);
                    des.Key = decryptedKey;
                
                selectKeyLabel.Text = "De sleutel matched.";
                keyLoad = true;
                }
                catch (Exception ex)
                {
                    selectKeyLabel.Text = "Fout bij de sleutel selecteren, probeer het opnieuw.";
                    keyLoad = false;
                }
            }
            else { 
                selectKeyLabel.Text = "Geen sleutel ingeladen.";
                keyLoad = false;
            }

        }

        private void toggleABAmbiance_ToggledChanged()
        {
            selectKeyLabel.Text = "Geen sleutel geselecteerd.";
            selectHashLabel.Text = "Geen hash geselecteerd.";
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
                rsa.Persoon = 0;
            }
            else
            {
                rsa.Persoon = 1;
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
                        selectHashLabel.Text = "De hash matched!";
                        hashMatch = true;
                    }
                    else
                    {
                        selectHashLabel.Text = "De hash matched niet. Probeer het opnieuw!";
                        hashMatch = false;
                    }
                }
                catch (Exception ex)
                {
                    selectHashLabel.Text = "Fout bij de hash selecteren. Probeer het opnieuw!";
                    hashMatch = false;
                }
            }
            else
            {
                selectHashLabel.Text = "Geen hash ingeladen.";
                hashMatch = false;
            }
        }

       

     

    }
}
