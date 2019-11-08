using Atol.Drivers10.Fptr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ATOLCheckPrinter.StartupForm;

namespace ATOLCheckPrinter
{
    public partial class PaymentMethod : Form
    {
        double total;

        public PaymentMethod(double total)
        {
            this.total = total;
            InitializeComponent();
        }

        private void paidBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            double paid = 0;
            try
            {
                paid = double.Parse(paidBox.Text);
            }
            catch
            {
                DialogResult = DialogResult.Cancel;
                MessageBox.Show("Неверная сумма платежа, печать чека отменена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cashPayment.Checked)
            {
                fptr.setParam(Constants.LIBFPTR_PARAM_PAYMENT_TYPE, Constants.LIBFPTR_PT_CASH);
            }
            else if (cardPayment.Checked)
            {
                fptr.setParam(Constants.LIBFPTR_PARAM_PAYMENT_TYPE, Constants.LIBFPTR_PT_ELECTRONICALLY);
            }
            else if (prepaidPayment.Checked)
            {
                fptr.setParam(Constants.LIBFPTR_PARAM_PAYMENT_TYPE, Constants.LIBFPTR_PT_PREPAID);
            }
            else if (creditPayment.Checked)
            {
                fptr.setParam(Constants.LIBFPTR_PARAM_PAYMENT_TYPE, Constants.LIBFPTR_PT_CREDIT);
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                MessageBox.Show("Не выбрано ни одного метода оплаты, печать чека отменена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fptr.setParam(Constants.LIBFPTR_PARAM_PAYMENT_SUM, paid);
            if (fptr.payment() != 0)
            {
                DialogResult = DialogResult.Cancel;
                MessageBox.Show(string.Format("Ошибка оформления метода платежа.\nОшибка {0}: {1}", fptr.errorCode(), fptr.errorDescription()), "Ошибка платежа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaymentMethod_Load(object sender, EventArgs e)
        {
            totalLabel.Text = string.Format("{0} руб.", total);

        }
    }
}
