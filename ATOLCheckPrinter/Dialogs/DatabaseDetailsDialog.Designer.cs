namespace ATOLCheckPrinter.Dialogs
{
    partial class DatabaseDetailsDialog
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
            this.databaseAddressLabel = new System.Windows.Forms.Label();
            this.databasePortLabel = new System.Windows.Forms.Label();
            this.databaseUserLabel = new System.Windows.Forms.Label();
            this.databasePasswordLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // databaseAddressLabel
            // 
            this.databaseAddressLabel.AutoSize = true;
            this.databaseAddressLabel.Location = new System.Drawing.Point(49, 15);
            this.databaseAddressLabel.Name = "databaseAddressLabel";
            this.databaseAddressLabel.Size = new System.Drawing.Size(41, 13);
            this.databaseAddressLabel.TabIndex = 0;
            this.databaseAddressLabel.Text = "Адрес:";
            // 
            // databasePortLabel
            // 
            this.databasePortLabel.AutoSize = true;
            this.databasePortLabel.Location = new System.Drawing.Point(55, 41);
            this.databasePortLabel.Name = "databasePortLabel";
            this.databasePortLabel.Size = new System.Drawing.Size(35, 13);
            this.databasePortLabel.TabIndex = 1;
            this.databasePortLabel.Text = "Порт:";
            // 
            // databaseUserLabel
            // 
            this.databaseUserLabel.AutoSize = true;
            this.databaseUserLabel.Location = new System.Drawing.Point(7, 67);
            this.databaseUserLabel.Name = "databaseUserLabel";
            this.databaseUserLabel.Size = new System.Drawing.Size(83, 13);
            this.databaseUserLabel.TabIndex = 2;
            this.databaseUserLabel.Text = "Пользователь:";
            // 
            // databasePasswordLabel
            // 
            this.databasePasswordLabel.AutoSize = true;
            this.databasePasswordLabel.Location = new System.Drawing.Point(42, 93);
            this.databasePasswordLabel.Name = "databasePasswordLabel";
            this.databasePasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.databasePasswordLabel.TabIndex = 3;
            this.databasePasswordLabel.Text = "Пароль:";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(96, 12);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(174, 20);
            this.addressBox.TabIndex = 4;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(96, 38);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(174, 20);
            this.portBox.TabIndex = 5;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(96, 64);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(174, 20);
            this.usernameBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(96, 90);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(174, 20);
            this.passwordBox.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(195, 116);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(114, 116);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // DatabaseDetailsDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(278, 148);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.databasePasswordLabel);
            this.Controls.Add(this.databaseUserLabel);
            this.Controls.Add(this.databasePortLabel);
            this.Controls.Add(this.databaseAddressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DatabaseDetailsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запрос данных";
            this.Load += new System.EventHandler(this.DatabaseDetailsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label databaseAddressLabel;
        private System.Windows.Forms.Label databasePortLabel;
        private System.Windows.Forms.Label databaseUserLabel;
        private System.Windows.Forms.Label databasePasswordLabel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}