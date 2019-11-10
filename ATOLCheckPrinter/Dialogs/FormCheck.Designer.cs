namespace ATOLCheckPrinter
{
    partial class FormCheck
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.itemsList = new System.Windows.Forms.ListBox();
            this.checkItemsLabel = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.totalTooltip = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(121, 359);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Отменить чек";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(12, 359);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(102, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Печать";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // itemsList
            // 
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(15, 41);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(211, 290);
            this.itemsList.TabIndex = 2;
            // 
            // checkItemsLabel
            // 
            this.checkItemsLabel.AutoSize = true;
            this.checkItemsLabel.Location = new System.Drawing.Point(12, 17);
            this.checkItemsLabel.Name = "checkItemsLabel";
            this.checkItemsLabel.Size = new System.Drawing.Size(89, 13);
            this.checkItemsLabel.TabIndex = 3;
            this.checkItemsLabel.Text = "Позиции в чеке:";
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(107, 12);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(119, 23);
            this.addItem.TabIndex = 0;
            this.addItem.Text = "+";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // totalTooltip
            // 
            this.totalTooltip.AutoSize = true;
            this.totalTooltip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTooltip.Location = new System.Drawing.Point(12, 336);
            this.totalTooltip.Name = "totalTooltip";
            this.totalTooltip.Size = new System.Drawing.Size(58, 20);
            this.totalTooltip.TabIndex = 5;
            this.totalTooltip.Text = "Итого:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.Location = new System.Drawing.Point(69, 336);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(19, 20);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "0";
            // 
            // FormCheck
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(236, 391);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalTooltip);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.checkItemsLabel);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование чека";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.Label checkItemsLabel;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label totalTooltip;
        private System.Windows.Forms.Label totalLabel;
    }
}