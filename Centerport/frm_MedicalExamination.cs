using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;




namespace MedicalManagement
{

    public partial class frm_MedicalExamination : Form, MyInter
    {
        Main fmain; public static string Action; public static bool Count;

        //public string Papin = "";
        private string rb_Allergies = "-";
        private string rb_AnemiaBleeding = "-";
        private string rb_Asthma = "-";
        private string rb_BloodProblem = "-";
        private string rb_CancerTumor = "-";
        private string rb_Chickenpox = "-";
        private string rb_Clotting = "-";
        private string rb_Diabetes = "-";
        private string rb_DiabetesMellitus = "-";
        private string rb_Epilepsy = "-";
        private string rb_EyeEarDisorders = "-";
        private string rb_GastritisUlcer = "-";
        private string rb_GeneticDisorders = "-";
        private string rb_GermanMeasles = "-";
        private string rb_HeadachesMigraine = "-";
        private string rb_HeartDisease = "-";
        private string rb_Hepatitis = "-";
        private string rb_Hernia = "-";
        private string rb_Hypertension = "-";
        private string rb_KidneyDisease = "-";
        private string rb_LiverDisease = "-";
        private string rb_Measles = "-";
        private string rb_MentalDisorders = "-";
        private string rb_Musculoskeletal = "-";
        private string rb_NoseThroatDisorders = "-";
        private string rb_Pneumonia = "-";
        private string rb_PsychologicalDisorder = "-";
        private string rb_PTB = "-";
        private string rb_SeizureDisorders = "-";
        private string rb_SexuallyTransmitted = "-";
        private string rb_SkinDisease = "-";
        private string rb_ThyroidDisorders = "-";
        private string rb_Tubercolosis = "-";
        private string rb_TyphoidParatyphoid = "-";
        private string rb_Ulcers = "-";
        private string rb_Vertigo = "-";
        private string txt_Other = "-";

        private string rb_Smoker = "-";
        private string txt_NoOfPackDay = "-";
        private string rb_AlcoholDrinker = "-";
        private string txt_NoOfYear = "-";








        private string ISHIHARA_U_;
        // private string ISHIHARA_C_;
        private string SATISFACTORY_SIGHT_AID_;
        private string SATISFACTORY_PSYCHO_;
        private string VISUAL_AIDS_;
        private string CLARITY_OF_SPEECH_;
        private string HEARING_RIGHT_;
        private string HEARING_LEFT_;


        private string cb_skin_;
        private string cb_neck_;
        private string cb_eyes_;
        private string cb_pupils_;
        private string cb_ears_;
        private string cb_nose_;
        private string cb_mought_;
        private string cb_thyroid_;
        private string cb_breast_;
        private string cb_lungs_;
        private string cb_heart_;
        private string cb_abdomen_;
        private string cb_back_;
        private string cb_anus_;
        private string cb_gu_;
        private string cb_inguinals_;
        private string cb_reflexes_;
        private string cb_extremeties_;
        private string cb_dental_;





        public DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
        public List<landbaseSearckList_Model> landbaseSearckList_model = new List<landbaseSearckList_Model>();
        public List<QueueSearchList_Model> LandBaseAdd_model = new List<QueueSearchList_Model>();


        public static bool newLandbase;
        public frm_MedicalExamination(Main mainn)
        {
            InitializeComponent();
            //Text_papin = txt_papin; 
            //LabID = txt_resultID;

            fmain = mainn;
            //tb_add = ts_add_land; tb_edit = ts_edit_land; tb_del = ts_delete_land; tb_Save = ts_save_land; tb_Cancel = ts_cancel_land; tb_Search = ts_search_land; tb_Print = ts_print_land;
        }

        public void CheckedallNo()
        {
            cb_allergies.Checked = true;
            cb_anemia.Checked = true;
            cb_asthma.Checked = true;
            cb_blood.Checked = true;
            cb_cancer.Checked = true;
            cb_chickenpox.Checked = true;
            //cb_clotting.Checked = true;
            cb_deabetes.Checked = true;
            //cb_deabetesmelitus.Checked = true;
            cb_epilepsey.Checked = true;
            //cb_eyeear.Checked = true;
            cb_gastritis.Checked = true;
            //cb_genetic.Checked = true;
            cb_germanmeasles.Checked = true;
            //cb_head.Checked = true;
            cb_heart.Checked = true;
            cb_hepa.Checked = true;
            //cb_hernia_N.Checked = true;
            cb_hypertension.Checked = true;
            cb_kedney.Checked = true;
            //cb_liver.Checked = true;
            cb_measles.Checked = true;
            //cb_mental.Checked = true;
            //cb_muscu.Checked = true;
            cb_nose.Checked = true;
            //cb_Pneumonia.Checked = true;
            //cb_Psychological.Checked = true;
            cb_ptb.Checked = true;
            //cb_Seizure.Checked = true;
            //cb_Sexually_N.Checked = true;
            //cb_ski.Checked = true;
            cb_ThyroidDisorder.Checked = true;
            //cb_Tubercolosis.Checked = true;
            //cb_Typhoid.Checked = true;
            cb_Ulcer.Checked = true;
            cb_vertigo.Checked = true;
            //  txt_medhistory_other.Clear();
            // txt_PresentSymptoms.Clear();
            // txt_familyMediHistory.Clear();
            // txt_OperationsandAccidents.Clear();
            // txt_PersonalSocialHistory.Clear();
            // txt_noofpackday.Clear();       
            Cb_smoker.Checked = true;
            cb_drinker.Checked = true;
            // txtnoofyear.Clear(); 






            cb_skin.Checked = true;
            cb_neck.Checked = true;
            cb_eyes.Checked = true;
            cb_anus.Checked = true;
            cb_ears.Checked = true;
            cb_nose.Checked = true;
            cb_mought.Checked = true;
            //cb_thyroid.Checked = true;
            cb_breast.Checked = true;
            cb_lungs.Checked = true;
            cb_heart.Checked = true;
            cb_abdomen.Checked = true;
            cb_back.Checked = true;
            //cb_anus.Checked = true;
            //cb_gu.Checked = true;
            cb_inguinals.Checked = true;
            cb_extremeties.Checked = true;
            //cb_reflexes.Checked = true;
            //cb_dental.Checked = true;



        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.Default;
            Availability(false);
            //txt_papin.Select();


        }


        public void searchAll()
        {
            //ClearAll();
            Search_Patient();
            Search_MedicalHistory();
            Search_PhyExam();
            Search_others();
            search_Ancillary();
            search_Recomendation();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_MedicalExaminationWorkers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            // fmain.Strip_sub.Visible = false;
            fmain.landbase = true;
            fmain.ts_add_land.Enabled = true; fmain.ts_edit_land.Enabled = false; fmain.ts_delete_land.Enabled = false; fmain.ts_save_land.Enabled = false; fmain.ts_search_land.Enabled = true; fmain.ts_print_land.Enabled = false; fmain.ts_cancel_land.Enabled = false;
        }


        public void Availability(bool bl)
        {
            if (bl == true)
            { overlayShadow1.Visible = false; overlayShadow1.SendToBack(); }
            else
            { overlayShadow1.Visible = true; overlayShadow1.BringToFront(); }
            //Text_papin.Select();
        }


        public void ClearAll()
        {



            Tool.ClearFields(panel3);
            Tool.ClearFields(panel4);
            Tool.ClearFields(panel6);
            Tool.ClearFields(groupBox3);
            Tool.ClearFields(panel1);
            Tool.ClearFields(panel4);
                    



            cb_skin.Checked = true;
            cb_neck.Checked = true;
            cb_eyes.Checked = true;
            cb_anus.Checked = true;
            cb_ears.Checked = true;
            cb_nose.Checked = true;
            cb_mought.Checked = true;
            cb_heart.Checked = true;
            cb_lungs.Checked = true;
            cb_breast.Checked = true;
            cb_abdomen.Checked = true;
            cb_inguinals.Checked = true;
            cb_back.Checked = true;
            cb_extremeties.Checked = true;



        }


