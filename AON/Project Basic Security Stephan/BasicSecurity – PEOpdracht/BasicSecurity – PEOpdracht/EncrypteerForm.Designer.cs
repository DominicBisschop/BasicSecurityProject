namespace BasicSecurity___PEOpdracht
{
    partial class EncrypteerForm
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ambianceThemeContainer = new Ambiance.Ambiance_ThemeContainer();
            this.encryptFileButton = new Ambiance.Ambiance_Button_1();
            this.ambianceControlBox = new Ambiance.Ambiance_ControlBox();
            this.errorLabel = new Ambiance.Ambiance_Label();
            this.succesAmbianceLinkLabel = new Ambiance.Ambiance_LinkLabel();
            this.encryptMessageButton = new Ambiance.Ambiance_Button_1();
            this.readFromFileButton = new Ambiance.Ambiance_Button_1();
            this.toggleABAmbiance = new Ambiance.Ambiance_AB();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.messageTextbox = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.ambianceThemeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = ".txt files|*.txt";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // ambianceThemeContainer
            // 
            this.ambianceThemeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambianceThemeContainer.Controls.Add(this.encryptFileButton);
            this.ambianceThemeContainer.Controls.Add(this.ambianceControlBox);
            this.ambianceThemeContainer.Controls.Add(this.errorLabel);
            this.ambianceThemeContainer.Controls.Add(this.succesAmbianceLinkLabel);
            this.ambianceThemeContainer.Controls.Add(this.encryptMessageButton);
            this.ambianceThemeContainer.Controls.Add(this.readFromFileButton);
            this.ambianceThemeContainer.Controls.Add(this.toggleABAmbiance);
            this.ambianceThemeContainer.Controls.Add(this.ambiance_Label2);
            this.ambianceThemeContainer.Controls.Add(this.messageTextbox);
            this.ambianceThemeContainer.Controls.Add(this.ambiance_Label1);
            this.ambianceThemeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambianceThemeContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambianceThemeContainer.Location = new System.Drawing.Point(0, 0);
            this.ambianceThemeContainer.Name = "ambianceThemeContainer";
            this.ambianceThemeContainer.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambianceThemeContainer.RoundCorners = true;
            this.ambianceThemeContainer.Sizable = true;
            this.ambianceThemeContainer.Size = new System.Drawing.Size(698, 432);
            this.ambianceThemeContainer.SmartBounds = true;
            this.ambianceThemeContainer.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.ambianceThemeContainer.TabIndex = 0;
            this.ambianceThemeContainer.Text = "Encrypt";
            // 
            // encryptFileButton
            // 
            this.encryptFileButton.BackColor = System.Drawing.Color.Transparent;
            this.encryptFileButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.encryptFileButton.Image = null;
            this.encryptFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptFileButton.Location = new System.Drawing.Point(498, 380);
            this.encryptFileButton.Name = "encryptFileButton";
            this.encryptFileButton.Size = new System.Drawing.Size(177, 30);
            this.encryptFileButton.TabIndex = 11;
            this.encryptFileButton.Text = "Encrypt file";
            this.encryptFileButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.encryptFileButton.Click += new System.EventHandler(this.encryptFileButton_Click);
            // 
            // ambianceControlBox
            // 
            this.ambianceControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ambianceControlBox.EnableMaximize = true;
            this.ambianceControlBox.EnableMinimize = true;
            this.ambianceControlBox.Font = new System.Drawing.Font("Marlett", 7F);
            this.ambianceControlBox.Location = new System.Drawing.Point(450, 13);
            this.ambianceControlBox.Name = "ambianceControlBox";
            this.ambianceControlBox.Size = new System.Drawing.Size(64, 22);
            this.ambianceControlBox.TabIndex = 10;
            this.ambianceControlBox.Text = "ambiance_ControlBox1";
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(498, 119);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(177, 222);
            this.errorLabel.TabIndex = 9;
            // 
            // succesAmbianceLinkLabel
            // 
            this.succesAmbianceLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(146)))), ((int)(((byte)(106)))));
            this.succesAmbianceLinkLabel.AutoSize = true;
            this.succesAmbianceLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.succesAmbianceLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.succesAmbianceLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.succesAmbianceLinkLabel.LinkColor = System.Drawing.Color.Green;
            this.succesAmbianceLinkLabel.Location = new System.Drawing.Point(324, 56);
            this.succesAmbianceLinkLabel.Name = "succesAmbianceLinkLabel";
            this.succesAmbianceLinkLabel.Size = new System.Drawing.Size(168, 20);
            this.succesAmbianceLinkLabel.TabIndex = 8;
            this.succesAmbianceLinkLabel.TabStop = true;
            this.succesAmbianceLinkLabel.Text = "Text encrypted, click me";
            this.succesAmbianceLinkLabel.Visible = false;
            this.succesAmbianceLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(146)))), ((int)(((byte)(106)))));
            this.succesAmbianceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.succesAmbianceLinkLabel_LinkClicked);
            // 
            // encryptMessageButton
            // 
            this.encryptMessageButton.BackColor = System.Drawing.Color.Transparent;
            this.encryptMessageButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.encryptMessageButton.Image = null;
            this.encryptMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptMessageButton.Location = new System.Drawing.Point(27, 380);
            this.encryptMessageButton.Name = "encryptMessageButton";
            this.encryptMessageButton.Size = new System.Drawing.Size(465, 30);
            this.encryptMessageButton.TabIndex = 7;
            this.encryptMessageButton.Text = "Encrypt text";
            this.encryptMessageButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.encryptMessageButton.Visible = false;
            this.encryptMessageButton.Click += new System.EventHandler(this.encryptMessageButton_Click);
            // 
            // readFromFileButton
            // 
            this.readFromFileButton.BackColor = System.Drawing.Color.Transparent;
            this.readFromFileButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.readFromFileButton.Image = null;
            this.readFromFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.readFromFileButton.Location = new System.Drawing.Point(498, 344);
            this.readFromFileButton.Name = "readFromFileButton";
            this.readFromFileButton.Size = new System.Drawing.Size(177, 30);
            this.readFromFileButton.TabIndex = 6;
            this.readFromFileButton.Text = "Read from file";
            this.readFromFileButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.readFromFileButton.Click += new System.EventHandler(this.readFromFileButton_Click);
            // 
            // toggleABAmbiance
            // 
            this.toggleABAmbiance.Location = new System.Drawing.Point(560, 89);
            this.toggleABAmbiance.Name = "toggleABAmbiance";
            this.toggleABAmbiance.Size = new System.Drawing.Size(79, 27);
            this.toggleABAmbiance.TabIndex = 5;
            this.toggleABAmbiance.Text = "ambiance_AB1";
            this.toggleABAmbiance.Toggled = true;
            this.toggleABAmbiance.Type = Ambiance.Ambiance_AB._Type.AB;
            this.toggleABAmbiance.ToggledChanged += new Ambiance.Ambiance_AB.ToggledChangedEventHandler(this.toggleABAmbiance_ToggledChanged);
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(498, 89);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(56, 20);
            this.ambiance_Label2.TabIndex = 4;
            this.ambiance_Label2.Text = "Person:";
            // 
            // messageTextbox
            // 
            this.messageTextbox.BackColor = System.Drawing.Color.Transparent;
            this.messageTextbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.messageTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.messageTextbox.Location = new System.Drawing.Point(27, 89);
            this.messageTextbox.MaxLength = 32767;
            this.messageTextbox.Multiline = true;
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.ReadOnly = false;
            this.messageTextbox.Size = new System.Drawing.Size(465, 285);
            this.messageTextbox.TabIndex = 2;
            this.messageTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.messageTextbox.UseSystemPasswordChar = false;
            this.messageTextbox.TextChanged += new System.EventHandler(this.messageTextbox_TextChanged);
            this.messageTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.messageTextbox_DragDrop);
            this.messageTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.messageTextbox_DragEnter);
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(23, 56);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(111, 20);
            this.ambiance_Label1.TabIndex = 1;
            this.ambiance_Label1.Text = "Text to encrypt:";
            // 
            // EncrypteerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 432);
            this.Controls.Add(this.ambianceThemeContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "EncrypteerForm";
            this.Text = "Encrypt";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ambianceThemeContainer.ResumeLayout(false);
            this.ambianceThemeContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_ThemeContainer ambianceThemeContainer;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_TextBox messageTextbox;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_AB toggleABAmbiance;
        private Ambiance.Ambiance_Button_1 readFromFileButton;
        private Ambiance.Ambiance_Button_1 encryptMessageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Ambiance.Ambiance_LinkLabel succesAmbianceLinkLabel;
        private Ambiance.Ambiance_Label errorLabel;
        private Ambiance.Ambiance_ControlBox ambianceControlBox;
        private Ambiance.Ambiance_Button_1 encryptFileButton;
        private System.Windows.Forms.ToolTip toolTip;

    }
}