
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_NewPatient : Form
    {
        Main fmain;
        public static PictureBox img;
        private string papin;
        public frm_NewPatient(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
            img = pic_; img.AllowDrop = true;
        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void cbo_employer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_NewPatient_Load(object sender, EventArgs e)
        {
           
            backgroundWorker1.RunWorkerAsync();
            panel1.Enabled = false;
            cmd_save.Enabled = false;
            txt_transdateAndTime.Text = DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();

            load_Employer();
            Cursor.Current = Cursors.Default;

        }

        void load_Employer()
        {
      
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var list = db.sp_GetEmployer().ToList();
            foreach (var i in list)
            {
                cbo_employer.Items.Add(i.Employer);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        void SaveImage()
        {




        }
        public string ReplaceString(string str)
        {
            return str.Replace("'", "`").Replace(@"\", "\\");
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
       
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);


            if (txt_lname.Text == "" || txt_fname.Text == "" || txt_Mname.Text == "" || dt_bdayNew.Text == "00/00/0000" || cbo_employer.Text == "")
            {
                MessageBox.Show("Please fill all fields with blue label or Red (*) mark.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {


                var cnt = db.sp_PsychoCheckPatientifExist(txt_lname.Text + ", " + txt_fname.Text + " " + txt_Mname.Text).FirstOrDefault();

                if (cnt.PatientCount >= 1)
                {
                    MessageBox.Show("Patient has existing record in datadase.", "Record Exit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
                else
                {

                  
                    db.ExecuteCommand("INSERT INTO m_patient (papin, lastname, firstname, middlename, address_1, address_2, city, district, contact_1, contact_2, position, marital_status, gender, birthdate, place_of_birth, type_of_job, employer, passport_no, seamansbook_no, picture,registration_date, remarks, nationality, religion, test_data, father_name, father_occupation, mother_name, no_of_brothers, no_of_sisters, birth_order, spouse_name, spouse_occupation, no_of_children, elementary, highschool, college, course, highest_level_attended, mother_occupation, prev_work_start, prev_work_end, prev_company, prev_position, prev_leave_reason, prev_years, date_last_updated, sirb, designation) values ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38},{39},{40},{41},{42},{43},{44},{45},{46},{47},{48})", txt_papin.Text, txt_lname.Text, txt_fname.Text, txt_Mname.Text, "", " ", "", " ", "", " ", cbo_Position.Text, cbo_marital.Text, cbo_gender.Text, dt_bdayNew.Text, "", "", cbo_employer.Text, "", "", Tool.ImageToByte(pic_.Image), dt_regDate.Text, "", txt_nationality.Text, cbo_religeon.Text, "0", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "00/00/0000", "00/00/0000", "-", "-", "-", "-", DateTime.Now, "-", "-");
                    db.ExecuteCommand("INSERT INTO t_registration (trkid, papin, pxtype, trans_date, diagnosis,purpose) VALUES ({0},{1},{2},{3},{4},{5})", txt_trackingNo.Text, txt_papin.Text, cbo_patient_Type.Text, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"), "", "Psycho");

                    frm_Psych_Evaluation.pin.Text = txt_papin.Text;
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Availability(true);
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).ClearAll();
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Search_Patient();
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).New();
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).backgroundWorker1.RunWorkerAsync();
                    fmain.ts_add_Eval.Enabled = false; fmain.ts_edit_Eval.Enabled = false; fmain.ts_delete_Eval.Enabled = false; fmain.ts_save_Eval.Enabled = true; fmain.ts_search_Eval.Enabled = false; fmain.ts_print_Eval.Enabled = false; fmain.ts_cancel_Eval.Enabled = true;

                    this.Close();



                }


            }



          



        }

        private void cbo_gender_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbo_marital_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbo_religeon_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_nationality_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_nationality_KeyDown(object sender, KeyEventArgs e)
        {
            txt_nationality.FindString(e.KeyValue.ToString());
        }

        private void cbo_religeon_KeyDown(object sender, KeyEventArgs e)
        {
            cbo_religeon.FindString(e.KeyValue.ToString());
        }

        private void cbo_marital_KeyDown(object sender, KeyEventArgs e)
        {
            cbo_marital.FindString(e.KeyValue.ToString());
        }

        private void cbo_gender_KeyDown(object sender, KeyEventArgs e)
        {
            cbo_gender.FindString(e.KeyValue.ToString());
        }

        private void dt_bdayNew_ValueChanged(object sender, EventArgs e)
        {
            DateTime CurrentDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            int Age = CurrentDate.Year - dt_bdayNew.Value.Year;// Convert.ToDateTime(dtbday.Text).Year;          
            if (CurrentDate.Month < dt_bdayNew.Value.Month)
            {
                Age--;
            }
            else if ((CurrentDate.Month == dt_bdayNew.Value.Month) && (CurrentDate.Day < dt_bdayNew.Value.Day))
            {

                Age--;
            }
            txt_age.Text = Age.ToString();

        }

        private void cmd_new_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;       
            txt_papin.Text = papin;
            panel1.Enabled = true;
            cmd_save.Enabled = true;
            cmd_new.Enabled = false;
            cmd_close.Text = "Cancel";
            Cursor.Current = Cursors.Default;

        }


        private void cmd_close_Click(object sender, EventArgs e)
        {
            if (cmd_close.Text == "Cancel")
            {

                cmd_close.Text = "Close";
                cmd_save.Enabled = false;
                panel1.Enabled = false;
                cmd_new.Enabled = true;
            }
            else if (cmd_close.Text == "Close")
            {

                this.Close();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            int i = 1;
            //frm_Psych_Evaluation.LabID.Clear();
            //frm_Psych_Evaluation.LabID.Text = ClassSql.Generate_ResultID("SELECT t_psychology.cn FROM t_psychology ORDER BY t_psychology.cn DESC limit 1", "cn", "PSYCHO00");

            papin = ClassSql.CreateID();
            backgroundWorker1.ReportProgress(i, papin);
            i++;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();

            }
        }
     


    }
}
