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
    public partial class RequestCashierDetails : Form
    {
        public Cashier c;

        public RequestCashierDetails(Cashier c)
        {
            InitializeComponent();
            this.c = c;
        }

        public RequestCashierDetails()
        {
            InitializeComponent();
        }

        private void RequestCashierDetails_Load(object sender, EventArgs e)
        {
            nameBox.Text = c.name;
            vatinBox.Text = c.vatin;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            c.name = nameBox.Text;
            c.vatin = vatinBox.Text;
        }
    }
}
