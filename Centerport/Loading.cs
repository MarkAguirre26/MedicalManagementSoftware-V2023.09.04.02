using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class Loading : Form
    {
        Main fmain;
        public List<QueueSearchList_Model> queueSearchList_Model = new List<QueueSearchList_Model>();
        public Loading(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            if (Tool.isLogin)
            {
                if (!bw_login.IsBusy)
                {
                    bw_login.RunWorkerAsync();
                }
            }
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           
               
            



        }
        List<Login_model> login_model = new List<Login_model>();
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate { login(); }));
        }

        private void login()
        {
            try
            {

                
                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                string pwd = EncodeString.Encrypt((Application.OpenForms["frm_login"] as frm_login).txt_password.Text);
                var list = db.sp_login((Application.OpenForms["frm_login"] as frm_login).txt_username.Text, pwd).ToList();

                foreach (var i in list)
                {
                    login_model.Add(new Login_model
                    {
                        cn = i.cn,
                        Fullname = i.Fullname,
                        UserLevel = Convert.ToInt32(i.UserLevel),

                    });

                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Invalid Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new frm_server().ShowDialog();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

                     
            
            
            var list = login_model.ToList();
            if (list.Count() >= 1)
            {
                foreach (var i in login_model)
                {
                    fmain.UserLevel = Convert.ToInt32(i.UserLevel);
                    fmain.UserCn = i.cn;


                }
                Tool.isLogin = false;

                if (fmain.UserLevel == 1)
                {
                    fmain.userToolStripMenuItem.Visible = true;
                    fmain.ts_del_profile.Visible = true;
                }
                else
                {
                    fmain.userToolStripMenuItem.Visible = false;
                    fmain.ts_del_profile.Visible = false;
                }

                (Application.OpenForms["frm_login"] as frm_login).Close();
                this.Close();


            }
            else
            {

               
               
                (Application.OpenForms["frm_login"] as frm_login).txt_username.Clear();
                (Application.OpenForms["frm_login"] as frm_login).txt_password.Clear();
                MessageBox.Show("User does not exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
           
        }
    }
}
