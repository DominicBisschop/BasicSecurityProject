using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSecurity___PEOpdracht
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            ambianceControlBox.EnableMaximize = false;
            ambianceControlBox.Location = new Point(this.Width - 49, 13);
        }

        private void encrypteerButton_Click(object sender, EventArgs e)
        {
            EncrypteerForm form = new EncrypteerForm();
            form.Show();
        }

        private void decrypteerButton_Click(object sender, EventArgs e)
        {
            DecrypteerForm form = new DecrypteerForm();
            form.Show();
        }

        private void steganografieButton_Click(object sender, EventArgs e)
        {
            SteganographyForm form = new SteganographyForm();
            form.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
