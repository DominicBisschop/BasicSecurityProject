using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BasicSecurity___PEOpdracht
{
    public partial class EncrypteerForm : Form
    {
        private DES des;
        private RSA rsa;

        public EncrypteerForm()
        {
            InitializeComponent();

            ambianceControlBox.EnableMaximize = false;
            ambianceControlBox.Location = new Point(this.Width - 49, 13);

            this.AllowDrop = true;
            this.DragEnter += messageTextbox_DragEnter;
            this.DragDrop += messageTextbox_DragDrop;

            toolTip.SetToolTip(ambianceThemeContainer, "Sleep een bestand naar hier om het in te lezen.");

            des = new DES();
            rsa = new RSA();
        }

        private void encryptMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] encryptedData = des.EncrypteerBericht(messageTextbox.Text);
                byte[] encryptedKey = rsa.EncrypteerBericht(des.Key);
                byte[] signedHash = rsa.RSASign(encryptedData);
                Console.WriteLine(Convert.ToString(des.Key));
                String textFile = "";
                String keyFile = "";
                String hashFile = "";
                if (toggleABAmbiance.Toggled == true)
                {
                    textFile = "/A-encryptedText.des";
                    keyFile = "/A-encryptedDES.key";
                    hashFile = "/A-signed.hash";
                }
                else
                {
                    textFile = "/B-encryptedText.des";
                    keyFile = "/B-encryptedDES.key";
                    hashFile = "/B-signed.hash";
                }

                System.IO.FileStream _FileStream = new System.IO.FileStream(Properties.Settings.Default.SharedFolder + textFile, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                _FileStream.Write(encryptedData, 0, encryptedData.Length);
                _FileStream.Close();

                _FileStream = new System.IO.FileStream(Properties.Settings.Default.SharedFolder + keyFile, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                _FileStream.Write(encryptedKey, 0, encryptedKey.Length);
                _FileStream.Close();

                _FileStream = new System.IO.FileStream(Properties.Settings.Default.SharedFolder + hashFile, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                _FileStream.Write(signedHash, 0, signedHash.Length);
                _FileStream.Close();
                succesAmbianceLinkLabel.Visible = true;
            }
            catch (Exception ex)
            {
                errorLabel.Text = "Er heeft zich een fout voorgedaan: " + ex.Message;
            }
        }

        private void messageTextbox_TextChanged(object sender, EventArgs e)
        {
            if (messageTextbox.Text != "")
            {
                encryptMessageButton.Visible = true;
            } 
            else
            {
                encryptMessageButton.Visible = false;
            }
        }

        private void readFromFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName);

                messageTextbox.Text = reader.ReadToEnd();

                reader.Close();
            }
        }

        private void succesAmbianceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.SharedFolder);
        }

        private void messageTextbox_DragEnter(object sender, DragEventArgs e)
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

        private void messageTextbox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                {
                    if (File.Exists(fileLoc))
                    {
                        using (TextReader tr = new StreamReader(fileLoc))
                        {
                            messageTextbox.Text += (tr.ReadToEnd());
                        }
                    }
                }
            }
        }

        private void encryptFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                String textFile = "";
                String keyFile = "";
                StreamReader reader = new StreamReader(openFileDialog.FileName);

                String ingelezenTekst = reader.ReadToEnd();
                
                reader.Close();
                if (toggleABAmbiance.Toggled == true)
                {
                    textFile = "/A-encryptedText.des";
                    keyFile = "/A-encryptedDES.key";
                }
                else
                {
                    textFile = "/B-encryptedText.des";
                    keyFile = "/B-encryptedDES.key";
                }
                byte[] encryptedData = des.EncrypteerBericht(ingelezenTekst);
                byte[] encryptedKey = rsa.EncrypteerBericht(des.Key);

                System.IO.FileStream _FileStream = new System.IO.FileStream(Properties.Settings.Default.SharedFolder + textFile, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                _FileStream.Write(encryptedData, 0, encryptedData.Length);
                _FileStream.Close();
                _FileStream = new System.IO.FileStream(Properties.Settings.Default.SharedFolder + keyFile, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                
                _FileStream.Write(encryptedKey, 0, encryptedKey.Length);
                _FileStream.Close();
            }
        }

        private void toggleABAmbiance_ToggledChanged()
        {
            if (toggleABAmbiance.Toggled == true)
            {
                rsa.Persoon = 0;
            }
            else
            {
                rsa.Persoon = 1;
            }
        }
    }
}
