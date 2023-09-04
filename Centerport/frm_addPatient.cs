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
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace MedicalManagement
{
    public partial class frm_addPatient : Form
    {
        //private int Papin = 0; 
        private bool bl;
        public static PictureBox img;
        public frm_addPatient()
        {
            InitializeComponent();
            //img = pic_; img.AllowDrop = true;
        }

        private void cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        bool isclose = false;
        private void cmd_save_cancel_Click(object sender, EventArgs e)
        {
            if (txt_lastname.Text == "" || txt_fname.Text == "" || txt_mname.Text == "" || dt_bdate.Text == "00/00/0000")
            {
                MessageBox.Show("Please fill required information. \nLast name \nFirst name \nMiddle name \nBirth date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                isclose = true;

            }



        }






        void RegisterPatient()
        {

            try
            {

                string purpose = "";

                foreach (CheckBox cb in flowLayoutPanel3.Controls.OfType<CheckBox>())
                {
                    if (cb.Checked)
                    {
                        purpose +=  ", "+cb.Text;
                    }
                }


                foreach (CheckBox cb in flowLayoutPanel4.Controls.OfType<CheckBox>())
                {
                    if (cb.Checked)
                    {
                        purpose += ", " + cb.Text;
                    }
                }





                string uid = Guid.NewGuid().ToString();

                if (cmd_save.Text == "&Save")
                {
                    if ( txt_lastname.Text == "" || txt_fname.Text == "" || txt_mname.Text == "")
                    {
                        MessageBox.Show("Please fill required information. \nLast name \nFirst name \nMiddle name \nBirth date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else
                    {
                        string g = "";
                        if (rbMale.Checked)
                        {
                            g = "Male";
                        }
                        else if (rbFemale.Checked)
                        {
                            g = "Female";
                        }

                        DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                  

                        var r = db.sp_RegisterNewPatient(uid, txt_lastname.Text, txt_fname.Text, txt_mname.Text, "", "", "", "-", "", "-", "", "", g, dt_bdate.Text, "", "", txtCompany.Text, "", "", DateTime.Now.ToShortDateString(), "", "", "", "0", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "00000000", "00000000", "-", "-", "-", "-", DateTime.Now.ToString(), "", "", "").FirstOrDefault();

                        if (r == null)
                        {
                            //db.ExecuteCommand("INSERT INTO t_registration (trkid, papin, pxtype, trans_date, diagnosis,purpose) values ({0},{1},{2},{3},{4},{5})", "", uid, "", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"), "", purpose);

                           var v =  db.sp_InsertVisit("", uid, "", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"), "", purpose).FirstOrDefault();
                            if (v != null)
                            {

                                MessageBox.Show(this, string.Format("Duplicate Entry", "Error"), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                                return;
                            }
                            else
                            {
                                if ((Application.OpenForms["frm_visit"] as frm_visit) != null)
                                {


                                    (Application.OpenForms["frm_visit"] as frm_visit).backgroundWorker1.RunWorkerAsync();
                                }

                                //Tool.MessageBoxSave();
                                dt_bdate.Value = DateTime.Now;
                                Tool.ClearFields(flowLayoutPanel2);
                                Tool.ClearFields(panel1);
                                Tool.ClearFields(flowLayoutPanel1);
                                Tool.ClearFields(flowLayoutPanel3);
                                Tool.ClearFields(flowLayoutPanel4);
                                Tool.ClearFields(panel2);
                                this.Close();
                                if ((Application.OpenForms["frm_search_Patient_Queuing"] as frm_search_Patient_Queuing) != null)
                                {


                                    (Application.OpenForms["frm_search_Patient_Queuing"] as frm_search_Patient_Queuing).Close();
                                }
                            }


                           
                        }
                        else
                        {
                            MessageBox.Show(this, string.Format("Patient Already Exist","Error"), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }

                       



                        //img.Image = Properties.Resources.AnonymousPic;
                    }

                }

                //Update code here/////////////

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }




        }


        private void cmd_save_Click(object sender, EventArgs e)
        {


            backgroundWorker1.RunWorkerAsync();
            isclose = false;
        }

        private void frm_addPatient_Load(object sender, EventArgs e)
        {
            //ClassSql.DbConnect();
            //txt_papin.Text = ClassSql.CreateID();

            //load();
            //load_Employer();
            Cursor.Current = Cursors.Default;
        }

        //void load_Employer()
        //{
            //string[] lineOfContents = File.ReadAllLines(ClassSql.EmployerPath);
            //foreach (var line in lineOfContents)
            //{
            //    string[] tokens = line.Split(',');
            //    this.cbo_employer.Items.Add(tokens[0]);
            //    cbo_employer.AutoCompleteCustomSource.Add(tokens[0]);
            //}


            //DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            //var list = db.sp_GetEmployer().ToList();
            //foreach (var i in list)
            //{
            //    cbo_employer.Items.Add(i.Employer);
            //}
        //}




        private void txt_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txt_mname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            frm_camera cam = new frm_camera();

            cam.ShowDialog();
        }

        //private void pic__DragDrop(object sender, DragEventArgs e)
        //{
        //    try
        //    {
        //        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //        foreach (string file in files) //Console.WriteLine(file);
        //        {
        //            // this.Text = file.ToString();
        //            img.Image = Image.FromFile(file.ToString());
        //        }
        //    }
        //    catch
        //    { }

        //}

        //private void pic__DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Move;
        //}

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{


        //}





        //private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    try
        //    {
        //        pic_.Image.Dispose();
        //        pic_.Image = null;
        //    }
        //    catch
        //    {

        //    }
        //}

        //private void cmd_add_Employer_Click(object sender, EventArgs e)
        //{
        //    ClassSql a = new ClassSql();
        //    if (a.CountColumn("Select * from tbl_employer where Employer = '" + Tool.ReplaceString(cbo_employer.Text) + "'") >= 1)
        //    {
        //        MessageBox.Show("Employer name already exist", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return;
        //    }
        //    else
        //    {
        //        a.ExecuteQuery("Insert into tbl_employer (Employer) values('" + Tool.ReplaceString(cbo_employer.Text) + "')");
        //        MessageBox.Show("Employer name added", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}

        private void frm_addPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            this.Invoke(new MethodInvoker(delegate () {
                RegisterPatient(); 
            }));
   


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((Application.OpenForms["frm_visit"] as frm_visit) != null)
            {
                //(Application.OpenForms["frm_visit"] as frm_visit).Visit_Add_model.Clear();
                //if (!(Application.OpenForms["frm_visit"] as frm_visit).backgroundWorker1.IsBusy)
                //{
                //    (Application.OpenForms["frm_visit"] as frm_visit).backgroundWorker1.RunWorkerAsync();
                //}

                (Application.OpenForms["frm_visit"] as frm_visit).loadlist();
                (Application.OpenForms["frm_visit"] as frm_visit).dt_from.Enabled = false;
                if (isclose) { this.Close(); }
            }

        }


        private void dt_bdate_ValueChanged(object sender, EventArgs e)
        {

            DateTime CurrentDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            int Age = CurrentDate.Year - dt_bdate.Value.Year;
            if (CurrentDate.Month < dt_bdate.Value.Month)
            {
                Age--;
            }
            else if ((CurrentDate.Month == dt_bdate.Value.Month) && (CurrentDate.Day < dt_bdate.Value.Day))
            {

                Age--;
            }
            //this.txt_age.Text = Age.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
