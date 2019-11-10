namespace ATOLCheckPrinter
{
    partial class Printer
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
            this.cashierTooltip = new System.Windows.Forms.Label();
            this.cashierLabel = new System.Windows.Forms.Label();
            this.vatinTooltip = new System.Windows.Forms.Label();
            this.vatinLabel = new System.Windows.Forms.Label();
            this.changeDetailsButton = new System.Windows.Forms.Button();
            this.toggleSessionButton = new System.Windows.Forms.Button();
            this.printerActionsGroup = new System.Windows.Forms.GroupBox();
            this.jctradeIntegrationButton = new System.Windows.Forms.Button();
            this.printCheckButton = new System.Windows.Forms.Button();
            this.disablePaperReport = new System.Windows.Forms.CheckBox();
            this.printerActionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashierTooltip
            // 
            this.cashierTooltip.AutoSize = true;
            this.cashierTooltip.Location = new System.Drawing.Point(12, 9);
            this.cashierTooltip.Name = "cashierTooltip";
            this.cashierTooltip.Size = new System.Drawing.Size(47, 13);
            this.cashierTooltip.TabIndex = 0;
            this.cashierTooltip.Text = "Кассир:";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Location = new System.Drawing.Point(65, 9);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(67, 13);
            this.cashierLabel.TabIndex = 1;
            this.cashierLabel.Text = "cashierLabel";
            // 
            // vatinTooltip
            // 
            this.vatinTooltip.AutoSize = true;
            this.vatinTooltip.Location = new System.Drawing.Point(24, 28);
            this.vatinTooltip.Name = "vatinTooltip";
            this.vatinTooltip.Size = new System.Drawing.Size(34, 13);
            this.vatinTooltip.TabIndex = 2;
            this.vatinTooltip.Text = "ИНН:";
            // 
            // vatinLabel
            // 
            this.vatinLabel.AutoSize = true;
            this.vatinLabel.Location = new System.Drawing.Point(65, 28);
            this.vatinLabel.Name = "vatinLabel";
            this.vatinLabel.Size = new System.Drawing.Size(56, 13);
            this.vatinLabel.TabIndex = 3;
            this.vatinLabel.Text = "vatinLabel";
            // 
            // changeDetailsButton
            // 
            this.changeDetailsButton.Location = new System.Drawing.Point(355, 12);
            this.changeDetailsButton.Name = "changeDetailsButton";
            this.changeDetailsButton.Size = new System.Drawing.Size(131, 23);
            this.changeDetailsButton.TabIndex = 4;
            this.changeDetailsButton.Text = "Изменить данные";
            this.changeDetailsButton.UseVisualStyleBackColor = true;
            this.changeDetailsButton.Click += new System.EventHandler(this.changeDetailsButton_Click);
            // 
            // toggleSessionButton
            // 
            this.toggleSessionButton.Location = new System.Drawing.Point(232, 12);
            this.toggleSessionButton.Name = "toggleSessionButton";
            this.toggleSessionButton.Size = new System.Drawing.Size(117, 23);
            this.toggleSessionButton.TabIndex = 0;
            this.toggleSessionButton.Text = "Открыть смену";
            this.toggleSessionButton.UseVisualStyleBackColor = true;
            this.toggleSessionButton.Click += new System.EventHandler(this.toggleSessionButton_Click);
            // 
            // printerActionsGroup
            // 
            this.printerActionsGroup.Controls.Add(this.jctradeIntegrationButton);
            this.printerActionsGroup.Controls.Add(this.printCheckButton);
            this.printerActionsGroup.Enabled = false;
            this.printerActionsGroup.Location = new System.Drawing.Point(15, 55);
            this.printerActionsGroup.Name = "printerActionsGroup";
            this.printerActionsGroup.Size = new System.Drawing.Size(471, 299);
            this.printerActionsGroup.TabIndex = 6;
            this.printerActionsGroup.TabStop = false;
            // 
            // jctradeIntegrationButton
            // 
            this.jctradeIntegrationButton.Location = new System.Drawing.Point(12, 54);
            this.jctradeIntegrationButton.Name = "jctradeIntegrationButton";
            this.jctradeIntegrationButton.Size = new System.Drawing.Size(170, 29);
            this.jctradeIntegrationButton.TabIndex = 1;
            this.jctradeIntegrationButton.Text = "Интеграция с JcTrade Pro";
            this.jctradeIntegrationButton.UseVisualStyleBackColor = true;
            this.jctradeIntegrationButton.Click += new System.EventHandler(this.jctradeIntegrationButton_Click);
            // 
            // printCheckButton
            // 
            this.printCheckButton.Location = new System.Drawing.Point(12, 19);
            this.printCheckButton.Name = "printCheckButton";
            this.printCheckButton.Size = new System.Drawing.Size(170, 29);
            this.printCheckButton.TabIndex = 0;
            this.printCheckButton.Text = "Сформировать чек продажи";
            this.printCheckButton.UseVisualStyleBackColor = true;
            this.printCheckButton.Click += new System.EventHandler(this.printCheckButton_Click);
            // 
            // disablePaperReport
            // 
            this.disablePaperReport.AutoSize = true;
            this.disablePaperReport.Checked = true;
            this.disablePaperReport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disablePaperReport.Location = new System.Drawing.Point(232, 39);
            this.disablePaperReport.Name = "disablePaperReport";
            this.disablePaperReport.Size = new System.Drawing.Size(198, 17);
            this.disablePaperReport.TabIndex = 7;
            this.disablePaperReport.Text = "Тихое открытие/закрытие смены";
            this.disablePaperReport.UseVisualStyleBackColor = true;
            // 
            // Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 366);
            this.Controls.Add(this.disablePaperReport);
            this.Controls.Add(this.printerActionsGroup);
            this.Controls.Add(this.toggleSessionButton);
            this.Controls.Add(this.changeDetailsButton);
            this.Controls.Add(this.vatinLabel);
            this.Controls.Add(this.vatinTooltip);
            this.Controls.Add(this.cashierLabel);
            this.Controls.Add(this.cashierTooltip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Printer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Принтер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Printer_FormClosing);
            this.Load += new System.EventHandler(this.Printer_Load);
            this.printerActionsGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cashierTooltip;
        private System.Windows.Forms.Label cashierLabel;
        private System.Windows.Forms.Label vatinTooltip;
        private System.Windows.Forms.Label vatinLabel;
        private System.Windows.Forms.Button changeDetailsButton;
        private System.Windows.Forms.Button toggleSessionButton;
        private System.Windows.Forms.GroupBox printerActionsGroup;
        private System.Windows.Forms.Button printCheckButton;
        private System.Windows.Forms.Button jctradeIntegrationButton;
        private System.Windows.Forms.CheckBox disablePaperReport;
    }
}