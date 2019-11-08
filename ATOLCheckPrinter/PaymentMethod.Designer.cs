namespace ATOLCheckPrinter
{
    partial class PaymentMethod
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cashPayment = new System.Windows.Forms.RadioButton();
            this.cardPayment = new System.Windows.Forms.RadioButton();
            this.prepaidPayment = new System.Windows.Forms.RadioButton();
            this.creditPayment = new System.Windows.Forms.RadioButton();
            this.paidTooltip = new System.Windows.Forms.Label();
            this.paidBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.totalTooltip = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creditPayment);
            this.groupBox1.Controls.Add(this.prepaidPayment);
            this.groupBox1.Controls.Add(this.cardPayment);
            this.groupBox1.Controls.Add(this.cashPayment);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод оплаты:";
            // 
            // cashPayment
            // 
            this.cashPayment.AutoSize = true;
            this.cashPayment.Checked = true;
            this.cashPayment.Location = new System.Drawing.Point(10, 19);
            this.cashPayment.Name = "cashPayment";
            this.cashPayment.Size = new System.Drawing.Size(76, 17);
            this.cashPayment.TabIndex = 0;
            this.cashPayment.TabStop = true;
            this.cashPayment.Text = "Наличные";
            this.cashPayment.UseVisualStyleBackColor = true;
            // 
            // cardPayment
            // 
            this.cardPayment.AutoSize = true;
            this.cardPayment.Location = new System.Drawing.Point(10, 42);
            this.cardPayment.Name = "cardPayment";
            this.cardPayment.Size = new System.Drawing.Size(129, 17);
            this.cardPayment.TabIndex = 1;
            this.cardPayment.Text = "Безналичная оплата";
            this.cardPayment.UseVisualStyleBackColor = true;
            // 
            // prepaidPayment
            // 
            this.prepaidPayment.AutoSize = true;
            this.prepaidPayment.Location = new System.Drawing.Point(10, 65);
            this.prepaidPayment.Name = "prepaidPayment";
            this.prepaidPayment.Size = new System.Drawing.Size(86, 17);
            this.prepaidPayment.TabIndex = 2;
            this.prepaidPayment.Text = "Предоплата";
            this.prepaidPayment.UseVisualStyleBackColor = true;
            // 
            // creditPayment
            // 
            this.creditPayment.AutoSize = true;
            this.creditPayment.Location = new System.Drawing.Point(11, 88);
            this.creditPayment.Name = "creditPayment";
            this.creditPayment.Size = new System.Drawing.Size(61, 17);
            this.creditPayment.TabIndex = 3;
            this.creditPayment.Text = "Кредит";
            this.creditPayment.UseVisualStyleBackColor = true;
            // 
            // paidTooltip
            // 
            this.paidTooltip.AutoSize = true;
            this.paidTooltip.Location = new System.Drawing.Point(9, 158);
            this.paidTooltip.Name = "paidTooltip";
            this.paidTooltip.Size = new System.Drawing.Size(53, 13);
            this.paidTooltip.TabIndex = 1;
            this.paidTooltip.Text = "Внесено:";
            // 
            // paidBox
            // 
            this.paidBox.Location = new System.Drawing.Point(62, 155);
            this.paidBox.Name = "paidBox";
            this.paidBox.Size = new System.Drawing.Size(150, 20);
            this.paidBox.TabIndex = 2;
            this.paidBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paidBox_KeyPress);
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(90, 181);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(122, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Подтвердить оплату";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(9, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // totalTooltip
            // 
            this.totalTooltip.AutoSize = true;
            this.totalTooltip.Location = new System.Drawing.Point(7, 136);
            this.totalTooltip.Name = "totalTooltip";
            this.totalTooltip.Size = new System.Drawing.Size(55, 13);
            this.totalTooltip.TabIndex = 5;
            this.totalTooltip.Text = "К оплате:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.Location = new System.Drawing.Point(59, 137);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(42, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "0 руб.";
            // 
            // PaymentMethod
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(223, 218);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalTooltip);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.paidBox);
            this.Controls.Add(this.paidTooltip);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор метода оплаты";
            this.Load += new System.EventHandler(this.PaymentMethod_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton creditPayment;
        private System.Windows.Forms.RadioButton prepaidPayment;
        private System.Windows.Forms.RadioButton cardPayment;
        private System.Windows.Forms.RadioButton cashPayment;
        private System.Windows.Forms.Label paidTooltip;
        private System.Windows.Forms.TextBox paidBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label totalTooltip;
        private System.Windows.Forms.Label totalLabel;
    }
}