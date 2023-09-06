using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_login : Form
    {
        Main fmain;
        public frm_login(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
        }


        private void cmd_login_Click(object sender, EventArgs e)
        {
            Tool.isLogin = true;
            new Loading(fmain).ShowDialog();

        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {

            fmain.isfromLogin = true;
            Application.Exit();
        }
        //
        private void frm_login_Load(object sender, EventArgs e)
        {
            Ini.IniFile ini = new Ini.IniFile(ClassSql.MMS_Path);
            string ComputerName = ini.IniReadValue("COMPUTER", "Name");
            string InstanceName = ini.IniReadValue("COMPUTER", "InstanceName");
            if (System.Environment.MachineName == ComputerName)
            {
                ClassSql.ConnectSqlInstance(InstanceName);
            }
        }

        private void frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                fmain.isfromLogin = true;
                Application.Exit();
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {





        }
    }
}
