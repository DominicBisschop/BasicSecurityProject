namespace BasicSecurity___PEOpdracht
{
    partial class Settings
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ambianceThemeContainer = new Ambiance.Ambiance_ThemeContainer();
            this.cancelButton = new Ambiance.Ambiance_Button_1();
            this.saveButton = new Ambiance.Ambiance_Button_1();
            this.selectFolderButton = new Ambiance.Ambiance_Button_1();
            this.sharedFolderTextbox = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.ambianceControlBox = new Ambiance.Ambiance_ControlBox();
            this.ambianceThemeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ambianceThemeContainer
            // 
            this.ambianceThemeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambianceThemeContainer.Controls.Add(this.cancelButton);
            this.ambianceThemeContainer.Controls.Add(this.saveButton);
            this.ambianceThemeContainer.Controls.Add(this.selectFolderButton);
            this.ambianceThemeContainer.Controls.Add(this.sharedFolderTextbox);
            this.ambianceThemeContainer.Controls.Add(this.ambiance_Label1);
            this.ambianceThemeContainer.Controls.Add(this.ambianceControlBox);
            this.ambianceThemeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambianceThemeContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambianceThemeContainer.Location = new System.Drawing.Point(0, 0);
            this.ambianceThemeContainer.Name = "ambianceThemeContainer";
            this.ambianceThemeContainer.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambianceThemeContainer.RoundCorners = true;
            this.ambianceThemeContainer.Sizable = true;
            this.ambianceThemeContainer.Size = new System.Drawing.Size(559, 163);
            this.ambianceThemeContainer.SmartBounds = true;
            this.ambianceThemeContainer.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.ambianceThemeContainer.TabIndex = 0;
            this.ambianceThemeContainer.Text = "Settings";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancelButton.Image = null;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(27, 107);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(177, 30);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveButton.Image = null;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(354, 107);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 30);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.selectFolderButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectFolderButton.Image = null;
            this.selectFolderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFolderButton.Location = new System.Drawing.Point(499, 54);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(32, 30);
            this.selectFolderButton.TabIndex = 3;
            this.selectFolderButton.Text = "...";
            this.selectFolderButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // sharedFolderTextbox
            // 
            this.sharedFolderTextbox.BackColor = System.Drawing.Color.Transparent;
            this.sharedFolderTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BasicSecurity___PEOpdracht.Properties.Settings.Default, "SharedFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sharedFolderTextbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.sharedFolderTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.sharedFolderTextbox.Location = new System.Drawing.Point(131, 56);
            this.sharedFolderTextbox.MaxLength = 32767;
            this.sharedFolderTextbox.Multiline = false;
            this.sharedFolderTextbox.Name = "sharedFolderTextbox";
            this.sharedFolderTextbox.ReadOnly = false;
            this.sharedFolderTextbox.Size = new System.Drawing.Size(362, 28);
            this.sharedFolderTextbox.TabIndex = 2;
            this.sharedFolderTextbox.Text = global::BasicSecurity___PEOpdracht.Properties.Settings.Default.SharedFolder;
            this.sharedFolderTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.sharedFolderTextbox.UseSystemPasswordChar = false;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(23, 56);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(102, 20);
            this.ambiance_Label1.TabIndex = 1;
            this.ambiance_Label1.Text = "Shared folder:";
            // 
            // ambianceControlBox
            // 
            this.ambianceControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ambianceControlBox.EnableMaximize = true;
            this.ambianceControlBox.EnableMinimize = true;
            this.ambianceControlBox.Font = new System.Drawing.Font("Marlett", 7F);
            this.ambianceControlBox.Location = new System.Drawing.Point(5, 13);
            this.ambianceControlBox.Name = "ambianceControlBox";
            this.ambianceControlBox.Size = new System.Drawing.Size(64, 22);
            this.ambianceControlBox.TabIndex = 0;
            this.ambianceControlBox.Text = "ambiance_ControlBox1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 163);
            this.Controls.Add(this.ambianceThemeContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "Settings";
            this.Text = "Settings";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ambianceThemeContainer.ResumeLayout(false);
            this.ambianceThemeContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_ThemeContainer ambianceThemeContainer;
        private Ambiance.Ambiance_ControlBox ambianceControlBox;
        private Ambiance.Ambiance_TextBox sharedFolderTextbox;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_Button_1 selectFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private Ambiance.Ambiance_Button_1 cancelButton;
        private Ambiance.Ambiance_Button_1 saveButton;

    }
}