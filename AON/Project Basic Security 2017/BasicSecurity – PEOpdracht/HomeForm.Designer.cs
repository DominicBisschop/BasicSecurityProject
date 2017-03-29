namespace BasicSecurity___PEOpdracht
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.ambianceThemeContainer = new Ambiance.Ambiance_ThemeContainer();
            this.settingsButton = new Ambiance.Ambiance_Button_1();
            this.steganografieButton = new Ambiance.Ambiance_Button_1();
            this.decrypteerButton = new Ambiance.Ambiance_Button_1();
            this.encrypteerButton = new Ambiance.Ambiance_Button_1();
            this.ambianceControlBox = new Ambiance.Ambiance_ControlBox();
            this.ambianceThemeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ambianceThemeContainer
            // 
            this.ambianceThemeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambianceThemeContainer.Controls.Add(this.settingsButton);
            this.ambianceThemeContainer.Controls.Add(this.steganografieButton);
            this.ambianceThemeContainer.Controls.Add(this.decrypteerButton);
            this.ambianceThemeContainer.Controls.Add(this.encrypteerButton);
            this.ambianceThemeContainer.Controls.Add(this.ambianceControlBox);
            this.ambianceThemeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambianceThemeContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambianceThemeContainer.Location = new System.Drawing.Point(0, 0);
            this.ambianceThemeContainer.Name = "ambianceThemeContainer";
            this.ambianceThemeContainer.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambianceThemeContainer.RoundCorners = true;
            this.ambianceThemeContainer.Sizable = true;
            this.ambianceThemeContainer.Size = new System.Drawing.Size(567, 601);
            this.ambianceThemeContainer.SmartBounds = true;
            this.ambianceThemeContainer.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.ambianceThemeContainer.TabIndex = 4;
            this.ambianceThemeContainer.Text = "Basic security";
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Enabled = false;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(284, 322);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(256, 256);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // steganografieButton
            // 
            this.steganografieButton.BackColor = System.Drawing.Color.Transparent;
            this.steganografieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.steganografieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.steganografieButton.Enabled = false;
            this.steganografieButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.steganografieButton.Image = ((System.Drawing.Image)(resources.GetObject("steganografieButton.Image")));
            this.steganografieButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.steganografieButton.Location = new System.Drawing.Point(23, 322);
            this.steganografieButton.Name = "steganografieButton";
            this.steganografieButton.Size = new System.Drawing.Size(256, 256);
            this.steganografieButton.TabIndex = 3;
            this.steganografieButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.steganografieButton.Click += new System.EventHandler(this.steganografieButton_Click);
            // 
            // decrypteerButton
            // 
            this.decrypteerButton.BackColor = System.Drawing.Color.Transparent;
            this.decrypteerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decrypteerButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.decrypteerButton.Image = ((System.Drawing.Image)(resources.GetObject("decrypteerButton.Image")));
            this.decrypteerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decrypteerButton.Location = new System.Drawing.Point(285, 60);
            this.decrypteerButton.Name = "decrypteerButton";
            this.decrypteerButton.Size = new System.Drawing.Size(256, 256);
            this.decrypteerButton.TabIndex = 2;
            this.decrypteerButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.decrypteerButton.Click += new System.EventHandler(this.decrypteerButton_Click);
            // 
            // encrypteerButton
            // 
            this.encrypteerButton.BackColor = System.Drawing.Color.Transparent;
            this.encrypteerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encrypteerButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.encrypteerButton.Image = ((System.Drawing.Image)(resources.GetObject("encrypteerButton.Image")));
            this.encrypteerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.encrypteerButton.Location = new System.Drawing.Point(24, 60);
            this.encrypteerButton.Name = "encrypteerButton";
            this.encrypteerButton.Size = new System.Drawing.Size(256, 256);
            this.encrypteerButton.TabIndex = 1;
            this.encrypteerButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.encrypteerButton.Click += new System.EventHandler(this.encrypteerButton_Click);
            // 
            // ambianceControlBox
            // 
            this.ambianceControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ambianceControlBox.EnableMaximize = true;
            this.ambianceControlBox.EnableMinimize = true;
            this.ambianceControlBox.Font = new System.Drawing.Font("Marlett", 7F);
            this.ambianceControlBox.Location = new System.Drawing.Point(491, 12);
            this.ambianceControlBox.Name = "ambianceControlBox";
            this.ambianceControlBox.Size = new System.Drawing.Size(64, 22);
            this.ambianceControlBox.TabIndex = 0;
            this.ambianceControlBox.Text = "ambiance_ControlBox1";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 601);
            this.Controls.Add(this.ambianceThemeContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "HomeForm";
            this.Text = "Basic security";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ambianceThemeContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_ThemeContainer ambianceThemeContainer;
        private Ambiance.Ambiance_ControlBox ambianceControlBox;
        private Ambiance.Ambiance_Button_1 encrypteerButton;
        private Ambiance.Ambiance_Button_1 settingsButton;
        private Ambiance.Ambiance_Button_1 decrypteerButton;
        private Ambiance.Ambiance_Button_1 steganografieButton;
    }
}