        public void New()
        {



            txt_far_od.Text = "20/20";
            txt_os_u.Text = "20/20";
            //txt_Dysmenorrhea.Text = "(-)";
            txt_PresentSymptoms.Text = "(-)";
            txt_medication.Text = "(-)";
            txt_allergies.Text = "(-)";
            txt_OperationsandAccidents.Text = "(-)";
            xtxt_dentalUpperRight.Text = " 8 7 6 5 4 3 2 1";
            xtxt_dentalLowerRight.Text = " 8 7 6 5 4 3 2 1";
            xtxt_dentalUpperLeft.Text = "1 2 3 4 5 6 7 8";
            xtxt_dentalLowerLeft.Text = "1 2 3 4 5 6 7 8";
            txt_hematology_result.Text = "Normal";
            txt_urinalysis_result.Text = "Normal";
            txt_fecalysis_result.Text = "Normal";
            txt_xray_result.Text = "Normal";
            txt_xray_ecg_result.Text = "Normal";
            txt_drugtest_resut.Text = "Negative";
            cb_ishihara_u.Checked = false;
            cb_ishihar_c.Checked = false;


        }



        public void Save()
        {



            try
            {



                if (cb_allergies.Checked == true) { rb_Allergies = "Y"; } else { rb_Allergies = "N"; }
                if (cb_anemia.Checked == true) { rb_AnemiaBleeding = "Y"; } else { rb_AnemiaBleeding = "N"; }
                if (cb_asthma.Checked == true) { rb_Asthma = "Y"; } else { rb_Asthma = "N"; }
                if (cb_blood.Checked == true) { rb_BloodProblem = "Y"; } else { rb_BloodProblem = "N"; }
                if (cb_cancer.Checked == true) { rb_CancerTumor = "Y"; } else { rb_CancerTumor = "N"; }
                if (cb_chickenpox.Checked == true) { rb_Chickenpox = "Y"; } else { rb_Chickenpox = "N"; }

                if (cb_deabetes.Checked == true) { rb_DiabetesMellitus = "Y"; } else { rb_DiabetesMellitus = "N"; }
                if (cb_epilepsey.Checked == true) { rb_Epilepsy = "Y"; } else { rb_Epilepsy = "N"; }

                if (cb_gastritis.Checked == true) { rb_GastritisUlcer = "Y"; } else { rb_GastritisUlcer = "N"; }

                if (cb_germanmeasles.Checked == true) { rb_GermanMeasles = "Y"; } else { rb_GermanMeasles = "N"; }

                if (cb_heartDeseas.Checked == true) { rb_HeartDisease = "Y"; } else { rb_HeartDisease = "N"; }
                if (cb_hepa.Checked == true) { rb_Hepatitis = "Y"; } else { rb_Hepatitis = "N"; }
                if (cb_hernia.Checked == true) { rb_Hernia = "Y"; } else { rb_Hernia = "N"; }
                if (cb_hypertension.Checked == true) { rb_Hypertension = "Y"; } else { rb_Hypertension = "N"; }
                if (cb_kedney.Checked == true) { rb_KidneyDisease = "Y"; } else { rb_KidneyDisease = "N"; }

                if (cb_measles.Checked == true) { rb_Measles = "Y"; } else { rb_Measles = "N"; }

                if (cb_nose.Checked == true) { rb_NoseThroatDisorders = "Y"; } else { rb_NoseThroatDisorders = "N"; }

                if (cb_psychological.Checked == true) { rb_PsychologicalDisorder = "Y"; } else { rb_PsychologicalDisorder = "N"; }
                if (cb_ptb.Checked == true) { rb_PTB = "Y"; } else { rb_PTB = "N"; }

                if (cb_ThyroidDisorder.Checked == true) { rb_ThyroidDisorders = "Y"; } else { rb_ThyroidDisorders = "N"; }

                if (cb_Ulcer.Checked == true) { rb_Ulcers = "Y"; } else { rb_Ulcers = "N"; }
                if (cb_vertigo.Checked == true) { rb_Vertigo = "Y"; } else { rb_Vertigo = "N"; }
                if (Cb_smoker.Checked == true) { rb_Smoker = "Y"; } else { rb_Smoker = "N"; }
                if (cb_drinker.Checked == true) { rb_AlcoholDrinker = "Y"; } else { rb_AlcoholDrinker = "N"; }

                if (cb_ishihara_u.Checked == true) { ISHIHARA_U_ = "1"; } else if (cb_ishihara_u.Checked == false) { ISHIHARA_U_ = "0"; } else { ISHIHARA_U_ = "-"; }

                if (cb_skin.Checked == true) { cb_skin_ = "1"; } else { cb_skin_ = "0"; }
                if (cb_neck.Checked == true) { cb_neck_ = "1"; } else { cb_neck_ = "0"; }
                if (cb_eyes.Checked == true) { cb_eyes_ = "1"; } else { cb_eyes_ = "0"; }

                if (cb_anus.Checked == true) { cb_anus_ = "1"; } else { cb_anus_ = "0"; }


                if (cb_ears.Checked == true) { cb_ears_ = "1"; } else { cb_ears_ = "0"; }
                if (cb_nose.Checked == true) { cb_nose_ = "1"; } else { cb_nose_ = "0"; }
                if (cb_mought.Checked == true) { cb_mought_ = "1"; } else { cb_mought_ = "0"; }

                if (cb_breast.Checked == true) { cb_breast_ = "1"; } else { cb_breast_ = "0"; }
                if (cb_lungs.Checked == true) { cb_lungs_ = "1"; } else { cb_lungs_ = "0"; }
                if (cb_heart.Checked == true) { cb_heart_ = "1"; } else { cb_heart_ = "0"; }
                if (cb_abdomen.Checked == true) { cb_abdomen_ = "1"; } else { cb_abdomen_ = "0"; }
                if (cb_back.Checked == true) { cb_back_ = "1"; } else { cb_back_ = "0"; }

                if (cb_inguinals.Checked == true) { cb_inguinals_ = "1"; } else { cb_inguinals_ = "0"; }

                if (cb_extremeties.Checked == true) { cb_extremeties_ = "1"; } else { cb_extremeties_ = "0"; }



                string ISHIHARA_UCRUD = "";
                if (cb_ishihara_u.Checked == true)
                {
                    ISHIHARA_UCRUD = "1";
                }
                else if (cb_ishihar_c.Checked == true)
                {
                    ISHIHARA_UCRUD = "0";


                }

                db.sp_MedicalExaminationProcess("-", txtPapin.Text, "EMC", txt_result_date.Text, "", "PENDING", txt_result_date.Text, "-", txt_remark.Text, txt_recomendation.Text, "", "-", "", txt_AttendingDentist.Text, "", "", "-", "", "", "", "", "", "", "", cbo_evaluation.Text,
                     rb_Allergies, rb_AnemiaBleeding, rb_Asthma, rb_BloodProblem, rb_CancerTumor, rb_Chickenpox, rb_Clotting, rb_Diabetes, rb_DiabetesMellitus, rb_Epilepsy, rb_EyeEarDisorders, rb_GastritisUlcer, rb_GeneticDisorders, rb_GermanMeasles, rb_HeadachesMigraine, rb_HeartDisease, rb_Hepatitis, rb_Hernia, rb_Hypertension, rb_KidneyDisease, rb_LiverDisease, rb_Measles, rb_MentalDisorders, rb_Musculoskeletal, rb_NoseThroatDisorders, rb_Pneumonia, rb_PsychologicalDisorder, rb_PTB, rb_SeizureDisorders, rb_SexuallyTransmitted, rb_SkinDisease, rb_ThyroidDisorders, rb_Tubercolosis, rb_TyphoidParatyphoid, rb_Ulcers, rb_Vertigo, txt_medhistory_other.Text, txt_PresentSymptoms.Text, txt_medication.Text, txt_OperationsandAccidents.Text, txt_allergies.Text, rb_Smoker, txt_noofpackday.Text, rb_AlcoholDrinker, txtdrinknoofyear.Text,
                     txt_height.Text, txt_weight.Text, txt_bpsystolic.Text + "/" + txt_bp_diastolic.Text, txt_pulse.Text, txt_respiation.Text, txt_bmi_val.Text + "/" + txt_bodyBuilt.Text, txt_far_od.Text, txt_od_c.Text, txt_os_u.Text, txt_os_c.Text, txt_near_od.Text, txt_near_os.Text, "", "", ISHIHARA_UCRUD, "", "", "", "", txt_conversational.Text, "", "", "", "", "", "", "", "", "", "", "", txt_bp_diastolic.Text, "", "", "", "", "", xtxt_dentalUpperRight.Text, xtxt_dentalUpperLeft.Text, xtxt_dentalLowerRight.Text, xtxt_dentalLowerLeft.Text, txt_lmp.Text, txt_obScore.Text, txt_interval.Text, txt_duration.Text, txt_Dysmenorrhea.Text, txt_oral.Text, txt_filling.Text, txt_extraction.Text, txt_otherPhysicalExam.Text, txt_w_gras_ou.Text, txt_wo_glas_ou.Text, txt_near_ou.Text, txt_hematology_result.Text, txt_hematology_findings.Text, txt_urinalysis_result.Text, txt_urinalysis_finding.Text, txt_fecalysis_result.Text, txt_fecalysis_finding.Text, txt_xray_result.Text, txt_xray_finding.Text, txt_xray_ecg_result.Text, txt_xray_ecg_finding.Text, txt_psychology_result.Text, txt_psychology_finding.Text, txt_hbsag_result.Text, txt_hbsag_finding.Text, txt_pregnancy_result.Text, txt_pregnancy_finding.Text, txt_bloodType_result.Text, txt_bloodType_finding.Text, txt_drugtest_resut.Text, txt_drugtest_finding.Text, cb_skin_.ToString(), x_skin.Text, cb_neck_.ToString(), x_neck.Text, cb_eyes_.ToString(), x_eyes.Text, "", "", cb_ears_.ToString(), x_ears.Text, cb_nose_.ToString(), x_nose.Text, cb_mought_.ToString(), x_mouth.Text, "", "", cb_breast_.ToString(), x_breast.Text, cb_lungs_.ToString(), x_lungs.Text, cb_heart_.ToString(), x_heart.Text, cb_abdomen_.ToString(), x_abdomen.Text, cb_back_.ToString(), x_back.Text, cb_anus_.ToString(), x_anus.Text, "", "", cb_inguinals_.ToString(), x_inguinals.Text, "", "", cb_extremeties_.ToString(), x_extremeties.Text,txt_detalOthers.Text);

                Availability(false);

                fmain.ts_add_land.Enabled = true; fmain.ts_edit_land.Enabled = true; fmain.ts_delete_land.Enabled = false; fmain.ts_save_land.Enabled = false; fmain.ts_cancel_land.Enabled = false; fmain.ts_search_land.Enabled = true; fmain.ts_print_land.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }









        }




