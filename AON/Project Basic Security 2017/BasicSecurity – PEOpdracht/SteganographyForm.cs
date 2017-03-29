using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSecurity___PEOpdracht
{
    public partial class SteganographyForm : Form
    {
        Boolean pictureIsSelected = false;
        public SteganographyForm()
        {
           
            InitializeComponent();

        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (toEncrypt.Text == "")
            {
                MessageBox.Show("Geef een tekst in om te encrypteren in de foto.");
            }
            else
            {
                if (pictureIsSelected) {
                    Bitmap bmp = SteganographyClass.EncryptBitmap(toEncrypt.Text, new Bitmap(thePicture.Image));
                    thePicture.Image = bmp;
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "PNG files|*.png|JPG Files|*.jpg |BMP Files|*.bmp";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureIsSelected = true;
                        bmp.Save(dialog.FileName, ImageFormat.Bmp);
                        toEncrypt.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Geen foto om op te slaan. Kies een foto.");
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (pictureIsSelected)
            {
                string decrypt = SteganographyClass.extractText((Bitmap)thePicture.Image);
                string sdecrypt = Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(decrypt));
                if (decrypt== sdecrypt)
                {
                    toEncrypt.Text = decrypt;
                }
                
            }
            

        }

        private void fileButton_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog = new OpenFileDialog();         

            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {                
                thePicture.ImageLocation = openFileDialog.FileName;
                pictureIsSelected = true;
                thePicture.Refresh();
                maxSizeLabel.Text = berekenMaxSize().ToString() + " karakters"; //<- characters
            }            
        }

        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };

        private int berekenMaxSize()
        {
            currentSizeLabel.Text = toEncrypt.Text.Length.ToString();
            int maxSize = (thePicture.Image.Width * thePicture.Image.Height * 3) / 8;
            toEncrypt.MaxLength = maxSize;
            return maxSize;
        }

        private void toEncrypt_TextChanged_1(object sender, EventArgs e)
        {
            if (pictureIsSelected)
            {
                currentSizeLabel.Text = toEncrypt.Text.Length.ToString();
            }
        }      

        private void toEncrypt_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void toEncrypt_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
