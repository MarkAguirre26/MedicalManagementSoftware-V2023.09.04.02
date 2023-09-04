using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_lab : Form, MyInter
    {
        Main fmain; public static bool newlab; public static TextBox Patient_pin; public static TextBox LabId;
        private string FBS_; private string Bun_; private string Creatinine_; private string Cholesterol_; private string trigly_; private string uric_; private string sgot_; private string sgpt_; private string alk_;


        public List<laboratory_search> labsearch = new List<laboratory_search>();
        public List<QueueSearchList_Model> QueueSearchList_Model = new List<QueueSearchList_Model>();
        public frm_lab(Main mainn)
        {
            InitializeComponent();

            Patient_pin = txt_papin; LabId = txt_resultId;
            fmain = mainn;

        }



        public void New()
        {
            cb_hema.Checked = true;
            cb_remark_urinalysis.Checked = true;
            cb_fecalysis.Checked = true;

        }
        public void Save()
        {

            if (newlab)
            {
                insert();

            }
            else
            {

                Update_Medical();




            }



        }
        public void Edit()
        {

            if (fmain.UserLevel == 1 || fmain.UserLevel == 2 || fmain.UserLevel == 3)
            {
                newlab = false;
                Availability(true);
                fmain.ts_add_lab.Enabled = false; fmain.ts_edit_lab.Enabled = false; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = true; fmain.ts_cancel_lab.Enabled = true; fmain.ts_search_lab.Enabled = false; fmain.ts_print_lab.Enabled = false;


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

            //Delete_Record();

            //try
            //{
            //    if (id_ != null)
            //    {

            //        if (MessageBox.Show("Are you sure you want to delete Patient with Papin no.:" + txt_papin.Text, Properties.Settings.Default.Systemname.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            ClassSql a = new ClassSql();
            //            a.ExecuteQuery("Delete from m_patient where cn = '" + id_.Text + "'");
            //            id_.Clear();
            //            Tool.MessageBoxDelete();

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.Systemname.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            //}
            //finally
            //{
            //    if (ClassSql.cnn != null) {// }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}



        }
        public void Cancel()
        {


            if (newlab)
            {
                txt_papin.Select();
                txt_papin.Clear();

                //dt_resultdate.Enabled = false;
                //labNo.Enabled = false;
                //MedTech.Enabled = false;
                //Pathologist.Enabled = false;
                //med_licenseNo.Enabled = false;
                //Pathologist_licenseNo.Enabled = false;
                txt_papin.Clear();
                ClearAll();
                Availability(false);


                fmain.ts_add_lab.Enabled = true; fmain.ts_edit_lab.Enabled = false; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = false; fmain.ts_search_lab.Enabled = true; fmain.ts_print_lab.Enabled = false; fmain.ts_cancel_lab.Enabled = false;
            }
            else
            {
                txt_papin.Select();
                //dt_resultdate.Enabled = false;
                //labNo.Enabled = false;
                //MedTech.Enabled = false;
                //Pathologist.Enabled = false;
                //med_licenseNo.Enabled = false;
                //Pathologist_licenseNo.Enabled = false;        

                Availability(false);
                ClearAll();

                Search_Patient(); Search_Hema(); Search_Urinalysis(); Search_Fecalysis();


                fmain.ts_add_lab.Enabled = true; fmain.ts_edit_lab.Enabled = true; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = false; fmain.ts_search_lab.Enabled = true; fmain.ts_print_lab.Enabled = true; fmain.ts_cancel_lab.Enabled = false;
            }

        }
        public void Print()
        {

            Tool.printMessage();

            //using (frm_LabPrintChoices f = new frm_LabPrintChoices())
            //{
            //    f.ShowImage = "0";
            //    f.Age = txt_age.Text;
            //    f.resultid = LabId.Text;
            //    f.PatientName = name.Text;
            //    f.Sex = gender.Text;
            //    f.Address = address.Text;
            //    f.CivilStatus = civil_stat.Text;
            //    f.Age = txt_age.Text;
            //    f.Position = position.Text;
            //    f.resultdateHema = Hema_RelustDate.Text;
            //    f.ReferredBy = "";
            //    f.Hemoglobin_ = hemoglobin.Text;
            //    f.Hematocrit_ = hematocrit.Text;
            //    f.RBCcount_ = RBC.Text;
            //    f.WBC_ = WBC.Text;
            //    f.SpecimenNo = labNo.Text;
            //    f.Platelet_ = Platelet.Text;
            //    f.BloodType_ = BloodType.Text;
            //    f.Lymphocyte_ = Lympho.Text;
            //    f.Segmenters_ = Segmenters.Text;
            //    f.easinophils_ = Easinophils.Text;
            //    f.Monoytes_ = MonoCytes.Text;
            //    f.myelocytes_ = Myelocytes.Text;
            //    f.Juveniles_ = Juveniles.Text;
            //    f.stabCells_ = StabCells.Text;
            //    f.Basophils_ = BasoPhils.Text;
            //    f.Others_HEma = Hema_Other.Text;    
            //    f.Pathologist = Pathologist.Text;
            //    f.Pathologist_Lic = Pathologist_licenseNo.Text;

            //    f.Employer = agency.Text;
            //    f.esr = ESR.Text;
            //    f.rpr_ = cbo_rpr.Text;
            //    f.BsAG = cbo_hb.Text;
            //    f.WIDALTEST = cbo_widal.Text;
            //    f.MALARIAL = cbo_malaroial.Text;
            //    f.ResultDate_lab06 = dt_resultdate.Text;
            //    f.ResultDate_Fecal = dt_resultDate_Fecalysis.Text;             
            //    f.Color_fecal = cbo_color_fecal.Text;
            //    f.WHITeBLOODCELLS = tx_whitBlood_fecal.Text;
            //    f.Mucus = "";
            //    f.OVAORPARASITE = tx_ova.Text;
            //    f.AMOEBA = tx_amoeba.Text;
            //    f.OCCULTBLOODTEST = tx_occultBloodTest.Text;
            //    f.other_fecal = txt_other_Fecalysis.Text;
            //    f.Medtech = MedTech.Text;
            //    f.MedTech_lic = med_licenseNo.Text;
            //    f.Pathologist = Pathologist.Text;
            //    f.Pathologist_Lic = Pathologist_licenseNo.Text;
            //    f.SpecimenNo = labNo.Text;
            //    f.RedBlood = tx_red_fecal.Text;
            //    f.color_Others_fecal = txt_color_other_fecal.Text;
            //    f.CONSISTENCY = cbo_consistency.Text;



            //    f.resultdate_Urinalysis = dt_Result_urinal.Text;
            //    f.COLOR_Urnialysis = cbo_color.Text.Replace("[n/a]", "").Replace("N/A", "");
            //    f.Transparency = cbo_transparency.Text;
            //    f.Leucocytes = cbo_leu.Text;
            //    f.Nitrite = cbo_nitrite.Text;
            //    f.Urobilinogen = cbo_uro.Text;
            //    f.Protein = cbo_protein.Text;
            //    f.pH = cbo_ph.Text;
            //    f.Blood = cbo_blood.Text;
            //    f.SpecificGravity = cbo_spec.Text;
            //    f.Ketone = cbo_keton.Text;
            //    f.Bilirubin = cbo_bili.Text;
            //    f.Glucose = cbo_glucose.Text;
            //    f.other_chem = txt_other_chem.Text;
            //    f.RedBloodCells_Urinalysis = txt_redBlood.Text;
            //    f.WhiteBloodCells_Urinalysis = tx_whiteBlood.Text;
            //    f.Amorphous_Urates = tx_urates.Text;
            //    f.Phosphate = tx_phosphate.Text;
            //    f.EpithelialCells = tx_cells.Text;
            //    f.MucusThread = tx_musus.Text;
            //    f.others_Microscopic = tx_other_micro.Text;
            //    f.UricAcid_Urinalysis = tx_uric_crystal.Text;
            //    f.CalciumOxalate = tx_caium.Text;
            //    f.Others_Crystal = tx_other_Crystals.Text;
            //    f.FineGranularCast = tx_Granular.Text;
            //    f.CoarseGranularCast = tx_coarse.Text;
            //    f.Others_Cast = tx_other_cast.Text;
            //    f.Color_remark = tx_color_other.Text;






            //    f.resultdate_Chem = dt_Chemistry.Text;

            //    f.FBS_ = tx_FBS.Text;
            //    f.BUN_ = txt_Bun.Text;
            //    f.CREATINE_ = tx_Creatinine.Text;
            //    f.CHOLESTEROL_ = tx_Cholesterol.Text;
            //    f.TRIGLYCERIDES_ = tx_trigly.Text;
            //    f.URICACID_ = tx_uric.Text;
            //    f.SGOT_ = tx_sgot.Text;
            //    f.SGPT_ = tx_sgpt.Text;
            //    f.ALKPHOS_ = tx_alk.Text;
            //    //f.Medtech = MedTech.Text;
            //    //f.MedTech_lic = med_licenseNo.Text;
            //    //f.Pathologist = Pathologist.Text;
            //    //f.Pathologist_Lic = Pathologist_licenseNo.Text;
            //    //f.SpecimenNo = labNo.Text;
            //    if (cb_FBS.Checked) { f.FBS_H = "1"; } else { f.FBS_H = "0"; }
            //    if (cb_Bun.Checked) { f.BUN_H = "1"; } else { f.BUN_H = "0"; }
            //    if (cb_Creatinine.Checked) { f.CREATINE_H = "1"; } else { f.CREATINE_H = "0"; }
            //    if (cb_Cholesterol.Checked) { f.CHOLESTEROL_H = "1"; } else { f.CHOLESTEROL_H = "0"; }
            //    if (cb_trigly.Checked) { f.TRIGLYCERIDES_H = "1"; } else { f.TRIGLYCERIDES_H = "0"; }
            //    if (cb_uric.Checked) { f.URICACID_H = "1"; } else { f.URICACID_H = "0"; }
            //    if (cb_sgot.Checked) { f.SGOT_H = "1"; } else { f.SGOT_H = "0"; }
            //    if (cb_sgpt.Checked) { f.SGPT_H = "1"; } else { f.SGPT_H = "0"; }
            //    if (cb_alk.Checked) { f.ALKPHOS_H = "1"; } else { f.ALKPHOS_H = "0"; }
            //    f.FBS_CON_ = tx_fbs_Conventional.Text;
            //    f.BUN_CON_ = tx_bun_convetional.Text;
            //    f.CREATINE_CON_ = tx_creatinine_convetional.Text;
            //    f.CHOLESTEROL_CON_ = tx_choles_conventional.Text;
            //    f.TRIGLYCERIDES_CON_ = tx_trygly_convetion.Text;
            //    f.URICACID_CON_ = tx_uric_Conventional.Text;
            //    f.SGOT_CON_ = tx_sgot_conventional.Text;
            //    f.SGPT_CON_ = tx_sgpt_conventional.Text;
            //    f.ALKPHOS_CON_ = tx_alk_conventional.Text;
            //    f.remark_chem = "";
            //    f.ShowDialog();
            //}

        }
        public void Search()
        {



        }



        public void Add_Record()
        {
            //   newlab = true;
            //LoadMedtech();
            //LoadPathologist();

            Availability(true);
            //labNo.Enabled = true;
            //MedTech.Enabled = true;
            //Pathologist.Enabled = true;
            //med_licenseNo.Enabled = true;
            //Pathologist_licenseNo.Enabled = true;
            //ClearAll();

        }



        //void LoadMedtech()
        //{

        //    try
        //    {
        //        ClassSql a = new ClassSql(); DataTable dt;
        //        dt = a.Table("SELECT tbl_medical.cn, tbl_medical.Name, tbl_medical.License, tbl_medical.Type FROM tbl_medical WHERE tbl_medical.Type =  'MedTech'");
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            MedTech.Text = dr["Name"].ToString();
        //            med_licenseNo.Text = dr["License"].ToString();

        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //    }
        //    finally
        //    {
        //        //if (ClassSql.cnn != null) {// }
        //        if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //    }

        //}


        //void LoadPathologist()
        //{

        //    try
        //    {
        //        ClassSql a = new ClassSql(); DataTable dt;
        //        dt = a.Table("SELECT tbl_medical.cn, tbl_medical.Name, tbl_medical.License, tbl_medical.Type FROM tbl_medical WHERE tbl_medical.Type =  'Pathologist'");
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            this.Pathologist.Text = dr["Name"].ToString();
        //            this.Pathologist_licenseNo.Text = dr["License"].ToString();

        //        }




        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //    }
        //    finally
        //    {
        //        //if (ClassSql.cnn != null) {// }
        //        if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //    }

        //}




        private void frm_lab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fmain.ts_cancel_lab.Enabled == true)
                { Cancel(); }
                else
                { this.Close(); }

            }
            else if (e.KeyCode == Keys.Add && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_add_lab.Enabled == true)
                {

                    New();
                }
            }
            //
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_save_lab.Enabled == true)
                {
                    Save();

                }

            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_print_lab.Enabled == true)
                {
                    Print();
                }
            }
            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {

                if (fmain.ts_search_lab.Enabled == true)
                {
                    fmain.Search_Lab("LAB");
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (fmain.ts_edit_lab.Enabled == true)
                {
                    Edit();

                }
            }

        }

        private void frm_lab_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  fmain.Strip_sub.Visible = false;
            //
            fmain.laboratory = true;
            fmain.ts_add_lab.Enabled = true; fmain.ts_edit_lab.Enabled = false; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = false; fmain.ts_search_lab.Enabled = true; fmain.ts_print_lab.Enabled = false; fmain.ts_cancel_lab.Enabled = false;

        }

        private void frm_lab_Load(object sender, EventArgs e)
        {


            //ClassSql.DbConnect();
            //  load_Hema_NormalValues();
            // load_NormalCHEM();


            Availability(false);
            Cursor.Current = Cursors.Default;
            txt_papin.Select();

            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync();
            //}



        }






        public void Availability(bool bl)
        {

            if (bl == true)
            {
                overlayShadow1.Visible = false;
                overlayShadow1.SendToBack();
            }
            else
            {
                overlayShadow1.Visible = true;
                overlayShadow1.BringToFront();


            }
        }

        public void ClearAll()
        {

            Tool.ClearFields(groupBox1);
            Tool.ClearFields(tabPage1);

            Tool.ClearFields(tabPage2);

            Tool.ClearFields(tabPage3);
            Tool.ClearFields(panel4);
        }




        void ClearAll_()
        {

            Tool.ClearFields(tabPage1);
            Tool.ClearFields(tabPage2);
            Tool.ClearFields(tabPage3);


        }
        private void txt_papin_TextChanged(object sender, EventArgs e)
        {
            //if (newlab)
            //{
            //    ClassSql a = new ClassSql(); int cnt;
            //    cnt = a.CountColumn("SELECT Count(t_result_main.papin) AS `count` FROM t_result_main WHERE t_result_main.papin =  '" + Tool.ReplaceString(txt_papin.Text) + "' and resulttype = 'LAB'");
            //      if (cnt >= 1)
            //      {

            //          if (MessageBox.Show("Patient had previous laboratory examination! Would you like to update Hir/Her record?", Properties.Settings.Default.Systemname.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //          {
            //              newlab = false;
            //              Search_Patient();                        
            //              Availability(true);
            //              dt_resultdate.Enabled = true;
            //              labNo.Enabled = true;
            //              MedTech.Enabled = true;
            //              Pathologist.Enabled = true;
            //              med_licenseNo.Enabled = true;
            //              Pathologist_licenseNo.Enabled = true;
            //          }
            //          else
            //          {
            //              newlab = true;
            //              Search_Patient();
            //              //Search_lab();
            //              Add_Record();
            //              ClearAll_();
            //          }

            //      }
            //      else
            ////      {
            ////          newlab = true;
            ////          Search_Patient();
            ////          //Search_lab();
            ////          Add_Record();
            ////          dt_resultdate.Enabled = true;
            ////          labNo.Enabled = true;
            ////          MedTech.Enabled = true;
            ////          Pathologist.Enabled = true;
            ////          med_licenseNo.Enabled = true;
            ////          Pathologist_licenseNo.Enabled = true;

            ////          ClearAll_();



            ////      }


            ////}
            ////else
            ////{
            ////    Search_Patient();

            ////}
            ////txt_papin.Select();
            ////Medical_personnel();

        }

        public void Lab_Details()
        {
            try
            {

                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var i = db.sp_getLabResultMain(txt_resultId.Text).FirstOrDefault();
                if (i != null)
                {

                    txt_resultdate.Text = i.result_date.ToString();
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

                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var i = db.lab_patient(Patient_pin.Text).FirstOrDefault();


                name.Text = i.latname.ToString() + ", " + i.firstname.ToString() + " " + i.middlename.ToString();
                agency.Text = i.employer.ToString() ?? "-";
                position.Text = i.position.ToString() ?? "-";

                address.Text = i.address_1.ToString() ?? "-";
                civil_stat.Text = i.marital_status.ToString() ?? "-";
                DateTime temp;
                if (DateTime.TryParse(i.birthdate.ToString() ?? "-", out temp))
                {
                    dt_bady.Format = DateTimePickerFormat.Custom;
                    dt_bady.CustomFormat = "MM/dd/yyyy";
                    dt_bady.Value = Convert.ToDateTime(i.birthdate.ToString() ?? "-").Date;
                }
                else
                {
                    dt_bady.Format = DateTimePickerFormat.Custom;
                    dt_bady.CustomFormat = "00/00/0000";


                }

                txt_age.Text = Tool.ComputeAge(dt_bady.Value).ToString();

                gender.Text = i.gender.ToString() ?? "-";

                //}





            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }



        }

        //void load_Hema_NormalValues()
        //{


        //    IniFile ini = new IniFile(ClassSql.MMS_Path);
        //    hema_normal.Text = ini.IniReadValue("NormalValue", "hemoglobin") + "gm/dl";
        //    hematocrit_normal.Text = ini.IniReadValue("NormalValue", "hematocrit") + "vol%";
        //    rbc_normal.Text = ini.IniReadValue("NormalValue", "RBC") + " m/cumm";
        //    wbc_normal.Text = ini.IniReadValue("NormalValue", "WBC") + " /cumm";
        //    platelet_normal.Text = ini.IniReadValue("NormalValue", "Platelet") + "/cumm";
        //    label32.Text = ini.IniReadValue("NormalValue", "BloodType");
        //    eos_normal.Text = ini.IniReadValue("NormalValue", "Easinophils") + "%";
        //    label15.Text = ini.IniReadValue("NormalValue", "Myelocytes");
        //    label2.Text = ini.IniReadValue("NormalValue", "Juveniles");
        //    baso_normal.Text = ini.IniReadValue("NormalValue", "BasoPhils") + "%";
        //    label30.Text = ini.IniReadValue("NormalValue", "Hema_Other");


        //}

        //void load_NormalCHEM()
        //{


        //    //IniFile ini = new IniFile(ClassSql.MMS_Path);
        //    //l_fbs.Text = ini.IniReadValue("NormalValue", "fbs") + " mmol/L";
        //    //l_bun.Text = ini.IniReadValue("NormalValue", "bun") + " mmol/L";
        //    //L_creatinine.Text = ini.IniReadValue("NormalValue", "creatine") + " mmol/L";
        //    //L_cholesterol.Text = ini.IniReadValue("NormalValue", "choles") + " mmol/L";
        //    //l_trigly.Text = ini.IniReadValue("NormalValue", "trigly") + " mmol/L";
        //    //l_UricAcid.Text = ini.IniReadValue("NormalValue", "uric") + " mmol/L";
        //    //L_Sgot.Text = ini.IniReadValue("NormalValue", "sgot") + " IU/L";
        //    //L_Sgpt.Text = ini.IniReadValue("NormalValue", "sgpt") + " IU/L";
        //    //L_alk.Text = ini.IniReadValue("NormalValue", "alk") + " IU/L";
        //    //L_fbs_con.Text = ini.IniReadValue("NormalValue", "fbs_con") + " mg/dL";
        //    //l_bun_con.Text = ini.IniReadValue("NormalValue", "bun_con") + " mg/dL";
        //    //L_creatine_Con.Text = ini.IniReadValue("NormalValue", "creatine_Con") + " mg/dL";
        //    //L_Cholesterol_Con.Text = ini.IniReadValue("NormalValue", "Cholesterol_Con") + " mg/dL";
        //    //L_Trig_Con.Text = ini.IniReadValue("NormalValue", "Trig_Con") + " mg/dL";
        //    //l_Uric_Con.Text = ini.IniReadValue("NormalValue", "Uric_Con") + " mg/dL";
        //    //label35.Text = ini.IniReadValue("NormalValue", "sgot_con");
        //    //label34.Text = ini.IniReadValue("NormalValue", "sgpt_con");
        //    //label33.Text = ini.IniReadValue("NormalValue", "alk_con");
        //    //HbA1c_SI_Normal.Text = ini.IniReadValue("NormalValue", "HBA1C_SI") + " %";
        //    //HbA1c_Con_Normal.Text = ini.IniReadValue("NormalValue", "HBA1C_CON") + " %";

        //}


        public void Search_Hema()
        {
            try
            {

                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var i = db.sp_hema_gamosa_lab(LabId.Text).FirstOrDefault();
                if (i != null)
                {


                    Hemoglobin.Text = i.Hemoglobin ?? "-";
                    Hematocrit.Text = i.Hematocrit ?? "-";
                    RBCCount.Text = i.RBCCount ?? "-";
                    WBCCount.Text = i.WBCCount ?? "-";
                    Platelet.Text = i.Platelet ?? "-";
                    Neutrophils.Text = i.Neutrophils ?? "-";
                    Lymphocytes.Text = i.Lymphocytes ?? "-";
                    Eosonophils.Text = i.Eosonophils ?? "-";
                    Monocytes.Text = i.Monocytes ?? "-";
                    Basophils.Text = i.Basophils ?? "-";
                    txt_abo.Text = i.aboTyping ?? "-";
                    txt_rh.Text = i.rh ?? "-";
                    txt_fbs.Text = i.fbs ?? "-";
                    txt_rbs.Text = i.rbs ?? "-";



                    int Normal = Convert.ToInt32(i.Normal ?? 0);
                    if (Normal == 1)
                    {
                        cb_hema.Checked = true;

                    }
                    else
                    {
                        cb_hema.Checked = false;
                    }
                    txt_finding_hema.Text = i.Findings ?? "-";

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }



        }

        public void Search_Urinalysis()
        {
            try
            {

                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var i = db.sp_urinalysis_gamosa_lab(LabId.Text).FirstOrDefault();

                if (i != null)
                {



                    Color.Text = i.Color ?? "-";
                    Transparency.Text = i.Transparency ?? "-";
                    pH.Text = i.pH ?? "-";
                    SpecificGravity.Text = i.SpecificGravity ?? "-";
                    Sugar.Text = i.Sugar ?? "-";
                    Albumin.Text = i.Albumin ?? "-";
                    Bacteria.Text = i.Bacteria ?? "-";
                    wbc.Text = i.wbc ?? "-";
                    rbc.Text = i.rbc ?? "-";
                    EpithelialCells.Text = i.EpithelialCells ?? "-";
                    MucousThreads.Text = i.MucousThreads ?? "-";
                    AmorphousUrates.Text = i.AmorphousUrates ?? "-";
                    Casts.Text = i.Casts ?? "-";
                    Crystals.Text = i.Crystals ?? "-";
                    PregnancyTest.Text = i.PregnancyTest ?? "-";
                    int Normal = Convert.ToInt32(i.Normal ?? "-");
                    if (Normal == 1)
                    {
                        cb_remark_urinalysis.Checked = true;
                    }
                    else
                    {
                        cb_remark_urinalysis.Checked = false;
                    }
                    txt_remark_urinalysis.Text = i.Findings ?? "-";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }
        public void Search_Fecalysis()
        {
            try
            {


                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var i = db.sp_fecalysis_gamosa_lab(LabId.Text).FirstOrDefault();


                if (i != null)
                {
                    string other = i.other ?? "-";

                    if (other != "")
                    {
                        txt_color_other_fecal.Text = other;
                        txt_color_other_fecal.Visible = true;
                    }
                    else
                    {

                        txt_color_other_fecal.Visible = false;
                    }

                    cbo_color_fecal.Text = i.color ?? "-";
                    cbo_consistency.Text = i.Consistency ?? "-";
                    PusCells.Text = i.PusCells ?? "-";
                    fecal_rbc.Text = i.rbc ?? "-";
                    cbo_ova.Text = i.ova ?? "-";
                    int Normal = Convert.ToInt32(i.Normal ?? 0);
                    if (Normal == 1)
                    {
                        cb_fecalysis.Checked = true;
                    }
                    else
                    {
                        cb_fecalysis.Checked = false;
                    }
                    txt_facalisys_findings.Text = i.Findings ?? "-";
                    cbo_hbsag.Text = i.hbsag ?? "-";
                    cbo_HBsA.Text = i.hbsag_Tag ?? "-";
                    cbo_hbsagB.Text = i.hbsagB ?? "-";
                    cbo_HBsB.Text = i.hbsagB_Tag ?? "-";





                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }
        private void dt_bady_ValueChanged(object sender, EventArgs e)
        {
            //SendKeys.Send("{RIGHT}");
            //if (dt_bady.Text != "" || dt_bady.Text != "0000-00-00 00:00:00" || dt_bady.Text != "00/00/0000")
            //{
            //    int age_ = DateTime.Now.Year - dt_bady.Value.Year;
            //    txt_age.Text = age_.ToString();

            //    DateTime CurrentDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            //    int Age = CurrentDate.Year - dt_bady.Value.Year;

            //    if (CurrentDate.Month < dt_bady.Value.Month)
            //    {
            //        Age--;
            //    }
            //    else if ((CurrentDate.Month == dt_bady.Value.Month) && (CurrentDate.Day < dt_bady.Value.Day))
            //    {

            //        Age--;
            //    }
            //    this.txt_age.Text = Age.ToString();




            //}
            //else
            //{
            //    txt_age.Clear();
            //}











        }







        private void cbo_color_fecal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_color_fecal.Text == "[other]") { txt_color_other_fecal.Visible = true; } else { txt_color_other_fecal.Visible = false; txt_color_other_fecal.Clear(); }
        }

        private void cmd_repeatHema_Click(object sender, EventArgs e)
        {
            //using (frm_repeat_Hema f = new frm_repeat_Hema(this))
            //{
            //    f.Tag = Patient_pin.Text;
            //    f.PatientName = name.Text;
            //    f.Sex = gender.Text;
            //    f.Address = address.Text;
            //    f.CivilStatus = civil_stat.Text;
            //    f.Age = txt_age.Text;
            //    f.Position = position.Text;
            //    f.ShowDialog();
            //}

            Tool.printMessage();

        }

        private void cmd_chemistry_Click(object sender, EventArgs e)
        {
            //frm_repeat_Chemistry f = new frm_repeat_Chemistry(this);
            //f.Tag = Patient_pin.Text;
            ////   f_chem.Text = Patient_pin.Text;

            //f.Age = txt_age.Text;
            //f.PatientName = name.Text;
            //f.Sex = gender.Text;
            //f.Address = address.Text;
            //f.CivilStatus = civil_stat.Text;
            //f.Age = txt_age.Text;
            //f.Position = position.Text;
            //f.ShowDialog();
            Tool.printMessage();
        }

        //void Delete_Record()
        //{

        //    try
        //    {


        //        ClassSql a = new ClassSql();
        //        a.ExecuteQuery("Delete from t_med_history where resultid = '" + LabId.Text + "' and resulttype= 'LAB'");
        //        a.ExecuteQuery("Delete from t_med_history2 where resultid = '" + LabId.Text + "' and resulttype= 'LAB'");
        //        a.ExecuteQuery("Delete from t_phy_exam where resultid = '" + LabId.Text + "' and resulttype= 'LAB'");
        //        a.ExecuteQuery("Delete from t_others where resultid = '" + LabId.Text + "' and resulttype= 'LAB'");
        //        a.ExecuteQuery("Delete from t_ancillary where resultid = '" + LabId.Text + "' and resulttype= 'LAB'");
        //        a.ExecuteQuery("Delete from t_result_main where resultid = '" + LabId.Text + "' and resulttype= 'LAB'");

        //        Tool.MessageBoxDelete();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //    }
        //    finally
        //    {
        //        //if (ClassSql.cnn != null) {// }
        //        if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //    }

        //}


        private void labID_TextChanged(object sender, EventArgs e)
        {
            //Search_lab();          
            //Search_Hema();
            //Search_Chemistry();
            //Search_Urinalysis();
            //Search_Fecalysis();


            //if (LabId.Text == "")
            //{

            //    fmain.ts_add_lab.Enabled = true; fmain.ts_edit_lab.Enabled = false; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = false; fmain.ts_search_lab.Enabled = true; fmain.ts_print_lab.Enabled = false; fmain.ts_cancel_lab.Enabled = false;
            //}
            //else
            //{
            //    fmain.ts_add_lab.Enabled = true; fmain.ts_edit_lab.Enabled = true; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = false; fmain.ts_search_lab.Enabled = true; fmain.ts_print_lab.Enabled = false; fmain.ts_cancel_lab.Enabled = false;
            //}





        }

        private void cmd_repeatUrinal_Click(object sender, EventArgs e)
        {
            ////
            // frm_repeat_Urninalysis f = new frm_repeat_Urninalysis(this);
            // f.Tag = Patient_pin.Text;
            // f.Age = txt_age.Text;
            // f.PatientName = name.Text;
            // f.Sex = gender.Text;
            // f.Address = address.Text;
            // f.CivilStatus = civil_stat.Text;
            // f.Position = position.Text;
            // f.ShowDialog();
            Tool.printMessage();
        }

        private void cmd_Repeat_fecalysis_Click(object sender, EventArgs e)
        {
            //frm_repeat_Fecalysis f = new frm_repeat_Fecalysis(this);
            //f.Tag = Patient_pin.Text;
            //f.Age = txt_age.Text;
            //f.PatientName = name.Text;
            //f.Sex = gender.Text;
            //f.Address = address.Text;
            //f.CivilStatus = civil_stat.Text;
            //f.Age = txt_age.Text;
            //f.Position = position.Text;
            //f.ShowDialog();
            Tool.printMessage();
        }




        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }



        void insert()
        {
            try
            {


                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);


                int normal_hema, normal_urinalysis, normal_fecalysis;
                if (cb_hema.Checked)
                {
                    normal_hema = 1;
                }
                else
                {
                    normal_hema = 0;
                }
                if (this.cb_remark_urinalysis.Checked)
                {
                    normal_urinalysis = 1;
                }
                else
                {
                    normal_urinalysis = 0;
                }
                if (this.cb_fecalysis.Checked)
                {
                    normal_fecalysis = 1;
                }
                else
                {
                    normal_fecalysis = 0;
                }




                //  db.sp_insert_hema_gamosa(Hemoglobin.Text, Hematocrit.Text, RBCCount.Text, WBCCount.Text, Neutrophils.Text, Lymphocytes.Text, Eosonophils.Text, Monocytes.Text, Basophils.Text, Platelet.Text, dt_resultdate.Text, normal_hema, txt_finding_hema.Text, LabId.Text, txt_papin.Text);
                db.ExecuteCommand("INSERT INTO dbo.t_hematology (Hemoglobin, Hematocrit, RBCCount, WBCCount, Neutrophils, Lymphocytes, Eosonophils, Monocytes, Basophils, Platelet, ResultDate, Normal, Findings, resultid, Papin, aboTyping, rh,fbs, rbs) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13},{14},{15},{16},{17},{18})", Hemoglobin.Text, Hematocrit.Text, RBCCount.Text, WBCCount.Text, Neutrophils.Text, Lymphocytes.Text, Eosonophils.Text, Monocytes.Text, Basophils.Text, Platelet.Text, txt_resultdate.Text, normal_hema, txt_finding_hema.Text, LabId.Text, txt_papin.Text, txt_abo.Text, txt_rh.Text, txt_fbs.Text, txt_rbs.Text);
                db.ExecuteCommand("INSERT INTO t_result_main (resultid, resulttype, papin, result_date, fitness_date, reference_no) VALUES ({0}, {1}, {2}, {3}, {4}, {5})", LabId.Text, "LAB", txt_papin.Text, txt_resultdate.Text, txt_resultdate.Text, txt_labNo.Text);
                db.sp_insertUrinalysis_gamosa(LabId.Text, Color.Text, Transparency.Text, pH.Text, SpecificGravity.Text, Sugar.Text, Albumin.Text, Bacteria.Text, wbc.Text, rbc.Text, EpithelialCells.Text, MucousThreads.Text, AmorphousUrates.Text, Casts.Text, Crystals.Text, PregnancyTest.Text, txt_resultdate.Text, normal_urinalysis, txt_remark_urinalysis.Text, txt_papin.Text);
                db.ExecuteCommand("INSERT INTO t_fecalysis (resultid, color, Consistency, PusCells, rbc, ova, Normal, Findings, other,Papin,hbsag,hbsag_Tag,hbsagB,hbsagB_Tag) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8},{9},{10},{11},{12},{13})", LabId.Text, cbo_color_fecal.Text, cbo_consistency.Text, PusCells.Text, fecal_rbc.Text, cbo_ova.Text, normal_fecalysis, txt_facalisys_findings.Text, txt_color_other_fecal.Text, txt_papin.Text, cbo_hbsag.Text, cbo_HBsA.Text, cbo_hbsagB.Text, cbo_HBsB.Text);


                //labsearch.Clear(); QueueSearchList_Model.Clear();
                //if (!backgroundWorker1.IsBusy)
                //{ backgroundWorker1.RunWorkerAsync(); }



                txt_papin.Select();
                Availability(false);
                fmain.ts_add_lab.Enabled = true; fmain.ts_edit_lab.Enabled = true; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = false; fmain.ts_cancel_lab.Enabled = false; fmain.ts_search_lab.Enabled = true; fmain.ts_print_lab.Enabled = true;




            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }

            //


        }



        public void Update_Medical()
        {
            try
            {


                int normal_hema, normal_urinalysis, normal_fecalysis;
                if (cb_hema.Checked)
                {
                    normal_hema = 1;
                }
                else
                {
                    normal_hema = 0;
                }
                if (this.cb_remark_urinalysis.Checked)
                {
                    normal_urinalysis = 1;
                }
                else
                {
                    normal_urinalysis = 0;
                }
                if (this.cb_fecalysis.Checked)
                {
                    normal_fecalysis = 1;
                }
                else
                {
                    normal_fecalysis = 0;
                }

                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                db.ExecuteCommand("UPDATE t_fecalysis SET resultid={0}, color={1}, Consistency={2}, PusCells={3}, rbc={4}, ova={5}, Normal={6}, Findings={7}, other={8},hbsag={9},hbsag_Tag={10},hbsagB={11},hbsagB_Tag={12} WHERE (resultid={13})", txt_resultId.Text, cbo_color_fecal.Text, cbo_consistency.Text, PusCells.Text, fecal_rbc.Text, cbo_ova.Text, normal_fecalysis, txt_facalisys_findings.Text, txt_color_other_fecal.Text, cbo_hbsag.Text, cbo_HBsA.Text, cbo_hbsagB.Text, cbo_HBsB.Text, txt_resultId.Text);
                db.ExecuteCommand("UPDATE t_hematology SET Hemoglobin={0}, Hematocrit={1}, RBCCount={2}, WBCCount={3}, Neutrophils={4}, Lymphocytes={5}, Eosonophils={6}, Monocytes={7}, Basophils={8}, Platelet={9}, ResultDate={10}, Normal={11}, Findings={12},aboTyping={13},rh={14},fbs={15},rbs={16} WHERE (resultid={17})", Hemoglobin.Text, Hematocrit.Text, RBCCount.Text, WBCCount.Text, Neutrophils.Text, Lymphocytes.Text, Eosonophils.Text, Monocytes.Text, Basophils.Text, Platelet.Text, txt_resultdate.Text, normal_hema, txt_finding_hema.Text, txt_abo.Text, txt_rh.Text, txt_fbs.Text, txt_rbs.Text, txt_resultId.Text);
                db.ExecuteCommand("UPDATE t_result_main SET result_date={0}, fitness_date={1},reference_no={2} WHERE (resultid={3})", txt_resultdate.Text, txt_resultdate.Text, txt_labNo.Text, txt_resultId.Text);
                db.ExecuteCommand("UPDATE t_urinalysis SET resultid={0}, Color={1}, Transparency={2}, pH={3}, SpecificGravity={4}, Sugar={5}, Albumin={6}, Bacteria={7}, wbc={8}, rbc={9}, EpithelialCells={10}, MucousThreads={11}, AmorphousUrates={12}, Casts={13}, Crystals={14}, PregnancyTest={15}, ResultDate={16}, Normal={17}, Findings={18} WHERE (resultid={19})", txt_resultId.Text, Color.Text, Transparency.Text, pH.Text, SpecificGravity.Text, Sugar.Text, Albumin.Text, Bacteria.Text, wbc.Text, rbc.Text, EpithelialCells.Text, MucousThreads.Text, AmorphousUrates.Text, Casts.Text, Crystals.Text, PregnancyTest.Text, txt_resultdate.Text, normal_urinalysis, txt_remark_urinalysis.Text, txt_resultId.Text);


                txt_papin.Select();
                newlab = true;
                fmain.ts_add_lab.Enabled = true; fmain.ts_edit_lab.Enabled = true; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = false; fmain.ts_cancel_lab.Enabled = false; fmain.ts_search_lab.Enabled = true; fmain.ts_print_lab.Enabled = true;
                Availability(false);


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }



        }



        private void dt_resultdate_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dt_resultdate_MouseDown(object sender, MouseEventArgs e)
        {

        }



        private void dt_resultdate_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void Hema_RelustDate_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dt_Chemistry_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dt_Result_urinal_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void dt_resultDate_Fecalysis_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }
















        private void tx_sgot_conventional_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_sgot_TextChanged(object sender, EventArgs e)
        {

        }



        //this is in frm_lab
        //
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                foreach (var item in db.lab_search("%"))
                {
                    labsearch.Add(new laboratory_search
                    {
                        cn = item.cn,
                        papin = item.papin,
                        PatientName = item.PatientName
                
                    });


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }




        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {


                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                foreach (var i in db.Search_patient_add_a("%"))
                {
                    QueueSearchList_Model.Add(new QueueSearchList_Model
                    {
                        cn = i.cn,
                        papin = i.papin,
                        PatientName = i.PatientName,
                        gender = i.gender,

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
            try
            {
                if (!backgroundWorker2.IsBusy)
                { backgroundWorker2.RunWorkerAsync(); }


                if ((Application.OpenForms["frm_search_Lab"] as frm_search_Lab) != null)
                {

                    (Application.OpenForms["frm_search_Lab"] as frm_search_Lab).FillDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }




        }

        private void frm_lab_Enter(object sender, EventArgs e)
        {
            //labsearch.Clear();
            //QueueSearchList_Model.Clear();
            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync();
            //}
        }

        private void cb_fecalysis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_remark_urinalysis_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_hbsag.Text == "REACTIVE")
            {
                cbo_HBsA.Visible = true;


            }
            else
            {
                cbo_HBsA.Text = "";
                cbo_HBsA.Visible = false;
            }
        }

        private void overlayShadow1_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Please  select patient  first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //MessageBox.Show("Please click EDIT BUTTON or press f4 key in your keyboard to modify!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



        }

        private void cbo_hbsagB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_hbsagB.Text == "REACTIVE")
            {
                cbo_HBsB.Visible = true;


            }
            else
            {
                cbo_HBsB.Text = "";
                cbo_HBsB.Visible = false;
            }
        }
    }
}
