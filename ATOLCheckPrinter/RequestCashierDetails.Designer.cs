namespace ATOLCheckPrinter
{
    partial class RequestCashierDetails
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
            this.tooltip = new System.Windows.Forms.Label();
            this.namePrompt = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.vatinPrompt = new System.Windows.Forms.Label();
            this.vatinBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tooltip
            // 
            this.tooltip.AutoSize = true;
            this.tooltip.Location = new System.Drawing.Point(12, 9);
            this.tooltip.Name = "tooltip";
            this.tooltip.Size = new System.Drawing.Size(172, 13);
            this.tooltip.TabIndex = 0;
            this.tooltip.Text = "Введите информацию о кассире";
            // 
            // namePrompt
            // 
            this.namePrompt.AutoSize = true;
            this.namePrompt.Location = new System.Drawing.Point(12, 32);
            this.namePrompt.Name = "namePrompt";
            this.namePrompt.Size = new System.Drawing.Size(82, 13);
            this.namePrompt.TabIndex = 1;
            this.namePrompt.Text = "ФИО кассира:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(100, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(168, 20);
            this.nameBox.TabIndex = 2;
            // 
            // vatinPrompt
            // 
            this.vatinPrompt.AutoSize = true;
            this.vatinPrompt.Location = new System.Drawing.Point(60, 58);
            this.vatinPrompt.Name = "vatinPrompt";
            this.vatinPrompt.Size = new System.Drawing.Size(34, 13);
            this.vatinPrompt.TabIndex = 3;
            this.vatinPrompt.Text = "ИНН:";
            // 
            // vatinBox
            // 
            this.vatinBox.Location = new System.Drawing.Point(100, 55);
            this.vatinBox.Name = "vatinBox";
            this.vatinBox.Size = new System.Drawing.Size(168, 20);
            this.vatinBox.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(193, 81);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // RequestCashierDetails
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 114);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.vatinBox);
            this.Controls.Add(this.vatinPrompt);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.namePrompt);
            this.Controls.Add(this.tooltip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RequestCashierDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RequestCashierDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tooltip;
        private System.Windows.Forms.Label namePrompt;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label vatinPrompt;
        private System.Windows.Forms.TextBox vatinBox;
        private System.Windows.Forms.Button okButton;
    }
}