        public void Edit()
        {
            if (fmain.UserLevel == 1 || fmain.UserLevel == 2)
            {
                newLandbase = false;
                Availability(true);
                fmain.ts_add_land.Enabled = false; fmain.ts_edit_land.Enabled = false; fmain.ts_delete_land.Enabled = false; fmain.ts_save_land.Enabled = true; fmain.ts_cancel_land.Enabled = true; fmain.ts_search_land.Enabled = false; fmain.ts_print_land.Enabled = false;

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
            // MessageBox.Show("Delete");    
            //Delete_Record();

        }
        public void Cancel()
        {
            if (newLandbase)
            {
                Tool.ClearFields(groupBox3);
                ClearAll();
                Availability(false);
                fmain.ts_add_land.Enabled = true; fmain.ts_edit_land.Enabled = false; fmain.ts_delete_land.Enabled = false; fmain.ts_save_land.Enabled = false; fmain.ts_search_land.Enabled = true; fmain.ts_print_land.Enabled = false; fmain.ts_cancel_land.Enabled = false;
            }
            else
            {



                Availability(false);
                ClearAll();
                //Search_Patient();
                //Search_MedicalHistory();
                //Search_PhyExam();
                //Search_others();
                //search_Ancillary();
                //search_Recomendation();
                searchAll();
                fmain.ts_add_land.Enabled = true; fmain.ts_edit_land.Enabled = true; fmain.ts_delete_land.Enabled = false; fmain.ts_save_land.Enabled = false; fmain.ts_search_land.Enabled = true; fmain.ts_print_land.Enabled = true; fmain.ts_cancel_land.Enabled = false;


            }

        }





        public void Print()
        {
            try
            {





                Search_Urinalysis();
                Search_Hema();
                Search_Fecalysis();

                Search_Radiology(txtPapin.Text, "XRAY");
                Search_Radiology(txtPapin.Text, "ECG");
                Search_Radiology(txtPapin.Text, "UTZ");

                Search_MedicalHistory();
                Search_PhyExam();
                Search_others();
                search_Ancillary();
                search_Recomendation();

                searchBloodTyping();
                searchSerology();

                if (Datas.ISHIHARA != null)
                {
                    string ISHIHARA_ = "";


                    if (Datas.ISHIHARA.ToString() == "1")
                    {
                        ISHIHARA_ = "Normal";
                    }
                    else if (Datas.ISHIHARA.ToString() == "0")
                    {
                        ISHIHARA_ = "Defective";
                    }
                    else
                    {
                        ISHIHARA_ = "-";
                    }
                    Datas.ISHIHARA = ISHIHARA_;

                }


                //


                //GET ALL VARIABLE NAME AND VALUES OF DATAS.CS AND STORE IN GENERIC LIST "WorkSheetValueList"
                List<string> WorkSheetValueList = new List<string>();
                Type type = typeof(Datas); // Get type pointer
                FieldInfo[] fields = type.GetFields(); // Obtain all fields
                foreach (var field in fields) // Loop through fields
                {
                    string name = field.Name; // Get string name     
                    object temp = field.GetValue(null); // Get value
                    string value = temp as string;
                    WorkSheetValueList.Add(value);

                }
                //
                //REPORTING
                string[] WorkSheetValue = WorkSheetValueList.ToArray();

                Reporting.Write("Pre-Employment Medical Exam-TEMPLATE",
                    new string[] { "B9",
                                    "B10",
                                    "B11",
                                    "H9",
                                    "H10",
                                    "R9",
                                    "R10",
                                    "D14",
                                    "E17",
                                    "E18",
                                    "E19",
                                    "E20",
                                    "E21",
                                    "E22",
                                    "E23",
                                    "E24",
                                    "J17",
                                    "J18",
                                    "J19",
                                    "J20",
                                    "J21",
                                    "J22",
                                    "J23",
                                    "J24",
                                    "W17",
                                    "W18",
                                    "W19",
                                    "W20",
                                    "W21",
                                    "W22",
                                    "W23",
                                    "W24",
                                    "D26",
                                    "D27",
                                    "D28",
                                    "D31",
                                    "I30",
                                    "I31",
                                    "D34",
                                    "G35",
                                    "D36",
                                    "D37",
                                    "D38",
                                    "G34",
                                    "E41",
                                    "E42", 
                                    "H41",
                                    "H42",
                                    "D44",
                                    "D46",
                                    "P35",
                                    "P36",
                                    "P37",
                                    "P38",
                                    "P39",
                                    "P40",
                                    "P41",
                                    "P42",
                                    "P43",
                                    "P44",
                                    "P45",
                                    "P46",
                                    "P47",
                                    "P48",
                                    "R35",
                                    "R36",
                                    "R37",
                                    "R38",
                                    "R39",
                                    "R40",
                                    "R41",
                                    "R42",
                                    "R43",
                                    "R44",
                                    "R45",
                                    "R46",
                                    "R47",                                   
                                    "E49",
                                    "E51",
                                    "E50",
                                    "E52",
                                    "I50",
                                    "I51",
                                    "I52",
                                    "I53",
                                    "I54",
                                    "D60",
                                    "D62",
                                    "D64",
                                    "D66",
                                    "D69",
                                    "D70",
                                    "D71",
                                    "D72",
                                    "D73",
                                    "D74",
                                    "I60",
                                    "I61",
                                    "I62",
                                    "I63",
                                    "I64",
                                    "I65",
                                    "I66",
                                    "I67",
                                    "I68",
                                    "I69",
                                    "I70",
                                    "I71",
                                    "I74",
                                    "V60",
                                    "V61",
                                    "V63",
                                    "V64",
                                    "S67",
                                    "S68",
                                    "S69",
                                    "S70",
                                    "B78",
                                    "B81",
                                    "M78",
                                    "M81",
                                    "D91",
                                    "D92",
                                     "R48",
                                     "P48",
                                     "R49",
                                     "D35",
                                     "S73",
                                     "S72"
                                    
},
                    WorkSheetValue);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Here", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


        }

        //


        public void Search()
        {



        }



        private void frm_MedicalExamination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fmain.ts_cancel_land.Enabled == true)
                { Cancel(); }
                else
                { this.Close(); }

            }
            else if (e.KeyCode == Keys.Add && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_add_land.Enabled == true)
                {

                    fmain.Add_landbase();
                }
            }

            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_save_land.Enabled == true)
                {
                    Save();

                }

            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_print_land.Enabled == true)
                {
                    Print();

                }
            }
            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {

                if (fmain.ts_search_land.Enabled == true)
                {
                    fmain.Search_landbase();
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (fmain.ts_edit_land.Enabled == true)
                {
                    Edit();

                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (fmain.ts_delete_land.Enabled == true)
                {

                    Delete();
                }

            }
            else if (e.KeyCode == Keys.F1 && e.Modifiers == Keys.Control)
            {
                txtPapin.Visible = true;
            }
            else if (e.KeyCode == Keys.F2 && e.Modifiers == Keys.Control)
            {
                txtPapin.Visible = false;
            }
        }



        public void Search_Patient( )
        {
            try
            {

                //
                var i = db.sp_landBase_Patient(txtPapin.Text).FirstOrDefault();

                if (i != null)
                {

                    txtlastname.Text = i.lastname.ToString() + ", " + i.firstname.ToString() + " " + i.middlename.ToString();

                    txt_add.Text = i.address_1.ToString() ?? "-";
                    txt_employer.Text = i.employer.ToString() ?? "-";
                    txt_gender.Text = i.gender.ToString() ?? "-";

                    //txt_position.Text = i.position.ToString() ?? "-";
                    //txt_rel.Text = i.religion.ToString() ?? "-";
                    txt_status.Text = i.marital_status.ToString() ?? "-";
                    txt_contact.Text = i.contact_1.ToString() ?? "-";
                    txt_bday.Text = i.birthdate.ToString() ?? "-";
                    txt_age.Text = Tool.ComputeAge(Convert.ToDateTime(txt_bday.Text)).ToString();



                    Datas.PatientName = txtlastname.Text;
                    Datas.address_1 = txt_add.Text;
                    Datas.employer = txt_employer.Text;
                    Datas.gender = txt_gender.Text;
                    Datas.marital_status = txt_status.Text;
                    Datas.contact_1 = txt_contact.Text;


                    DateTime bdate = new DateTime();

                    DateTime temp_Bday;
                    if (DateTime.TryParse(txt_bday.Text, out temp_Bday))
                    {

                        bdate = Convert.ToDateTime(txt_bday.Text).Date;
                    }

                    string g = txt_age.Text + " / " + Datas.gender;
                    Datas.gender = null;//reset the variable
                    Datas.gender = g;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }



        }

        private void txt_papin_TextChanged(object sender, EventArgs e)
        {

        }




        private void txt_resultID_TextChanged(object sender, EventArgs e)
        {






        }
        private void setCheck(string str, CheckBox cb)
        {
            if (str == "Y")
            {
                cb.Checked = true;

            }
            else
            {
                cb.Checked = false;

            }

        }
        public void Search_MedicalHistory()
        {
            try
            {

                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var i = db.emc_medicalHistory(txtPapin.Text).FirstOrDefault();
                if (i != null)
                {

                    panel3.Tag = i.cn.ToString();
                    setCheck(i.Allergies, cb_allergies);
                    setCheck(i.AnemiaBleeding, cb_anemia);
                    setCheck(i.Asthma, cb_asthma);
                    setCheck(i.BloodProblem, cb_blood);
                    setCheck(i.CancerTumor, cb_cancer);
                    setCheck(i.Chickenpox, cb_chickenpox);

                    setCheck(i.DiabetesMellitus, cb_deabetes);
                    setCheck(i.Hernia, cb_hernia);
                    setCheck(i.Epilepsy, cb_epilepsey);
                    setCheck(i.HeartDisease, cb_heartDeseas);
                    setCheck(i.GastritisUlcer, cb_gastritis);
                    setCheck(i.PsychologicalDisorder, cb_psychological);
                    setCheck(i.GermanMeasles, cb_germanmeasles);

                    //setCheck(i.HeartDisease, cb_heart);
                    setCheck(i.Hepatitis, cb_hepa);

                    setCheck(i.Hypertension, cb_hypertension);
                    setCheck(i.KidneyDisease, cb_kedney);

                    setCheck(i.Measles, cb_measles);


                    setCheck(i.NoseThroatDisorders, cb_nose);


                    setCheck(i.PTB, cb_ptb);


                    setCheck(i.ThyroidDisorders, cb_ThyroidDisorder);

                    setCheck(i.Ulcers, cb_Ulcer);
                    setCheck(i.Vertigo, cb_vertigo);
                    txt_medhistory_other.Text = i.Other;
                    txt_PresentSymptoms.Text = i.PresentSymptoms;
                    txt_OperationsandAccidents.Text = i.OperationsandAccidents;
                    txt_medication.Text = i.FamilyMedicalHistory;
                    txt_allergies.Text = i.PersonaSocialHistory;
                    setCheck(i.Smoker, Cb_smoker);
                    txt_noofpackday.Text = i.NoOfPackDay;
                    setCheck(i.AlcoholDrinker, cb_drinker);
                    txtdrinknoofyear.Text = i.NoOfYear;


                    Datas.Allergies = i.PersonaSocialHistory;

                    Datas.Asthma = i.Asthma == "Y" ? "YES" : "NO";

                    Datas.CancerTumor = i.CancerTumor == "Y" ? "YES" : "NO";
                    Datas.Chickenpox = i.Chickenpox == "Y" ? "YES" : "NO";

                    Datas.DiabetesMellitus = i.DiabetesMellitus == "Y" ? "YES" : "NO";

                    Datas.EyeEarDisorders = i.EyeEarDisorders == "Y" ? "YES" : "NO";
                    Datas.GastritisUlcer = i.GastritisUlcer == "Y" ? "YES" : "NO";
                    Datas.GeneticDisorders = i.GeneticDisorders == "Y" ? "YES" : "NO";

                    Datas.HeadachesMigraine = i.HeadachesMigraine == "Y" ? "YES" : "NO";
                    Datas.HeartDisease = i.HeartDisease == "Y" ? "YES" : "NO";

                    Datas.Hypertension = i.Hypertension == "Y" ? "YES" : "NO";
                    Datas.KidneyDisease = i.KidneyDisease == "Y" ? "YES" : "NO";
                    Datas.LiverDisease = i.LiverDisease == "Y" ? "YES" : "NO";
                    Datas.Measles = i.Measles == "Y" ? "YES" : "NO";
                    Datas.MentalDisorders = i.MentalDisorders == "Y" ? "YES" : "NO";
                    Datas.Musculoskeletal = i.Musculoskeletal == "Y" ? "YES" : "NO";
                    Datas.NoseThroatDisorders = "NO";
                    Datas.Pneumonia = i.Pneumonia == "Y" ? "YES" : "NO";

                    Datas.SeizureDisorders = i.SeizureDisorders == "Y" ? "YES" : "NO";
                    Datas.SexuallyTransmitted = i.SexuallyTransmitted == "Y" ? "YES" : "NO";
                    Datas.SkinDisease = i.SkinDisease == "Y" ? "YES" : "NO";
                    Datas.ThyroidDisorders = i.ThyroidDisorders == "Y" ? "YES" : "NO";
                    Datas.Tubercolosis = i.Tubercolosis == "Y" ? "YES" : "NO";
                    Datas.TyphoidParatyphoid = i.TyphoidParatyphoid == "Y" ? "YES" : "NO";

                    Datas.Other = i.Other == "Y" ? "YES" : "NO";
                    Datas.PresentSymptoms = i.PresentSymptoms ?? "(-)";

                    Datas.OperationsandAccidents = i.OperationsandAccidents ?? "(-)";

                    Datas.PersonaSocialHistory = i.FamilyMedicalHistory ?? "(-)";
                    Datas.Smoker = i.Smoker == "Y" ? "YES" : "NO";

                    string alchohol = "";
                    if (i.AlcoholDrinker == "Y")
                    {
                        alchohol = "YES";
                    }
                    else if (i.AlcoholDrinker == "N")
                    {
                        alchohol = "NO";
                    }
                    else
                    {
                        alchohol = i.AlcoholDrinker;
                    }

                    Datas.AlcoholDrinker = alchohol;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }











































        double ConvertKgToLbs(double kg)
        {
            return kg * 2.20462262;
        }




        public void Search_PhyExam()
        {
            try
            {

                var i = db.sp_Landbase_Physical(txtPapin.Text).FirstOrDefault();
                if (i != null)
                {



                    lbl_physicalExam_cn.Tag = i.cn.ToString() ?? "-";
                    txt_weight.Text = i.WEIGHT.ToString() ?? "-";
                    txt_height.Text = i.HEIGHT.ToString() ?? "-";
                    string bmi = i.BODYBUILD.ToString() ?? "/";
                    string[] bmisplit = bmi.Split('/');
                    try
                    {
                        txt_bmi_val.Text = bmisplit[0];
                        txt_bodyBuilt.Text = bmisplit[1];
                    }
                    catch (Exception ex)
                    {


                    }
                    //


                    txt_pulse.Text = i.PULSE.ToString() ?? "-";
                    string bp = i.BP.ToString() ?? "-";
                    if (bp.Length != 0)
                    {
                        string[] s = bp.Split('/');
                        txt_bpsystolic.Text = s[0].ToString();
                        txt_bp_diastolic.Text = s[1].ToString();
                    }
                    txt_bp_diastolic.Text = i.BPDIASTOLIC.ToString() ?? "-";
                    txt_respiation.Text = i.RESPIRATION.ToString() ?? "-";
                    //txt_rhythm.Text = i.RHYTHM.ToString() ?? "-";
                    txt_far_od.Text = i.FARODU.ToString() ?? "-";
                    txt_od_c.Text = i.FARODC.ToString() ?? "-";
                    txt_conversational.Text = i.CONVERSATIONAL_AD.ToString() ?? "-";
                    txt_os_u.Text = i.FAROSU.ToString() ?? "-";
                    txt_os_c.Text = i.FAROSC.ToString() ?? "-";

                    txt_wo_glas_ou.Text = i.FarWoOU.ToString() ?? "-";
                    txt_w_gras_ou.Text = i.FarWgOU.ToString() ?? "-";
                  
                    txt_otherPhysicalExam.Text = i.obOther.ToString() ?? "-";

                    txt_near_ou.Text = i.NearOu.ToString() ?? "-";
                    txt_near_od.Text = i.NEARODJU.ToString() ?? "-";
                    txt_near_os.Text = i.NEARODJC.ToString() ?? "-";



                    //txt_near_os_u.Text = i.NEAROSJU.ToString() ?? "-";
                    //txt_near_osj_c.Text = i.NEAROSJC.ToString() ?? "-";

                    string ISHIHARA_U = i.ISHIHARA_U.ToString() ?? "-";
                    if (ISHIHARA_U == "1")
                    {
                        cb_ishihara_u.Checked = true;
                        cb_ishihar_c.Checked = false;
                    }
                    else if (ISHIHARA_U == "0")
                    {
                        cb_ishihara_u.Checked = false;
                        cb_ishihar_c.Checked = true;
                    }
                    else
                    {
                        cb_ishihara_u.Checked = false;
                        cb_ishihar_c.Checked = false;
                    }

                    //  string ISHIHARA_C = i.ISHIHARA_C.ToString() ?? "-";
                    // if (ISHIHARA_C == "1") { cb_ishihar_c.Checked = true; } else if (ISHIHARA_C == "0") { cb_ishihar_c.Checked = false; }

                    //cbo_hearing_ad.Text = i.HEARING_AD.ToString() ?? "-";
                    //cbo_hearing_as.Text = i.HEARING_AS.ToString() ?? "-";
                    //cbo_satisfactory_hearing.Text = i.SATISFACTORY_HEARING.ToString() ?? "-";
                    string SATISFACTORY_SIGHT_AID = i.SATISFACTORY_SIGHT_UNAID.ToString() ?? "-";
                    // if (SATISFACTORY_SIGHT_AID == "YES") { rb_satisfactory_Y.Checked = true; } else if (SATISFACTORY_SIGHT_AID == "NO") { rb_satisfactory_N.Checked = true; } else { rb_satisfactory_N.Checked = false; rb_satisfactory_Y.Checked = false; }

                    string SATISFACTORY_PSYCHO = i.SATISFACTORY_PSYCHO.ToString() ?? "-";
                    // if (SATISFACTORY_PSYCHO == "YES") { rb_Psycho_Y.Checked = true; } else if (SATISFACTORY_PSYCHO == "NO") { this.rb_Psycho_N.Checked = true; } else { rb_Psycho_N.Checked = false; rb_Psycho_Y.Checked = false; }

                    string VISUAL_AIDS = i.VISUALAIDS.ToString() ?? "-";
                    // if (VISUAL_AIDS == "YES") { this.rb_visual_Y.Checked = true; } else if (VISUAL_AIDS == "NO") { this.rb_visual_N.Checked = true; } else { this.rb_visual_N.Checked = false; this.rb_visual_Y.Checked = false; }

                    string CLARITY_OF_SPEECH = i.CLARITYOFSPEECH.ToString() ?? "-";
                    //  if (CLARITY_OF_SPEECH == "A") { rb_clarity_of_speech_Adequate.Checked = true; } else if (CLARITY_OF_SPEECH == "I") { rb_clarity_of_speech_InAdequate.Checked = true; }

                    string HEARING_RIGHT = i.HEARINGRIGHT.ToString() ?? "-";
                    //  if (HEARING_RIGHT == "A") { this.rb_hearingRight_adequate.Checked = true; } else if (HEARING_RIGHT == "I") { this.rb_hearingRight_Inadequate.Checked = true; }

                    string HEARING_LEFT = i.HEARINGLEFT.ToString() ?? "-";
                    // if (HEARING_LEFT == "A") { this.rb_hearingLeft_adequate.Checked = true; } else if (HEARING_LEFT == "I") { this.rb_hearingLeft_Inadequate.Checked = true; }

                    xtxt_dentalUpperRight.Text = i.DentalUpperRight ?? "-";
                    xtxt_dentalUpperLeft.Text = i.DentalUpperLeft ?? "-";
                    xtxt_dentalLowerRight.Text = i.DentalLowerRight ?? "-";
                    xtxt_dentalLowerLeft.Text = i.DentalLowerLeft ?? "-";

                    txt_detalOthers.Text = i.DentalOthers ?? "-";

                    setCheckCB(cb_oral, txt_oral, i.OralProphylaxis ?? "-");
                    setCheckCB(cb_filling, txt_filling, i.Fillings ?? "-");
                    setCheckCB(cb_extraction, txt_extraction, i.Extraction ?? "-");


                    txt_lmp.Text = i.lmp ?? "-";
                    txt_obScore.Text = i.obScore ?? "-";
                    txt_interval.Text = i.Interval ?? "-";
                    txt_duration.Text = i.Duration ?? "-";
                    txt_Dysmenorrhea.Text = i.Dysmenorrhea ?? "-";



                    Datas.HEIGHT = i.HEIGHT ?? "-";
                    Datas.WEIGHT_KG = i.WEIGHT ?? "-";
                    Datas.WEIGHT_LBS = "-";

                    if (i.WEIGHT != "")
                    {
                        Datas.WEIGHT_LBS = ConvertKgToLbs(Convert.ToDouble(i.WEIGHT)).ToString("n2");
                    }
                   


                    Datas.BP = i.BP ?? "-";
                    Datas.PULSE = i.PULSE ?? "-";

                    Datas.BODY_BUILD = i.BODYBUILD ?? "-";

                    Datas.FVOD_wo = i.FARODU;
                    Datas.FVOD_w = i.FARODC;
                    Datas.FVOS_w = i.FAROSC;
                    Datas.FVOS_wo = i.FAROSU;

                    Datas.NEAR_VISUAL =  txt_near_od.Text + "/" + txt_near_os.Text+"/"+txt_near_ou.Text;
 

                   




                    Datas.ISHIHARA = i.ISHIHARA_U ?? "-";




                    Datas.lmp = i.lmp ?? "-";
                    Datas.obScore = i.obScore ?? "-";
                    Datas.Interval = i.Interval ?? "-";
                    Datas.Duration = i.Duration ?? "-";
                    Datas.Dysmenorrhea = i.Dysmenorrhea ?? "-";
                    Datas.OralProphylaxis = i.OralProphylaxis ?? "-";
                    Datas.Filling = i.Fillings ?? "-";
                    Datas.Extraction = i.Extraction ?? "-";

                    //  txt_detalOthers.Text = i.DentalOthers ?? "-";

                    Datas.DentalOthers = i.DentalOthers ?? "-";

                    Datas.PHY_EXAM_OTHER = i.obOther ?? "-";

                }

                //


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }

        private void setCheckCB(CheckBox cb, TextBox txt, String str)
        {
            if (str == "")
            {
                cb.Checked = true;
                txt.Clear();

            }
            else
            {
                cb.Checked = false;
                txt.Text = str;
            }
        }
        public void Search_others()
        {
            try
            {

                var i = db.sp_Landbase_Others(txtPapin.Text).FirstOrDefault();
                if (i != null)
                {


                    lbl_other_cn.Tag = i.cn.ToString() ?? "-";
                    string SKIN_TAG = i.SKIN_TAG.ToString() ?? "-";
                    if (SKIN_TAG == "1") { cb_skin.Checked = true; } else { cb_skin.Checked = false; }
                    x_skin.Text = i.SKIN.ToString() ?? "-";

                    string HEAD_NECK_SCALP_TAG = i.HEAD_NECK_SCALP_TAG.ToString() ?? "-";
                    if (HEAD_NECK_SCALP_TAG == "1") { this.cb_neck.Checked = true; } else { cb_neck.Checked = false; }
                    x_neck.Text = i.HEAD_NECK_SCALP.ToString() ?? "-";

                    string EYES_TAG = i.EYES_TAG.ToString() ?? "-";
                    if (EYES_TAG == "1") { this.cb_eyes.Checked = true; } else { cb_eyes.Checked = false; }
                    x_eyes.Text = i.EYES.ToString() ?? "-";



                    string EARS_EARDRUM_TAG = i.EARS_EARDRUM_TAG.ToString() ?? "-";
                    if (EARS_EARDRUM_TAG == "1") { this.cb_ears.Checked = true; } else { cb_ears.Checked = false; }
                    x_ears.Text = i.EARS_EARDRUM.ToString() ?? "-";

                    string NOSE_SINUSES_TAG = i.NOSE_SINUSES_TAG.ToString() ?? "-";
                    if (NOSE_SINUSES_TAG == "1") { this.cb_nose.Checked = true; } else { cb_nose.Checked = false; }
                    x_nose.Text = i.NOSE_SINUSES.ToString() ?? "-";

                    string MOUTH_THROAT_TAG = i.MOUTH_THROAT_TAG.ToString() ?? "-";
                    if (MOUTH_THROAT_TAG == "1") { this.cb_mought.Checked = true; } else { cb_mought.Checked = false; }
                    x_mouth.Text = i.MOUTH_THROAT.ToString() ?? "-";


                    string CHEST_BREAST_AXILLA_TAG = i.CHEST_BREAST_AXILLA_TAG.ToString() ?? "-";
                    if (CHEST_BREAST_AXILLA_TAG == "1") { this.cb_breast.Checked = true; } else { cb_breast.Checked = false; }
                    x_breast.Text = i.CHEST_BREAST_AXILLA.ToString() ?? "-";

                    string LUNGS_TAG = i.LUNGS_TAG.ToString() ?? "-";
                    if (LUNGS_TAG == "1") { this.cb_lungs.Checked = true; } else { cb_lungs.Checked = false; }
                    x_lungs.Text = i.LUNGS.ToString() ?? "-";

                    string HEART_TAG = i.HEART_TAG.ToString() ?? "-";
                    if (HEART_TAG == "1") { this.cb_heart.Checked = true; } else { cb_heart.Checked = false; }
                    x_heart.Text = i.HEART.ToString() ?? "-";

                    string ABDOMEN_TAG = i.ABDOMEN_TAG.ToString() ?? "-";
                    if (ABDOMEN_TAG == "1") { this.cb_abdomen.Checked = true; } else { cb_abdomen.Checked = false; }
                    x_abdomen.Text = i.ABDOMEN.ToString() ?? "-";

                    string BACK_FLANK_TAG = i.BACK_FLANK_TAG.ToString() ?? "-";
                    if (BACK_FLANK_TAG == "1") { this.cb_back.Checked = true; } else { cb_back.Checked = false; }
                    x_back.Text = i.BACK_FLANK.ToString() ?? "-";

                    string ANUS_RECTUM_TAG = i.ANUS_RECTUM_TAG.ToString() ?? "-";
                    if (ANUS_RECTUM_TAG == "1") { this.cb_anus.Checked = true; } else { cb_anus.Checked = false; }
                    x_anus.Text = i.ANUS_RECTUM.ToString() ?? "-";

                    //string GU_SYSTEM_TAG = i.GU_SYSTEM_TAG.ToString() ?? "-";
                    //if (GU_SYSTEM_TAG == "1") { this.cb_gu.Checked = true; } else { cb_gu.Checked = false; }
                    //x_gu.Text = i.GU_SYSTEM.ToString() ?? "-";

                    string INGUINALS_GENITALS_TAG = i.INGUINALS_GENITALS_TAG.ToString() ?? "-";
                    if (INGUINALS_GENITALS_TAG == "1") { this.cb_inguinals.Checked = true; } else { cb_inguinals.Checked = false; }
                    x_inguinals.Text = i.INGUINALS_GENITALS.ToString() ?? "-";

                    //string REFLEXES_TAG = i.REFLEXES_TAG.ToString() ?? "-";
                    //if (REFLEXES_TAG == "1") { this.cb_reflexes.Checked = true; } else { cb_reflexes.Checked = false; }
                    //x_reflexes.Text = i.REFLEXES.ToString() ?? "-";

                    string EXTREMITIES_TAG = i.EXTREMITIES_TAG.ToString() ?? "-";
                    if (EXTREMITIES_TAG == "1") { this.cb_extremeties.Checked = true; } else { cb_extremeties.Checked = false; }
                    x_extremeties.Text = i.EXTREMITIES.ToString() ?? "-";

                    //x_dental.Text = i.DENTAL.ToString() ?? "-";
                    //string DENTAL_TAG = i.DENTAL_TAG.ToString() ?? "-";
                    //if (DENTAL_TAG == "1") { this.cb_dental.Checked = true; } else { cb_dental.Checked = false; }

                    Datas.SKIN_TAG = i.SKIN_TAG.ToString() == "1" ? "N" : "";
                    Datas.SKIN = i.SKIN;
                    Datas.HEAD_NECK_SCALP_TAG = i.HEAD_NECK_SCALP_TAG.ToString() == "1" ? "N" : "";
                    Datas.HEAD_NECK_SCALP = i.HEAD_NECK_SCALP;
                    Datas.EYES_TAG = i.EYES_TAG.ToString() == "1" ? "N" : "";
                    Datas.EYES = i.EYES;
                    Datas.EARS_EARDRUM_TAG = i.EARS_EARDRUM_TAG.ToString() == "1" ? "N" : "";
                    Datas.EARS_EARDRUM = i.EARS_EARDRUM;
                    Datas.NOSE_SINUSES_TAG = i.NOSE_SINUSES_TAG.ToString() == "1" ? "N" : "";
                    Datas.NOSE_SINUSES = i.NOSE_SINUSES;
                    Datas.MOUTH_THROAT_TAG = i.MOUTH_THROAT_TAG.ToString() == "1" ? "N" : "";
                    Datas.MOUTH_THROAT = i.MOUTH_THROAT;

                    Datas.CHEST_BREAST_AXILLA_TAG = i.CHEST_BREAST_AXILLA_TAG.ToString() == "1" ? "N" : "";
                    Datas.CHEST_BREAST_AXILLA = i.CHEST_BREAST_AXILLA;
                    Datas.LUNGS_TAG = i.LUNGS_TAG.ToString() == "1" ? "N" : "";
                    Datas.LUNGS = i.LUNGS;
                    Datas.HEART_TAG = i.HEART_TAG.ToString() == "1" ? "N" : "";
                    Datas.HEART = i.HEART;
                    Datas.ABDOMEN_TAG = i.ABDOMEN_TAG.ToString() == "1" ? "N" : "";
                    Datas.ABDOMEN = i.ABDOMEN;
                    Datas.BACK_FLANK_TAG = i.BACK_FLANK_TAG.ToString() == "1" ? "N" : "";
                    Datas.BACK_FLANK = i.BACK_FLANK;



                    Datas.INGUINALS_GENITALS_TAG = i.INGUINALS_GENITALS_TAG.ToString() == "1" ? "N" : "";
                    Datas.INGUINALS_GENITALS = i.INGUINALS_GENITALS;

                    Datas.EXTREMITIES_TAG = i.EXTREMITIES_TAG.ToString() == "1" ? "N" : "";
                    Datas.EXTREMITIES = i.EXTREMITIES;

                    Datas.DENTAL_TAG = i.DENTAL_TAG.ToString() == "1" ? "N" : "";



                    Datas.Anus = i.ANUS_RECTUM;
                    Datas.Anus_TAG = i.ANUS_RECTUM_TAG.ToString() == "1" ? "N" : "";


                    //Datas.PHY_EXAM_OTHER =  
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }



        }
        public void search_Ancillary()
        {


            try
            {


                var i = db.sp_Lanbase_ancillary(txtPapin.Text).FirstOrDefault();

                if (i != null)
                {





                    lbl_cn_acillary.Tag = i.cn.ToString() ?? "-";
                    txt_hematology_result.Text = i.Hematology_result.ToString() ?? "-";
                    txt_hematology_findings.Text = i.Hematology_finding;
                    txt_urinalysis_result.Text = i.Urinalysis_result;
                    txt_urinalysis_finding.Text = i.Urinalysis_finding;
                    txt_fecalysis_result.Text = i.Fecalysis_result;
                    txt_fecalysis_finding.Text = i.Fecalysis_finding;
                    txt_xray_result.Text = i.ChestXRay_result;
                    txt_xray_finding.Text = i.ChestXRay_finsing;
                    txt_xray_ecg_result.Text = i.ECG_result;
                    txt_xray_ecg_finding.Text = i.ECG_finsing;
                    txt_psychology_result.Text = i.PsychologicalTest_result;
                    txt_psychology_finding.Text = i.PsychologicalTest_finding;
                    txt_hbsag_result.Text = i.HBsAg_result;
                    txt_hbsag_finding.Text = i.HBsAg_finsing;
                    txt_pregnancy_result.Text = i.PregnancyTest_result;
                    txt_pregnancy_finding.Text = i.PregnancyTest_finding;
                    txt_bloodType_result.Text = i.BloodType_result;
                    txt_bloodType_finding.Text = i.BloodType_findings;
                    txt_drugtest_resut.Text = i.DrugTest_result;
                    txt_drugtest_finding.Text = i.DrugTest_finding;





                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }






        }



        void searchBloodTyping()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchBloodTyping(txtPapin.Text).FirstOrDefault();
            if (item != null)
            {

                Datas.abo = "-";
                if (item.Test1.Equals("BLOOD TYPE"))
                {
                    Datas.abo = item.Result1;
                }
                
                Datas.rh = "-";


                if (item.Test2.Equals("RH TYPE"))
                {
                    Datas.rh = item.Result2;
                }


                Datas.fbs = "-";
                Datas.rbs = "-";



            }

        }

        //
        void searchSerology()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchSerology(txtPapin.Text).FirstOrDefault();
            if (item != null)
            {
              
                Datas.PregnancyTest = "-";
                if (item.Test1.Equals("PREGNANCY TEST"))
                {
                    Datas.PregnancyTest = item.Result1;
                }

                if (item.Test2.Equals("PREGNANCY TEST"))
                {
                    Datas.PregnancyTest = item.Result2;
                }


                Datas.HEPA_B = "-";
                Datas.HEPA_A = "-";

                if (item.Test1.Equals("HEPA B"))
                {
                    Datas.HEPA_B = item.Result1;
                }
                else if (item.Test1.Equals("HEPA A"))
                {
                    Datas.HEPA_A = item.Result1;
                }

               
                if (item.Test2.Equals("HEPA B"))
                {
                    Datas.HEPA_B = item.Result2;
                }
                else if (item.Test2.Equals("HEPA A"))
                {
                    Datas.HEPA_A = item.Result1;
                }
               




            }
            
        }


        
        public void Search_Hema()
        {
            try
            {

                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var i = db.searchHematology(txtPapin.Text).FirstOrDefault();
                if (i != null)
                {
                    
                    Datas.Hemoglobin = i.Hemoglobin;
                    Datas.Hematocrit = i.Hematocrit;
                    Datas.RBCCount = i.Redbloodcells;
                    Datas.WBCCount = i.Whitebloodcells;
                    Datas.Neutrophils = i.Neutrophil;
                    Datas.Lymphocytes = i.Lymphocyte;
                    Datas.Eosonophils = i.Eosinophil;
                    Datas.Monocytes = i.Monocyte;
                    Datas.Basophils = i.Basophil;
                    Datas.Platelet = i.Plateletcount;

                   


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
                var i = db.sp_SearchUrinalysis(txtPapin.Text).FirstOrDefault();
                if (i != null)
                {

                    Datas.Color_URINALYSIS = i.Color ?? "-"; ;
                    Datas.Transparency = i.Transparency ?? "-"; ;
                    Datas.pH = i.pH ?? "-"; ;
                    Datas.SpecificGravity = i.SpecificGravity.ToString() ?? "-";
                    Datas.Sugar = i.Glucose.ToString() ?? "-";
                    Datas.Albumin = i.Protein.ToString() ?? "-";
                    Datas.Bacteria = i.Bacteria.ToString() ?? "-";
                    Datas.wbc = i.WhiteBloodCells.ToString() ?? "-";
                    Datas.rbcURINALYSIS = i.RedBloodCells.ToString() ?? "-";
                    Datas.EpithelialCells = i.EpithelialCells.ToString() ?? "-";
                    Datas.MucousThreads = i.MucusThread.ToString() ?? "-";
                    Datas.AmorphousUrates = i.AmorphousUrates.ToString() ?? "-";


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
                var i = db.searchFecalysis(txtPapin.Text).FirstOrDefault();
                if (i != null)
                {

                    Datas.color_FECALYSIS = i.color ?? "-";
                    Datas.Consistency = i.Consistency ?? "-";
                    Datas.rbc = "-";
                    Datas.ova = i.Findings == "OvaParasite" ? "Found":"None Found";

                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }
        public void Search_Radiology(string papain, string type)
        {
            try
            {


                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var i = db.sp_Xray_Detail(papain, type).FirstOrDefault();
                if (i != null)
                {




                    if (type == "XRAY")
                    {

                        Datas.resultXRAY = i.findings;
                        Datas.findingsXRAY = i.impression;
                    }
                    else if (type == "ECG")
                    {
                        Datas.ecgResult = i.findings;
                        Datas.ecgImpresion = i.impression;
                    }
                    else if (type == "UTZ")
                    {
                        Datas.PregnancyTest = i.impression;

                    }



                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }


        public void search_Recomendation()
        {

            try
            {


                var i = db.sp_Landbase_Recomendation(txtPapin.Text).FirstOrDefault();
                if (i != null)
                {





                    txt_AttendingDentist.Text = i.medtech.ToString() ?? "-";
                    lbl_recomendation_cn.Tag = i.cn.ToString();
                    cbo_evaluation.Text = i.Evaluation;
                    txt_remark.Text = i.remarks;
                    txt_recomendation.Text = i.recommendation;
                    txt_result_date.Text = i.result_date.ToString() ?? DateTime.Now.ToShortDateString();
                    Datas.ResultDate = i.result_date.ToString() ?? "-";

                    Datas.classificationA = i.Evaluation;
                    Datas.remarks = i.remarks;
                    Datas.recommendations = i.recommendation;

                    if (i.Evaluation.ToString().Length >= 8)
                    {
                        Datas.EvaluationClassOnly = i.Evaluation.Substring(0, 8).ToString().Replace(":", "");
                        Datas.Evaluation = i.Evaluation.Substring(8).ToString();
                    }
                    else
                    {
                        Datas.EvaluationClassOnly = "";
                        Datas.Evaluation = "";
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }




        }






        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //  Tool.ClearFields(panel43);
        }

        private void clearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //  Tool.ClearFields(panel42);
        }

        private void clearToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //  Tool.ClearFields(panel44);
        }

        private void clearToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //  Tool.ClearFields(panel45);
        }

        private void clearToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //  Tool.ClearFields(panel47);
        }

        private void clearToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //  Tool.ClearFields(panel48);
        }

        private void clearToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //   Tool.ClearFields(panel46);
        }

        private void clearToolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip12_Opening(object sender, CancelEventArgs e)
        {

        }

        private void clearToolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem19_Click(object sender, EventArgs e)
        {

        }






        private void dt_fitness_date_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dt_fitness_date_MouseDown(object sender, MouseEventArgs e)
        {

        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_bday_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DateTime CurrentDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            //    int Age = CurrentDate.Year - Convert.ToDateTime(txt_bday.Text).Year;// dtbday.Value.Year;// Convert.ToDateTime(dtbday.Text).Year;
            //    //this.txt_age.Text = Age.ToString();
            //    if (CurrentDate.Month < Convert.ToDateTime(txt_bday.Text).Month)
            //    {
            //        Age--;
            //    }
            //    else if ((CurrentDate.Month == Convert.ToDateTime(txt_bday.Text).Month) && (CurrentDate.Day < Convert.ToDateTime(txt_bday.Text).Day))
            //    {

            //        Age--;
            //    }
            //    this.txt_age.Text = Age.ToString();
            //}
            //catch
            //{ }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                var list = db.sp_landbase_search("%").ToList();

                foreach (var i in list)
                {


                    landbaseSearckList_model.Add(new landbaseSearckList_Model
                    {

                        cn = i.cn,
                        papin = i.papin,
                        resultID = i.resultid,
                        patientName = i.patientName,
                        resultDate = i.result_date,
                        recommendation = i.recommendation,
                        DateCreated = i.DateCreated.ToString()
                    });
                }


            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }));

            }


        }


        void loadDataAdd()
        {
            try
            {

                var list = db.sp_LandbaseAddList("%").ToList();
                Cursor.Current = Cursors.WaitCursor;
                foreach (var i in list)
                {
                    LandBaseAdd_model.Add(new QueueSearchList_Model
                    {
                        cn = i.cn,
                        papin = i.papin,
                        PatientName = i.patientName,
                        gender = i.gender

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

            this.Invoke(new MethodInvoker(delegate() { loadDataAdd(); }));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //try
            //{
            //    if (!backgroundWorker2.IsBusy)
            //    { backgroundWorker2.RunWorkerAsync(); }

            //    //if ((Application.OpenForms["frm_search_Land"] as frm_search_MedicalExamination) != null)
            //    //{ (Application.OpenForms["frm_search_Land"] as frm_search_MedicalExamination).FillDataGridView(); }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            //}







        }

        private void rb_operational_Y_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_operational_N_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void frm_MedicalExamination_Enter_1(object sender, EventArgs e)
        {
            //landbaseSearckList_model.Clear();
            //LandBaseAdd_model.Clear();
            //if (!backgroundWorker1.IsBusy)
            //{ backgroundWorker1.RunWorkerAsync(); }
        }

        private void txt_nationality_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void cb_skin_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_skin, x_skin);
        }


        private void setProp(CheckBox cb, TextBox txt)
        {
            if (cb.Checked)
            {
                txt.Enabled = false;
                txt.Clear();

            }
            else
            {
                txt.Enabled = true;
            }
        }

        private void cb_neck_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_neck, x_neck);
        }

        private void cb_eyes_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_eyes, x_eyes);
        }

        private void cb_pupils_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_anus, x_anus);
        }

        private void cb_ears_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_ears, x_ears);
        }

        private void cb_nose_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_nose, x_nose);
        }

        private void cb_mought_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_mought, x_mouth);
        }



        private void cb_breast_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_breast, x_breast);
        }

        private void cb_lungs_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_lungs, x_lungs);
        }

        private void cb_heart_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_heart, x_heart);
        }

        private void cb_abdomen_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_abdomen, x_abdomen);
        }

        private void cb_back_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_back, x_back);
        }

        private void cb_anus_CheckedChanged(object sender, EventArgs e)
        {
            //  setProp(cb_anus, x_anus);
        }

        private void cb_gu_CheckedChanged(object sender, EventArgs e)
        {
            // setProp(cb_gu, x_gu);
        }

        private void cb_inguinals_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_inguinals, x_inguinals);
        }

        private void cb_extremeties_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_extremeties, x_extremeties);
        }

        private void cb_reflexes_CheckedChanged(object sender, EventArgs e)
        {
            // setProp(cb_reflexes, x_reflexes);
        }

        private void cb_dental_CheckedChanged(object sender, EventArgs e)
        {
            // setProp(cb_dental, x_dental);
        }

        private void cb_oral_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_oral, txt_oral);

        }

        private void cb_filling_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_filling, txt_filling);
        }

        private void cb_extraction_CheckedChanged(object sender, EventArgs e)
        {
            setProp(cb_extraction, txt_extraction);
        }


        private void cb_ishihar_c_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cb_smoker_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_smoker.Checked == true)
            {
                txt_noofpackday.ReadOnly = false;

            }
            else
            {
                txt_noofpackday.ReadOnly = true;
            }
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void txtdrinknoofyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_drinker_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_drinker.Checked == true)
            {
                txtdrinknoofyear.ReadOnly = false;
            }
            else
            {
                txtdrinknoofyear.ReadOnly = true;
            }
        }

        private void cb_heartDeseas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmd_clearIshihara_Click(object sender, EventArgs e)
        {

            cb_ishihara_u.Checked = false;
            cb_ishihar_c.Checked = false;

        }

        private void txt_hematology_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCurrentDate.Checked)
            {
         
                string d = DateTime.Now.ToString("MMddyyyy");
                txt_result_date.Text = d;
                Console.WriteLine(d);

            }
            else
            {
                txt_result_date.Text = "00000000";
            }
        }
    }
}
