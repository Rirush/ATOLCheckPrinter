using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOLCheckPrinter.Dialogs
{
    public partial class CheckPromptDialog : Form
    {
        string name, method;
        float price;

        public CheckPromptDialog(string name, float price, string method)
        {
            this.name = name;
            this.price = price;
            this.method = method;
            InitializeComponent();
        }

        private void CheckPromptDialog_Load(object sender, EventArgs e)
        {
            goodsNameLabel.Text = name;
            moneyLabel.Text = string.Format("{0} руб.", price);
            methodLabel.Text = method;
            //switch(method)
            //{
            //case "bank":

            //    break;
            //    case "inet":
            //        break;
            //}
        }
    }
}
