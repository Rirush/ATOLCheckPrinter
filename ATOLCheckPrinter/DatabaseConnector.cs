using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOLCheckPrinter
{

    class DatabaseConnector
    {
        public static MySqlConnection conn;
        public static string connString;

        public static void Connect(string address, string port, string user, string password)
        {
            connString = string.Format("server={0};user={2};database=autoshop;port={1};password={3}", address, port, user, password);
            conn = new MySqlConnection(connString);
            conn.Open();
        }

        public static void Sync()
        {
            string commandA = @"CREATE TABLE IF NOT EXISTS pending_checks (
    id serial primary key,
    barcode char(9),
    price float,
    payment_method char(5),
    operation char(8),
    category_name varchar(64),
    mark varchar(100),
    model varchar(100),
    body varchar(100),
    number varchar(100),
    engine varchar(100),
    front_rear varchar(100),
    right_left varchar(100),
    up_down varchar(100),
    manufacturer varchar(100),
    remark varchar(600)
)";
            string commandB = @"DROP TRIGGER transfer_check";
            string commandC = @"CREATE TRIGGER transfer_check BEFORE INSERT ON operation FOR EACH ROW BEGIN
    INSERT INTO pending_checks (barcode, price, operation, payment_method) VALUES (NEW.barcode, NEW.price_rub, NEW.operation_type, NEW.account);
    UPDATE pending_checks c
        INNER JOIN barcode b ON c.barcode = b.barcode
        SET c.mark = b.field1, c.model = b.field2, c.body = b.field3, c.number = b.field4, c.engine = b.field5, c.front_rear = b.field6, c.right_left = b.field7, c.up_down = b.field8, c.manufacturer = b.field9, c.remark = b.remark
        WHERE c.barcode = NEW.barcode;
    UPDATE pending_checks
        SET category_name = (SELECT name FROM category WHERE category = (SELECT category FROM barcode WHERE barcode = NEW.barcode))
        WHERE barcode = NEW.barcode;
    DELETE FROM pending_checks WHERE operation = 'INS';
END";
            MySqlCommand c = new MySqlCommand(commandA, conn);
            c.ExecuteNonQuery();
            c.Dispose();
            c = new MySqlCommand(commandB, conn);
            try
            {
                c.ExecuteNonQuery();
            }
            catch { 
            }
            c.Dispose();
            c = new MySqlCommand(commandC, conn);
            c.ExecuteNonQuery();
            c.Dispose();
        }
        public static MySqlDataReader ReadEntries()
        {
            string sql = @"SELECT * FROM pending_checks";
            MySqlCommand c = new MySqlCommand(sql, conn);
            MySqlDataReader r = c.ExecuteReader();
            c.Dispose();
            return r;
        }

        public static void ClearEntry(int id)
        {
            string sql = @"DELETE FROM pending_checks WHERE id = " + id;
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand c = new MySqlCommand(sql, conn);
            c.ExecuteNonQuery();
            conn.Close();
            c.Dispose();
        }
    }
}
