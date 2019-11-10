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
    public partial class FormCheck : Form
    {
        public double total;

        public FormCheck()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            fptr.cancelReceipt();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            using (PositionAdd dialog = new PositionAdd())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fptr.setParam(Constants.LIBFPTR_PARAM_COMMODITY_NAME, string.Format("{0} {1}", dialog.code, dialog.name));
                    fptr.setParam(Constants.LIBFPTR_PARAM_PRICE, dialog.price);
                    fptr.setParam(Constants.LIBFPTR_PARAM_QUANTITY, 1.0);
                    fptr.setParam(Constants.LIBFPTR_PARAM_TAX_TYPE, Constants.LIBFPTR_TAX_VAT20);
                    if (fptr.registration() != 0)
                    {
                        MessageBox.Show(string.Format("Ошибка регистрации позиции.\nОшибка {0}: {1}", fptr.errorCode(), fptr.errorDescription()),
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        itemsList.Items.Add(string.Format("{0} {1} - {2} руб.", dialog.code, dialog.name, dialog.price));
                        total = double.Parse(totalLabel.Text);
                        total += dialog.price;
                        totalLabel.Text = total.ToString();
                    }
                }
            }
        }
    }
}
