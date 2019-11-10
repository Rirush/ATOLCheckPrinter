using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atol.Drivers10.Fptr;

namespace ATOLCheckPrinter
{
    public partial class StartupForm : Form
    {

        static public IFptr fptr;
        private Printer p;

        public StartupForm()
        {
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            fptr.showProperties(Constants.LIBFPTR_GUI_PARENT_NATIVE, (IntPtr)0);
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            try
            {
                fptr = new Fptr();
            }
            catch
            {
                MessageBox.Show("Невозможно найти драйвер ККТ. Убедитесь что драйвер установлен", "Ошибка драйвера ККТ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            if (File.Exists("atol.json"))
            {
                string settings = File.ReadAllText("atol.json");
                fptr.setSettings(settings);
            }
        }

        private void StartupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fptr != null)
            {
                string settings = fptr.getSettings();
                File.WriteAllText("atol.json", settings);
                fptr.close();
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (fptr.open() != 0)
            {
                MessageBox.Show(string.Format("Невозможно установить соединение с кассой.\nОшибка {0}: {1}", fptr.errorCode(), fptr.errorDescription()),
                    "Ошибка соединения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Hide();
            p = new Printer(this);
            p.Show();
        }
    }
}
