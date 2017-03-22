namespace BasicSecurity___PEOpdracht
{
    partial class DecrypteerForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ambianceThemeContainer = new Ambiance.Ambiance_ThemeContainer();
            this.ambianceControlBox = new Ambiance.Ambiance_ControlBox();
            this.selectHashLabel = new Ambiance.Ambiance_Label();
            this.selectHashButton = new Ambiance.Ambiance_Button_1();
            this.decryptFileButton = new Ambiance.Ambiance_Button_1();
            this.selectKeyLabel = new Ambiance.Ambiance_Label();
            this.selectKeyButton = new Ambiance.Ambiance_Button_1();
            this.decryptTextButton = new Ambiance.Ambiance_Button_1();
            this.decryptTextBox = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.selectedFileLabel = new Ambiance.Ambiance_Label();
            this.selectFileButton = new Ambiance.Ambiance_Button_1();
            this.toggleABAmbiance = new Ambiance.Ambiance_AB();
            this.ambianceThemeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ambianceThemeContainer
            // 
            this.ambianceThemeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambianceThemeContainer.Controls.Add(this.ambianceControlBox);
            this.ambianceThemeContainer.Controls.Add(this.selectHashLabel);
            this.ambianceThemeContainer.Controls.Add(this.selectHashButton);
            this.ambianceThemeContainer.Controls.Add(this.decryptFileButton);
            this.ambianceThemeContainer.Controls.Add(this.selectKeyLabel);
            this.ambianceThemeContainer.Controls.Add(this.selectKeyButton);
            this.ambianceThemeContainer.Controls.Add(this.decryptTextButton);
            this.ambianceThemeContainer.Controls.Add(this.decryptTextBox);
            this.ambianceThemeContainer.Controls.Add(this.ambiance_Label1);
            this.ambianceThemeContainer.Controls.Add(this.selectedFileLabel);
            this.ambianceThemeContainer.Controls.Add(this.selectFileButton);
            this.ambianceThemeContainer.Controls.Add(this.toggleABAmbiance);
            this.ambianceThemeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambianceThemeContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambianceThemeContainer.Location = new System.Drawing.Point(0, 0);
            this.ambianceThemeContainer.Name = "ambianceThemeContainer";
            this.ambianceThemeContainer.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambianceThemeContainer.RoundCorners = true;
            this.ambianceThemeContainer.Sizable = true;
            this.ambianceThemeContainer.Size = new System.Drawing.Size(516, 556);
            this.ambianceThemeContainer.SmartBounds = true;
            this.ambianceThemeContainer.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.ambianceThemeContainer.TabIndex = 3;
            this.ambianceThemeContainer.Text = "Decrypt";
            // 
            // ambianceControlBox
            // 
            this.ambianceControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ambianceControlBox.EnableMaximize = true;
            this.ambianceControlBox.EnableMinimize = true;
            this.ambianceControlBox.Font = new System.Drawing.Font("Marlett", 7F);
            this.ambianceControlBox.Location = new System.Drawing.Point(357, 12);
            this.ambianceControlBox.Name = "ambianceControlBox";
            this.ambianceControlBox.Size = new System.Drawing.Size(64, 22);
            this.ambianceControlBox.TabIndex = 19;
            this.ambianceControlBox.Text = "ambiance_ControlBox1";
            // 
            // selectHashLabel
            // 
            this.selectHashLabel.AutoSize = true;
            this.selectHashLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectHashLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.selectHashLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.selectHashLabel.Location = new System.Drawing.Point(142, 200);
            this.selectHashLabel.Name = "selectHashLabel";
            this.selectHashLabel.Size = new System.Drawing.Size(122, 20);
            this.selectHashLabel.TabIndex = 18;
            this.selectHashLabel.Text = "No hash selected";
            // 
            // selectHashButton
            // 
            this.selectHashButton.BackColor = System.Drawing.Color.Transparent;
            this.selectHashButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectHashButton.Image = null;
            this.selectHashButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectHashButton.Location = new System.Drawing.Point(23, 179);
            this.selectHashButton.Name = "selectHashButton";
            this.selectHashButton.Size = new System.Drawing.Size(113, 63);
            this.selectHashButton.TabIndex = 17;
            this.selectHashButton.Text = "Select Hash";
            this.selectHashButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.selectHashButton.Click += new System.EventHandler(this.selectHashButton_Click);
            // 
            // decryptFileButton
            // 
            this.decryptFileButton.BackColor = System.Drawing.Color.Transparent;
            this.decryptFileButton.Enabled = false;
            this.decryptFileButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.decryptFileButton.Image = null;
            this.decryptFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decryptFileButton.Location = new System.Drawing.Point(290, 325);
            this.decryptFileButton.Name = "decryptFileButton";
            this.decryptFileButton.Size = new System.Drawing.Size(177, 30);
            this.decryptFileButton.TabIndex = 16;
            this.decryptFileButton.Text = "Decrypt to file";
            this.decryptFileButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.decryptFileButton.Click += new System.EventHandler(this.decryptFileButton_Click);
            // 
            // selectKeyLabel
            // 
            this.selectKeyLabel.AutoSize = true;
            this.selectKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectKeyLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.selectKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.selectKeyLabel.Location = new System.Drawing.Point(142, 282);
            this.selectKeyLabel.Name = "selectKeyLabel";
            this.selectKeyLabel.Size = new System.Drawing.Size(114, 20);
            this.selectKeyLabel.TabIndex = 15;
            this.selectKeyLabel.Text = "No selected key";
            // 
            // selectKeyButton
            // 
            this.selectKeyButton.BackColor = System.Drawing.Color.Transparent;
            this.selectKeyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectKeyButton.Image = null;
            this.selectKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectKeyButton.Location = new System.Drawing.Point(23, 260);
            this.selectKeyButton.Name = "selectKeyButton";
            this.selectKeyButton.Size = new System.Drawing.Size(113, 63);
            this.selectKeyButton.TabIndex = 14;
            this.selectKeyButton.Text = "Select Key";
            this.selectKeyButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.selectKeyButton.Click += new System.EventHandler(this.selectKeyButton_Click);
            // 
            // decryptTextButton
            // 
            this.decryptTextButton.BackColor = System.Drawing.Color.Transparent;
            this.decryptTextButton.Enabled = false;
            this.decryptTextButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.decryptTextButton.Image = null;
            this.decryptTextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decryptTextButton.Location = new System.Drawing.Point(23, 329);
            this.decryptTextButton.Name = "decryptTextButton";
            this.decryptTextButton.Size = new System.Drawing.Size(177, 30);
            this.decryptTextButton.TabIndex = 13;
            this.decryptTextButton.Text = "Decrypt to text";
            this.decryptTextButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.decryptTextButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // decryptTextBox
            // 
            this.decryptTextBox.BackColor = System.Drawing.Color.Transparent;
            this.decryptTextBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.decryptTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.decryptTextBox.Location = new System.Drawing.Point(27, 361);
            this.decryptTextBox.MaxLength = 32767;
            this.decryptTextBox.Multiline = true;
            this.decryptTextBox.Name = "decryptTextBox";
            this.decryptTextBox.ReadOnly = false;
            this.decryptTextBox.Size = new System.Drawing.Size(440, 156);
            this.decryptTextBox.TabIndex = 12;
            this.decryptTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.decryptTextBox.UseSystemPasswordChar = false;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(24, 132);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(128, 20);
            this.ambiance_Label1.TabIndex = 11;
            this.ambiance_Label1.Text = "Decrypt as person";
            // 
            // selectedFileLabel
            // 
            this.selectedFileLabel.AutoSize = true;
            this.selectedFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectedFileLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.selectedFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.selectedFileLabel.Location = new System.Drawing.Point(142, 85);
            this.selectedFileLabel.Name = "selectedFileLabel";
            this.selectedFileLabel.Size = new System.Drawing.Size(113, 20);
            this.selectedFileLabel.TabIndex = 2;
            this.selectedFileLabel.Text = "No selected file";
            // 
            // selectFileButton
            // 
            this.selectFileButton.BackColor = System.Drawing.Color.Transparent;
            this.selectFileButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectFileButton.Image = null;
            this.selectFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFileButton.Location = new System.Drawing.Point(23, 59);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(113, 59);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Select file";
            this.selectFileButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            this.selectFileButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.selectFileButton_DragDrop);
            this.selectFileButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.selectFileButton_DragEnter);
            // 
            // toggleABAmbiance
            // 
            this.toggleABAmbiance.Location = new System.Drawing.Point(184, 132);
            this.toggleABAmbiance.Name = "toggleABAmbiance";
            this.toggleABAmbiance.Size = new System.Drawing.Size(79, 27);
            this.toggleABAmbiance.TabIndex = 5;
            this.toggleABAmbiance.Text = "ambiance_AB1";
            this.toggleABAmbiance.Toggled = false;
            this.toggleABAmbiance.Type = Ambiance.Ambiance_AB._Type.AB;
            this.toggleABAmbiance.ToggledChanged += new Ambiance.Ambiance_AB.ToggledChangedEventHandler(this.toggleABAmbiance_ToggledChanged);
            // 
            // DecrypteerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 556);
            this.Controls.Add(this.ambianceThemeContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "DecrypteerForm";
            this.Text = "Decrypt";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ambianceThemeContainer.ResumeLayout(false);
            this.ambianceThemeContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Ambiance.Ambiance_Button_1 selectFileButton;
        private Ambiance.Ambiance_Label selectedFileLabel;
        private Ambiance.Ambiance_ThemeContainer ambianceThemeContainer;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_AB toggleABAmbiance;
        private Ambiance.Ambiance_Button_1 decryptTextButton;
        private Ambiance.Ambiance_TextBox decryptTextBox;
        private Ambiance.Ambiance_Button_1 selectKeyButton;
        private Ambiance.Ambiance_Label selectKeyLabel;
        private Ambiance.Ambiance_Button_1 decryptFileButton;
        private Ambiance.Ambiance_Label selectHashLabel;
        private Ambiance.Ambiance_Button_1 selectHashButton;
        private Ambiance.Ambiance_ControlBox ambianceControlBox;
    }
}