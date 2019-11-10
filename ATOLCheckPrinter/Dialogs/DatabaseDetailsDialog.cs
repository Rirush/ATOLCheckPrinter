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
    public partial class DatabaseDetailsDialog : Form
    {
        public string address, port, username, password;

        private void DatabaseDetailsDialog_Load(object sender, EventArgs e)
        {
            addressBox.Text = address;
            portBox.Text = port;
            usernameBox.Text = username;
            passwordBox.Text = password;
        }

        public DatabaseDetailsDialog(string address, string port, string username, string password)
        {
            this.address = address;
            this.port = port;
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            address = addressBox.Text;
            port = portBox.Text;
            username = usernameBox.Text;
            password = passwordBox.Text;
        }
    }
}
