using Ini;
using System;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_server : Form
    {

        private const long BUTTON_DOWN_CODE = 0xa1;
        private const long BUTTON_UP_CODE = 0xa0;
        private const long WM_MOVING = 0x216;
        static bool left_button_down = false;




        public frm_server()
        {
            InitializeComponent();
        }

        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            //Check the state of the Left Mouse Button
            if ((long)m.Msg == BUTTON_DOWN_CODE)
                left_button_down = true;
            else if ((long)m.Msg == BUTTON_UP_CODE)
                left_button_down = false;

            if (left_button_down)
            {
                if ((long)m.Msg == WM_MOVING)
                {
                    //Set the forms opacity to 50% if user is moving
                    if (this.Opacity != 0.5)
                        this.Opacity = 0.5;
                }
            }

            else if (!left_button_down)
                if (this.Opacity != 1.0)
                    this.Opacity = 1.0;

            base.DefWndProc(ref m);
        }
        private void frm_server_Load(object sender, EventArgs e)
        {

            IniFile ini = new IniFile(ClassSql.MMS_Path);
            txt_Server.Text = ini.IniReadValue("CONNECTIONSTRING", "HOST");
            txt_database.Text = ini.IniReadValue("CONNECTIONSTRING", "DATABASE");
            txt_userID.Text = ini.IniReadValue("CONNECTIONSTRING", "ID");
            txt_Password.Text = ini.IniReadValue("CONNECTIONSTRING", "Password");

            //txt_Server.Text =   Properties.Settings.Default.Server;
            //txt_database.Text =  Properties.Settings.Default.Database;
            //txt_userID.Text =   Properties.Settings.Default.UID;
            //txt_Password.Text = Properties.Settings.Default.Password;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (ClassSql.ConnState)
            //{

            //    this.Close();


            //}
            //else
            //{
            //    if (MessageBox.Show("System is currently not connected to server! Would you like to continue?", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {

            //        Application.Exit();

            //    }


            //}
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ConnectionString = "Data Source=" + txt_Server.Text + ";Initial Catalog=" + txt_database.Text + ";Persist Security Info=True;User ID=" + txt_userID.Text + ";Password=" + txt_Password.Text + ";";

            Properties.Settings.Default.MyConString = ConnectionString;
            Properties.Settings.Default.Save();

            IniFile ini = new IniFile(ClassSql.MMS_Path);
            ini.IniWriteValue("CONNECTIONSTRING", "Key", ConnectionString);
            ini.IniWriteValue("CONNECTIONSTRING", "HOST", txt_Server.Text);
            ini.IniWriteValue("CONNECTIONSTRING", "DATABASE", txt_database.Text);
            ini.IniWriteValue("CONNECTIONSTRING", "ID", txt_userID.Text);
            ini.IniWriteValue("CONNECTIONSTRING", "Password", txt_Password.Text);




            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                db.Connection.Open();
                this.Close();
                //  MessageBox.Show(this, "Successfully Connected", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }

        }

        private void frm_server_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
