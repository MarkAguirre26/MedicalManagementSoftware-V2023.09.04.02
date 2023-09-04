

using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_summary : Form
    {
        DataClasses1DataContext db;
        private List<Summary> summaryList = new List<Summary>();
        public frm_summary()
        {
            InitializeComponent();
            MyClass.connectionString = Properties.Settings.Default.MyConString;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cmd_search_Click(object sender, EventArgs e)
        {
            if (txt_employer.Text == "")
            {
                MessageBox.Show("No employer selected!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                if (!backgroundWorker1.IsBusy)
                {
                    progressBar1.Value = 50;
                    backgroundWorker1.RunWorkerAsync();

                }


            }

        }


        private void dataSelection1_Leave(object sender, EventArgs e)
        {
            closeSelection();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // dataSelection1.Visible = true;
        }

        void closeSelection()
        {

            //dataSelection1.Visible = false;
            //txtDateRange.Text = variables.dateStart + " - " + variables.dateEnd;
        }

        private void dataSelection1_MouseLeave(object sender, EventArgs e)
        {
            closeSelection();
        }

        private void cmd_download_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                int r = rand.Next(1, 500);
                string source = TemplatePath.basePath + @"Source\ListOfPatients-TEMPLATE.xlsx";
                string file = TemplatePath.basePath + "ListOfPatients-TEMPLATE" + "_" + r + ".xlsx";
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                File.Copy(source, file);

                Reporting.Export(file.Replace(".xlsx", ""), summaryList, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }



        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            closeSelection();
        }

        private void frm_summary_Load(object sender, EventArgs e)
        {

            Tool.DeleteTemporaryFilesFromTemplate(TemplatePath.basePath);
            //
            //db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            //var list = db.sp_employer().ToList();
            //foreach (var i in list)
            //{
            //    cbo_employer.Items.Add(i.Employer);
            //}
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {


                DataTable dt = new DataTable();
                dt = MyClass.Table("exec sp_listOfPatientSummary '" + txt_employer.Text + "'");

                //foreach (DataRow dr in dt.Rows)
                //{
                //    MessageBox.Show(dr["Name"].ToString());

                //}


                //var list = db.sp_listOfPatientSummary(txt_employer.Text).ToList();

                dataGridView1.DataSource = dt;

                lbl_items.Text = "Items: " + dt.Rows.Count.ToString();
                closeSelection();
                if (dt.Rows.Count > 0)
                {
                    cmd_download.Enabled = true;
                    cmd_send.Enabled = true;
                }
                else
                {
                    cmd_download.Enabled = false;
                    cmd_send.Enabled = false;
                }


                //
                summaryList.Clear();
                dataGridView1.DataSource = null;

                foreach (DataRow dr in dt.Rows)
                {
                    summaryList.Add(new Summary
                    {

                        Lastname = dr["Lastname"].ToString(),
                        Firstname = dr["Firstname"].ToString(),
                        gender = dr["gender"].ToString(),
                        employer = dr["employer"].ToString(),
                        Contact = dr["Contact"].ToString(),
                        birthdate = dr["birthdate"].ToString(),
                        age = dr["Age"].ToString(),
                        BP = dr["BP"].ToString(),
                        BMI_Value = dr["BMI_Value"].ToString(),
                        BMI_Remark = dr["BMI_Remark"].ToString(),
                        OD_With_o_Glasses = dr["OD_With_o_Glasses"].ToString(),
                        OS_With_o_Glasses = dr["OS_With_o_Glasses"].ToString(),
                        OD_With_Glasses = dr["OD_With_Glasses"].ToString(),
                        OS_With_Glasses = dr["OS_With_Glasses"].ToString(),
                        BloodType_result = dr["BloodType_result"].ToString(),
                        Hema = dr["Hema"].ToString(),
                        Urinalysis = dr["Urinalysis"].ToString(),
                        Fecalysis = dr["Fecalysis"].ToString(),
                        Xray = dr["XRAY"].ToString(),
                        Ecg = dr["ECG"].ToString(),
                        Class = dr["Class"].ToString(),
                        Evaluation = dr["Evaluation"].ToString(),
                        remarks = dr["remarks"].ToString(),
                        recommendation = dr["recommendation"].ToString(),
                        result_date = dr["result_date"].ToString()

                    });
                }
                dataGridView1.DataSource = summaryList;

            }));
        }



        private Decimal removeNumber(string value)
        {

            Decimal dValue = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (!Char.IsDigit(value[i]) && value[i] != '.')
                {
                    dValue = Convert.ToDecimal(value.Substring(0, i));
                    break;
                }
            }
            return dValue;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_emailaddress().ShowDialog();
        }

        private void cmd_loadEmployer_Click(object sender, EventArgs e)
        {
            using (frm_employer f = new frm_employer())
            {
                f.cmd_action.Text = "Clear";
                f.Text = "Search";
                f.ShowDialog();

            }
        }

        private void frm_summary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }




    }
}
//