using Ini;
using MedicalManagement.Class;
using MedicalManagement.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_xray : Form, MyInter
    {
        Main fmain; public static bool NewXray;
        public static string radcn;
        public string Papin;
        public string findings_default;
        public string impression_default;
        DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
        public List<QueueSearchList_Model> xrayAdd_model = new List<QueueSearchList_Model>();
        public List<Xray_Model> Xray_model = new List<Xray_Model>();

        private string Address, Contact, Address2;
        public frm_xray(Main mainn)
        {
            InitializeComponent();
            //pin = txt_Papin; LabID = txt_resultID;
            fmain = mainn;
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void New()
        {




        }
        public void Save()
        {

            SaveRecord();



        }



        void SaveRecord()
        {
            try
            {


                txt_name.Focus();

                int norma_xray;
                if (cb_normal.Checked)
                {
                    norma_xray = 1;
                }
                else
                {
                    norma_xray = 0;
                }

                string DateResult = "";
                if (dt_result_Date.Text == "00/00/0000")
                {
                    DateResult = DateTime.Today.ToShortDateString();
                }
                else
                {
                    DateResult = dt_result_Date.Text;
                }

                int t = 0;
                if (variables.RadiologyFormType.Equals("XRAY"))
                {
                    t = 1;
                }
                else if (variables.RadiologyFormType.Equals("ECG"))
                {
                    t = 2;
                }
                else if (variables.RadiologyFormType.Equals("UTZ"))
                {
                    t = 3;
                }

                db.sp_XrayProcess(Papin, txt_xrayNo.Text, txt_findings.Text, "-", "-", txtExamination.Text, txt_impression.Text, norma_xray.ToString(), t.ToString(), dt_result_Date.Text);
                xrayAdd_model.Clear();





                Availability(false);
                fmain.ts_printPreview_Xray.Enabled = true; fmain.ts_edit_xray.Enabled = true; fmain.ts_save_xray.Enabled = false; fmain.ts_cancel_xray.Enabled = false; fmain.ts_search_xray.Enabled = true; fmain.ts_print_xray.Enabled = true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }




        public void Edit()
        {
            if (fmain.UserLevel == 1 || fmain.UserLevel == 2 || fmain.UserLevel == 7 || fmain.UserLevel == 6)
            {
                NewXray = false;
                Availability(true);
                fmain.ts_edit_xray.Enabled = false; 
                fmain.ts_save_xray.Enabled = true;
                fmain.ts_cancel_xray.Enabled = true; 
                fmain.ts_search_xray.Enabled = false; 
                fmain.ts_print_xray.Enabled = false; 
                fmain.ts_printPreview_Xray.Enabled = false;

            }
            else
            {
                if (MessageBox.Show("You do not have enough access privileges for this operation, Please use RELEASING account. \n Would you like to continue?", "Action Denied!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    new frm_login(fmain).ShowDialog();
                }

            }
        }
        public void Delete()
        {
            Delete_Record();
        }


        public void Cancel()
        {

            Availability(false);

            fmain.ts_edit_xray.Enabled = true;
            fmain.ts_save_xray.Enabled = false;
            fmain.ts_search_xray.Enabled = true;
            fmain.ts_print_xray.Enabled = true;
            fmain.ts_printPreview_Xray.Enabled = false;
            fmain.ts_cancel_xray.Enabled = false;




        }
        public void Print()
        {
          

            //Reporting.Write("RadiologyTEMPLATE",
            //    new string[] { 
            //        "F11",
            //        "A15",
            //        "B11",
            //        "F10", 
            //        "B12",
            //        "F12",
            //        "B10",                  
            //        "B17", 
            //        "B24", },
            //    new string[] { 
            //        txt_agency.Text,
            //        title + " REPORT",
            //        txt_name.Text,
            //        dt_result_Date.Text,
            //        txt_AgeSex.Text,
            //        txtExamination.Text ,
            //        txt_xrayNo.Text, 
            //        txt_findings.Text, 
            //        txt_impression.Text });


            FrmRadiographicalReport r = new FrmRadiographicalReport();
            r.radiographicalModel = prepareTheFrmRadiographicalReportDate();
            r.ShowDialog();



        }

        private RadiographicalModel prepareTheFrmRadiographicalReportDate()
        {

            string title = "";
            if (variables.RadiologyFormType == "UTZ")
            {
                title = "ULTRASOUND";
            }
            else
            {
                title = variables.RadiologyFormType;
            }




            RadiographicalModel radiographicalModel = new RadiographicalModel();


            radiographicalModel.Name = txt_name.Text;
            radiographicalModel.Company = txt_agency.Text;
            radiographicalModel.HeaderAddress = Address;
            radiographicalModel.Date = dt_result_Date.Text;
            radiographicalModel.AgeSex = txt_AgeSex.Text;
            radiographicalModel.HeaderContact = Contact;
            radiographicalModel.result1 = txt_findings.Text;
            radiographicalModel.result3 = txt_impression.Text;
            radiographicalModel.CaseNo = txt_xrayNo.Text;
            radiographicalModel.Examination = txtExamination.Text;
            radiographicalModel.ReportTitle = title + " REPORT";
            radiographicalModel.Address2 = Address2;

            return radiographicalModel;
        }
        public void Search()
        {



        }

        private void frm_xray_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fmain.ts_cancel_xray.Enabled == true)
                {
                    Cancel();


                }
                else
                { this.Close(); }

            }
            else if (e.KeyCode == Keys.Add && e.Modifiers == Keys.Control)
            {

            }

            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_save_xray.Enabled == true)
                {
                    Save();

                }

            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_print_xray.Enabled == true)
                {
                    Print();
                }
            }
            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {

                if (fmain.ts_search_xray.Enabled == true)
                {
                    fmain.search_xray();
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (fmain.ts_edit_xray.Enabled == true)
                {
                    Edit();

                }
            }
            else if (e.KeyCode == Keys.Delete)
            {


            }
        }

        private void overlayShadow1_Click(object sender, EventArgs e)
        {
            //if (LabID.Text == "")
            //{
            //    MessageBox.Show("Please  select patient  first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            //    //MessageBox.Show("Please click EDIT BUTTON or press f4 key in your keyboard to modify!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}



        }


        private void frm_xray_Load(object sender, EventArgs e)
        {
            //ClassSql.DbConnect();
            Cursor.Current = Cursors.Default;
            Availability(false);
            groupBox2.Text = variables.RadiologyFormType + " RESULT";
            //Load_Medical();


            IniFile ini = new IniFile(ClassSql.MMS_Path);
            Address = ini.IniReadValue("COMPANY", "Address");
                 Address2 = ini.IniReadValue("COMPANY", "Address2");
            Contact = ini.IniReadValue("COMPANY", "Contact");


            Availability(false);

        }

        private void frm_xray_FormClosing(object sender, FormClosingEventArgs e)
        {
            fmain.Xray = true;
            fmain.ts_printPreview_Xray.Enabled = false; fmain.ts_edit_xray.Enabled = false; fmain.ts_save_xray.Enabled = false; fmain.ts_search_xray.Enabled = true; fmain.ts_print_xray.Enabled = false; fmain.ts_cancel_xray.Enabled = false;
            //ClassSql.DbClose();
            // fmain.Strip_sub.Visible = false;
        }

        private void txt_resultID_TextChanged(object sender, EventArgs e)
        {




        }



        public void search_Xray(string t)
        {

            try
            {



                var i = db.sp_Xray_Detail(Papin, t).FirstOrDefault();
                if (i != null)
                {


                    lbl_Xray_Result_Cn.Tag = i.cn.ToString() ?? "-";
                    txt_xrayNo.Text = i.reference_no.ToString() ?? "-";
                    txt_findings.Text = i.findings.ToString() ?? "-";
                    txt_impression.Text = i.impression.ToString() ?? "-";
                    txtExamination.Text = i.examination.ToString() ?? "-";


                    int remark = Convert.ToInt32(i.remark ?? 0);
                    if (remark == 1)
                    {
                        cb_normal.Checked = true;
                    }
                    else
                    {
                        cb_normal.Checked = false;
                    }


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }




        public void Search_Patient()
        {
            try
            {

                var i = db.sp_Xray_Patient(Papin).FirstOrDefault();
                this.txt_name.Text = i.PatientName ?? "-";
                DateTime temp1;
                DateTime dt_Bday = new DateTime();
                if (DateTime.TryParse(i.birthdate.ToString() ?? "-", out temp1))
                    //{
                    //    dt_bday.Format = DateTimePickerFormat.Custom;
                    //    dt_bday.CustomFormat = "MM/dd/yyyy";

                    dt_Bday = Convert.ToDateTime(i.birthdate.ToString() ?? "-").Date;
                //}
                //else
                //{

                //    dt_bday.Format = DateTimePickerFormat.Custom;
                //    dt_bday.CustomFormat = "00/00/0000";

                //}


                this.txt_AgeSex.Text = Tool.ComputeAge(dt_Bday).ToString() + "/" + i.gender.ToString() ?? "-";
                this.txt_agency.Text = i.employer.ToString() ?? "-";

                //txt_position.Text = i.position.ToString() ?? "-";



            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }



        }


        void Delete_Record()
        {


        }



        public void Availability(bool bl)
        {

            int newWidth = this.Width;
            int newHieght = this.Height;

            overlayShadow1.MaximumSize = new Size(newWidth, newHieght);
            overlayShadow1.Size = new Size(newWidth, overlayShadow1.Height);



            if (bl == true)
            { 
                overlayShadow1.Visible = false; 
                overlayShadow1.SendToBack(); 
            }
            else
            {   overlayShadow1.Visible = true; 
                overlayShadow1.BringToFront(); 
            }

        }

        public void ClearAll()
        {
            Tool.ClearFields(panel3);
            Tool.ClearFields(groupBox2);
            Tool.ClearFields(groupBox3);
            setDeafultValue();



        }

        public void setDeafultValue()
        {
            if (variables.RadiologyFormType == "XRAY")
            {
                string xrayResultDefaultValue = "Both lung fields are clear, Heart is not enlarged, Rest of the chest findings are normal";
                string xrayRemarksDefaultValue = "Normal Chest";
                txt_findings.Text = xrayResultDefaultValue;
                txt_impression.Text = xrayRemarksDefaultValue;
            }
        }






        private void txt_Papin_TextChanged(object sender, EventArgs e)
        {

            //if (NewXray)
            //{
            //    ClassSql a = new ClassSql(); long cnt;
            //    cnt = a.CountColumn("SELECT Count(t_result_main.papin) AS `count` FROM t_result_main WHERE t_result_main.papin =  '" + Tool.ReplaceString(txt_Papin.Text) + "' and resulttype = 'UTZ'");

            //    if (cnt >= 1)
            //    {

            //        if (MessageBox.Show("Patient had previous laboratory examination! Would you like to update Hir/Her record?", Properties.Settings.Default.Systemname.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            NewXray = false;
            //            search_Medical_sub();
            //            Search_Patient();
            //            search_Xray();                 
            //            Availability(true);

            //        }
            //        else
            //        {

            //            NewXray = true;
            //            Search_Patient();
            //            Availability(true);
            //            ClearAll();


            //        }

            //    }
            //    else
            //    {

            //        NewXray = true;
            //        Search_Patient();
            //        Availability(true);
            //        ClearAll();

            //    }


            //}
            //else
            //{

            //    Search_Patient();

            //}

            //txt_Papin.Select();
            //Load_Medical();

        }

        private void txt_bday_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_medTect_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pathologist_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_radiologist_TextChanged(object sender, EventArgs e)
        {

            //ClassSql a = new ClassSql();
            //a.PutDataTOTextBox("SELECT tbl_medical.cn, tbl_medical.Name, tbl_medical.License, tbl_medical.Type FROM tbl_medical WHERE tbl_medical.Name LIKE  '%" + txt_radiologist.Text + "%'", txt_rad_license, "License");

        }


        private void dt_result_Date_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }




        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {


                var list = db.sp_Xray_SearchList("%", variables.RadiologyFormType);
                Cursor.Current = Cursors.WaitCursor;
                foreach (var i in list)
                {

                    Xray_model.Add(new Xray_Model
                    {
                        cn = i.cn,
                        papin = i.papin,
                        resultID = i.resultid,
                        patientName = i.PatientName,
                        resultDate = i.result_date
                    });

                }
                // sw.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{

            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }

            //}
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {


                var list = db.sp_XrayAdd("%");

                foreach (var i in list)
                {

                    xrayAdd_model.Add(new QueueSearchList_Model
                    {
                        cn = i.cn,
                        papin = i.papin,
                        PatientName = i.PatientName,
                        gender = i.gender

                    });
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //try
            //{

            //    if (!backgroundWorker2.IsBusy)
            //    { backgroundWorker2.RunWorkerAsync(); }
            //    if ((Application.OpenForms["frm_search_xray"] as frm_search_xray) != null)
            //    { (Application.OpenForms["frm_search_xray"] as frm_search_xray).FillDataGridView(); }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            //}



            //(Application.OpenForms["frm_search_xray"] as frm_search_xray).lbl_notification.Visible = false;

        }

        private void frm_xray_Enter(object sender, EventArgs e)
        {
            //xrayAdd_model.Clear();
            //Xray_model.Clear();
            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TemplatePath.basePath);
        }

        //



    }
}
