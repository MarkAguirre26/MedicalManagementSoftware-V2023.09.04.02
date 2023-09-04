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
    public partial class frm_employer : Form
    {
        public bool isFromMenu = false;
        private List<employer_model> employer_model;
        public frm_employer()
        {
            InitializeComponent();
            employer_model = new List<employer_model>();
        }

        private void cmd_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frm_employer_Load(object sender, EventArgs e)
        {
            if (isFromMenu)
            {
                cmdSelect.Visible = false;
            }

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            //getEmployer();
        }

        private void getEmployer()
        {
            //DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            //var list = db.sp_GetEmployer().ToList();
            //dataGridView1.DataSource = list;

            try
            {

                var list = this.employer_model.ToList();

                if (this.txt_employer.Text.Length > 0)
                {

                    list = (from m in list where m.Employer.StartsWith(txt_employer.Text, StringComparison.OrdinalIgnoreCase) select m).ToList();

                }

                this.dataGridView1.DataSource = list;





            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }

        private void cmd_save_Click(object sender, EventArgs e)
        {

            if (cmd_action.Text == "Clear")
            {
                txt_employer.Clear();
            }
            else
            {
                if (txt_employer.Text != "")
                {

                    DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                    var list = db.sp_CheckExist(txt_employer.Text).Count();
                    if (list > 0)
                    {
                        MessageBox.Show("Employer already Exist1", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        db.ExecuteCommand("INSERT INTO tbl_employer (Employer) VALUES ({0})", txt_employer.Text);
                        //getEmployer();
                    }
                    txt_employer.Clear();
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }




                }

            }




        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            DeleteItem();

        }


        private void DeleteItem()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                db.ExecuteCommand("DELETE FROM tbl_employer WHERE (cn={0})", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                getEmployer();
            }
        }
        private void frm_employer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F5)
            {
                getEmployer();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteItem();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getEmployer();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {


            var summaryForm = (Application.OpenForms["frm_summary"] as frm_summary);
            if (summaryForm != null)
            {
                summaryForm.txt_employer.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            else
            {
                (Application.OpenForms["frm_patientInfo"] as frm_patientInfo).cbo_employer.Tag = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                (Application.OpenForms["frm_patientInfo"] as frm_patientInfo).cbo_employer.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }

           


            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            getEmployer();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var list = db.sp_GetEmployer().ToList();
                Cursor.Current = Cursors.WaitCursor;
                employer_model.Clear();
                foreach (var i in list)
                {

                    employer_model.Add(new employer_model
                    {
                        cn = i.cn,
                        Employer = i.Employer
                    });

                }

            }));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            getEmployer();
        }

    }
}
