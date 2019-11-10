using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOLCheckPrinter
{
    public partial class PositionAdd : Form
    {
        public string code;
        public double price;
        public string name;

        public PositionAdd()
        {
            InitializeComponent();
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                taxBox.Text = (double.Parse(priceBox.Text) * 0.2).ToString();
            }
            catch (Exception)
            {
                taxBox.Text = "0";
            }
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
        {
            code = codeBox.Text;
            try
            {
                price = double.Parse(priceBox.Text);
            }
            catch
            {
                MessageBox.Show("Неправильный формат цены, добавление отменено", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }
            name = nameBox.Text;
        }

        private void codeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
