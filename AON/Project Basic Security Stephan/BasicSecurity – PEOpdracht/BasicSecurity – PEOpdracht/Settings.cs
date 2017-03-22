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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            ambianceControlBox.EnableMaximize = false;
            ambianceControlBox.Location = new Point(this.Width - 49, 13);
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            if (folderBrowserDialog.SelectedPath != "")
            {
                sharedFolderTextbox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
