using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace MedicalManagement
{
    public partial class frm_VisitDetail : Form
    {
        frm_search_Patient_Queuing Search_q;
        public frm_VisitDetail(frm_search_Patient_Queuing q)
        {
            InitializeComponent();
            Search_q = q;
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_VisitDetail_Load(object sender, EventArgs e)
        {
            
            //load();
        }

       


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            string purpose = "";

            foreach (CheckBox cb in flowLayoutPanel3.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                {
                    purpose += ", " + cb.Text;
                }
            }


            foreach (CheckBox cb in flowLayoutPanel4.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                {
                    purpose += ", " + cb.Text;
                }
            }

            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            //string uid = Guid.NewGuid().ToString();

            var r = db.sp_InsertVisit("", this.Tag.ToString(), "", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"), "", purpose).FirstOrDefault();
            if (r != null)
            {

                MessageBox.Show(this, string.Format("Duplicate Entry", "Error"), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                (Application.OpenForms["frm_visit"] as frm_visit).loadlist();
                Search_q.Close();
                this.Close();
            }





        }

       


    }
}
