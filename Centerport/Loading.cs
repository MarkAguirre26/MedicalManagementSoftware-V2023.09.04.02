using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class Loading : Form
    {
        Main fmain;
        string isSystemActivated;
        List<Login_model> login_model = new List<Login_model>();
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


     
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

           isSystemActivated = Get("https://raw.githubusercontent.com/MarkAguirre26/walalang/main/index.txt");

           if (isSystemActivated.Contains("Activated"))
           {
               this.Invoke(new MethodInvoker(delegate { login(); }));
           }
           else
           {

           }

           
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


        private string Get(string uri)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }



        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isSystemActivated.Contains("Activated"))
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
            else
            {
                MessageBox.Show("Please contact your system administrator", "Maintenance Mode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
                     
            
            
           
           
        }
    }
}
