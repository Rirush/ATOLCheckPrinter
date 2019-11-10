using MySql.Data.MySqlClient;
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
    public partial class JcTradeIntegration : Form
    {
        public JcTradeIntegration()
        {
            InitializeComponent();
        }

        private void databaseTimer_Tick(object sender, EventArgs e)
        {
            databaseTimer.Stop();
            statusLabel.Text = "Чтение данных...";
            MySqlDataReader r = DatabaseConnector.ReadEntries();
            while(r.Read())
            {
                statusLabel.Text = "Чтение данных...";
                string barcode, paymentMethod, operation, categoryName, mark, model, body, number, engine, frontRear, rightLeft, upDown, manufacturer, remark;
                float price;
                ulong id;
                id = (ulong)r[0];
                barcode = r[1] as string;
                price = (float)r[2];
                paymentMethod = r[3] as string;
                operation = r[4] as string;
                categoryName = r[5] as string;
                mark = r[6] as string;
                model = r[7] as string;
                body = r[8] as string;
                //if (body == "-")
                //    body = "";
                number = r[9] as string;
                //if (number == "-")
                //    number = "";
                engine = r[10] as string;
                //if (engine == "-")
                //    engine = "";
                frontRear = r[11] as string;
                //if (frontRear == "-")
                //    frontRear = "";
                rightLeft = r[12] as string;
                //if (rightLeft == "-")
                //    rightLeft = "";
                upDown = r[13] as string;
                //if (upDown == "-")
                //    upDown = "";
                manufacturer = r[14] as string;
                //if (manufacturer == "-")
                //    manufacturer = "";
                remark = r[15] as string;
                if (operation != "SELL")
                {
                    DatabaseConnector.ClearEntry((int)id);
                    continue;
                }
                statusLabel.Text = "Формирование чека...";
                string name = string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}",
                                            int.Parse(barcode),
                                            categoryName,
                                            mark,
                                            model,
                                            body,
                                            number,
                                            engine,
                                            frontRear,
                                            rightLeft,
                                            upDown,
                                            manufacturer,
                                            remark);
                using(CheckPromptDialog dialog = new CheckPromptDialog(name, price, paymentMethod))
                {
                    dialog.TopMost = true;
                    dialog.ShowDialog();
                }
                DatabaseConnector.ClearEntry((int)id);
            }
            r.Close();
            statusLabel.Text = "Ожидание данных...";
            databaseTimer.Start();
        }
    }
}
