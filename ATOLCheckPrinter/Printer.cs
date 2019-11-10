using Atol.Drivers10.Fptr;
using ATOLCheckPrinter.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ATOLCheckPrinter.StartupForm;

namespace ATOLCheckPrinter
{
    public partial class Printer : Form
    {
        private StartupForm startup;
        private Cashier c;
        private bool sessionOpen = false;
        public Printer(StartupForm startup)
        {
            InitializeComponent();
            this.startup = startup;
        }

        private void Printer_Load(object sender, EventArgs e)
        {
            if (File.Exists("cashier.json"))
            {
                string data = File.ReadAllText("cashier.json");
                c = JsonConvert.DeserializeObject<Cashier>(data);
            }
            else
            {
                c = new Cashier("", "");
            }
            using (RequestCashierDetails cashierDetails = new RequestCashierDetails(c))
            {
                if (cashierDetails.ShowDialog() != DialogResult.OK)
                {
                    startup.Show();
                    Close();
                    return;
                }
                c = cashierDetails.c;
                string encodedData = JsonConvert.SerializeObject(c);
                File.WriteAllText("cashier.json", encodedData);
            }
            cashierLabel.Text = c.name;
            vatinLabel.Text = c.vatin;
        }

        private void Printer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sessionOpen)
            {
                MessageBox.Show("Перед закрытием принтера, необходимо закрыть смену", "Ошибка выхода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            startup.Close();
        }

        private void changeDetailsButton_Click(object sender, EventArgs e)
        {
            using (RequestCashierDetails cashierDetails = new RequestCashierDetails(c))
            {
                if (cashierDetails.ShowDialog() == DialogResult.OK)
                {
                    c = cashierDetails.c;
                }
            }
            cashierLabel.Text = c.name;
            vatinLabel.Text = c.vatin;
        }

        private void toggleSessionButton_Click(object sender, EventArgs e)
        {
            if (sessionOpen)
            {
                fptr.setParam(1021, c.name);
                fptr.setParam(1203, c.vatin);
                fptr.operatorLogin();
                fptr.setParam(Constants.LIBFPTR_PARAM_REPORT_TYPE, Constants.LIBFPTR_RT_CLOSE_SHIFT);
                if (fptr.report() != 0)
                {
                    MessageBox.Show(string.Format("Ошибка при закрытии смены.\nОшибка {0}: {1}", fptr.errorCode(), fptr.errorDescription()),
                        "Ошибка закрытия смены", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sessionOpen = false;
                printerActionsGroup.Enabled = false;
                toggleSessionButton.Text = "Открыть смену";
            }
            else
            {
                fptr.setParam(1021, c.name);
                fptr.setParam(1203, c.vatin);
                fptr.operatorLogin();
                if (fptr.openShift() != 0)
                {
                    MessageBox.Show(string.Format("Ошибка при открытии смены.\nОшибка {0}: {1}", fptr.errorCode(), fptr.errorDescription()),
                        "Ошибка откртия смены", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sessionOpen = true;
                printerActionsGroup.Enabled = true;
                toggleSessionButton.Text = "Закрыть смену";
                printCheckButton.Focus();
            }
        }

        private void printCheckButton_Click(object sender, EventArgs e)
        {
            fptr.setParam(1021, c.name);
            fptr.setParam(1203, c.vatin);
            fptr.operatorLogin();

            fptr.setParam(Constants.LIBFPTR_PARAM_RECEIPT_TYPE, Constants.LIBFPTR_RT_SELL);
            fptr.setParam(Constants.LIBFPTR_PARAM_USE_VAT18, true);
            if (fptr.openReceipt() != 0)
            {
                MessageBox.Show(string.Format("Ошибка при открытии чека.\nОшибка {0}: {1}", fptr.errorCode(), fptr.errorDescription()),
                        "Ошибка откртия чека", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (FormCheck c = new FormCheck())
            {
                if (c.ShowDialog() == DialogResult.OK)
                {
                    using (PaymentMethod p = new PaymentMethod(c.total))
                    {
                        if (p.ShowDialog() != DialogResult.OK)
                        {
                            fptr.cancelReceipt();
                            return;
                        }
                    }
                    double change = fptr.getParamDouble(Constants.LIBFPTR_PARAM_CHANGE);
                    MessageBox.Show(string.Format("Сдача: {0}", change));
                    if (fptr.closeReceipt() != 0)
                    {
                        MessageBox.Show(string.Format("Ошибка закрытия чека.\nОшибка {0}: {1}", fptr.errorCode(), fptr.errorDescription()), "Ошибка закрытия чека", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        while (fptr.checkDocumentClosed() < 0)
                        {
                            DialogResult r = MessageBox.Show(string.Format("Невозможно получить состояние чека. Необходимо устранить неполадку и проверить состояние чека снова.\nОшибка {0}: {1}", fptr.errorCode(), fptr.errorDescription()),
                                "Ошибка проверки статуса чека", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (r == DialogResult.Cancel)
                            {
                                return;
                            }
                        }

                        if (!fptr.getParamBool(Constants.LIBFPTR_PARAM_DOCUMENT_CLOSED))
                        {
                            MessageBox.Show("Чек не закрылся. Необходимо повторно сформировать чек и повторить попытку", "Ошибка закрытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (!fptr.getParamBool(Constants.LIBFPTR_PARAM_DOCUMENT_PRINTED))
                        {
                            while (fptr.continuePrint() < 0)
                            {
                                DialogResult r = MessageBox.Show(string.Format("Ошибка печати чека. Необходимо устранить неполадку и повторить печать чека снова.\nОшибка {0}: {1}", fptr.errorCode(), fptr.errorDescription()),
                                "Ошибка печати чека", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                if (r == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void jctradeIntegrationButton_Click(object sender, EventArgs e)
        {
            DatabaseDetails db;
            if (File.Exists("database.json"))
            {
                string data = File.ReadAllText("database.json");
                db = JsonConvert.DeserializeObject<DatabaseDetails>(data);
            }
            else
            {
                db = new DatabaseDetails
                {
                    address = "localhost",
                    port = "3306",
                    username = "root"
                };
            }
            using(DatabaseDetailsDialog dialog = new DatabaseDetailsDialog(db.address, db.port, db.username, db.password))
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    db.address = dialog.address;
                    db.port = dialog.port;
                    db.username = dialog.username;
                    db.password = dialog.password;
                    string data = JsonConvert.SerializeObject(db);
                    File.WriteAllText("database.json", data);
                    try
                    {
                        DatabaseConnector.Connect(db.address, db.port, db.username, db.password);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно подключиться к базе данных. Проверьте правильность введения данных", "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DatabaseConnector.Sync();
                    using(JcTradeIntegration integrationDialog = new JcTradeIntegration())
                    {
                        integrationDialog.ShowDialog();
                    }
                }
            }
        }
    }

    public class Cashier
    {
        public Cashier(string name, string vatin)
        {
            this.name = name;
            this.vatin = vatin;
        }

        public string name, vatin;
    }

    public class DatabaseDetails
    {
        public string address, port, username, password;
    }
}
