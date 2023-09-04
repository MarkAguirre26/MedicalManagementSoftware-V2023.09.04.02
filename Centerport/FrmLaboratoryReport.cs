using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class FrmLaboratoryReport : Form, MyInter
    {
        //

        Main fmain;

        string ResultId = "";
        string uid = "";
        public string Papin = "";
        public string EVENT_TYPE = "";
        private static string EVENT_SAVE = "Save";
        private static string EVENT_UPDATE = "Update";
        public List<laboratory_search> labsearch = new List<laboratory_search>();

        public static bool NewLabReport;
        public FrmLaboratoryReport(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
        }

        private void FrmLaboratoryReport_Load(object sender, EventArgs e)
        {
            Availability(false);
        }

        private void textBoxNumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }
        public void clearAll()
        {
            //ResultId = Guid.NewGuid().ToString();
            //Papin = Guid.NewGuid().ToString();

            cboColor.Text = "";
            cboTransparent.Text = "";
            cboSpecificGravity.Text = "";
            cboPh.Text = "";
            cboGlucose.Text = "";
            cboProtein.Text = "";
            txtWhiteBloodCells.Text = "";
            txtRedBloodCells.Text = "";
            cboEpi.Text = "";
            cboMucus.Text = "";
            cbobacteria.Text = "";
            cboUrate.Text = "";
            cboPhospate.Text = "";
            txtOthers.Text = "";


            cboTest1.Text = "";
            cboSpecific1.Text = "";
            cboResult1.Text = "";
            cboTest2.Text = "";
            cboSpecific2.Text = "";
            cboResult2.Text = "";


            txtHemaRedBloodCells.Text = "";
            txtHemoglobin.Text = "";
            txtHematocrit.Text = "";
            txtPlateletCount.Text = "";
            txtHemaWhiteBloodCells.Text = "";
            txtNuetrophil.Text = "";
            txtLymphonyte.Text = "";
            txtMonocyte.Text = "";
            txtEosinophil.Text = "";
            txtBasoPhil.Text = "";
            txtOtherHema.Text = "";

            txtHbAcResult.Text = "";

            cboColorFecalysis.Text = "";
            cboCONSISTENCYFecalysis.Text = "";
            txtWhiteBloodCellFecalysis.Text = "";
            txtRedBloodCellsFecalysis.Text = "";
            txtFatFecalysis.Text = "";
            txtBacteriaFecalysis.Text = "";
            //rbOvaParasite.Text = "";
            //rbNoOVaParasite.Text = "";

            txtFbs.Text = "";
            txtBun.Text = "";
            txtUricAcid.Text = "";
            txtCreatinine.Text = "";
            txtCholesterol.Text = "";
            txtTriglyceride.Text = "";
            txtHdl.Text = "";
            txtLdl.Text = "";
            txtVldl.Text = "";
            txtSgpt.Text = "";
            txtSgot.Text = "";
            txtFbsRemark.Text = "";
            txtBunRemark.Text = "";
            txtUricAcidRemark.Text = "";
            txtCreatinineRemark.Text = "";
            txtCholesterolRemark.Text = "";
            txtTriglycerideRemark.Text = "";
            txtHdlRemark.Text = "";
            txtLdlRemark.Text = "";
            txtVldlRemark.Text = "";
            txtSgptRemark.Text = "";
            txtSgotRemark.Text = "";


            cboBloodTypingTest1.Text = "";
            cboBloodTypingSpecific1.Text = "";
            cboBloodTypingResult1.Text = "";
            cboBloodTypingTest2.Text = "";
            cboBloodTypingSpecific2.Text = "";
            cboBloodTypingResult2.Text = "";

            //
        }

   public void WriteParametersToFile(string functionName, params object[] parameters)
{

    string fileName = "logs/"+Papin+"_"+functionName+".txt";

    
    using (StreamWriter writer = new StreamWriter(fileName))
    {
        writer.WriteLine("Function Name: "+functionName);
        writer.WriteLine("Parameters:");
        
        foreach (object parameter in parameters)
        {
            writer.WriteLine(parameter.ToString());
        }
    }
}

        void UrinalysisPROCESS()
        {
            WriteParametersToFile("UrinalysisPROCESS", ResultId, Papin, cboColor.Text, cboTransparent.Text, cboSpecificGravity.Text, cboPh.Text, cboGlucose.Text, cboProtein.Text, txtWhiteBloodCells.Text, txtRedBloodCells.Text, cboEpi.Text, cboMucus.Text, cbobacteria.Text, cboUrate.Text, cboPhospate.Text, txtOthers.Text, dt_urinalysis.Value.ToShortDateString());

            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            db.sp_UrinalysisPROCESS(ResultId, Papin, cboColor.Text, cboTransparent.Text, cboSpecificGravity.Text, cboPh.Text, cboGlucose.Text, cboProtein.Text, txtWhiteBloodCells.Text, txtRedBloodCells.Text, cboEpi.Text, cboMucus.Text, cbobacteria.Text, cboUrate.Text, cboPhospate.Text, txtOthers.Text, dt_urinalysis.Value.ToShortDateString());

        }



        void SerologyPROCESS()
        {
            WriteParametersToFile("SerologyPROCESS", ResultId, Papin, cboTest1.Text, cboSpecific1.Text, cboResult1.Text, cboTest2.Text, cboSpecific2.Text, cboResult2.Text, dt_serology.Value.ToShortDateString());



            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            db.sp_SerologyPROCESS(ResultId, Papin, cboTest1.Text, cboSpecific1.Text, cboResult1.Text, cboTest2.Text, cboSpecific2.Text, cboResult2.Text, dt_serology.Value.ToShortDateString());
        }

        void HematologyPROCESS()
        {

            WriteParametersToFile("HematologyPROCESS", ResultId, Papin, txtHemaRedBloodCells.Text, txtHemoglobin.Text, txtHematocrit.Text, txtPlateletCount.Text, txtHemaWhiteBloodCells.Text, txtNuetrophil.Text, txtLymphonyte.Text, txtMonocyte.Text, txtEosinophil.Text, txtOtherHema.Text, txtBasoPhil.Text, dt_hematology.Value.ToShortDateString());


            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            db.sp_HematologyPROCESS(ResultId, Papin, txtHemaRedBloodCells.Text, txtHemoglobin.Text, txtHematocrit.Text, txtPlateletCount.Text, txtHemaWhiteBloodCells.Text, txtNuetrophil.Text, txtLymphonyte.Text, txtMonocyte.Text, txtEosinophil.Text, txtOtherHema.Text, txtBasoPhil.Text, dt_hematology.Value.ToShortDateString());
        }

        void HbAOnecPROCESS()
        {
            WriteParametersToFile("HbAOnecPROCESS", ResultId, Papin, txtHbAcResult.Text, dt_hba.Value.ToShortDateString());
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            db.sp_HbAOnecPROCESS(ResultId, Papin, txtHbAcResult.Text, dt_hba.Value.ToShortDateString());
        }



        void FecalysisPROCESS()
        {
            string remark = "";

            if (rbOvaParasite.Checked == true)
            {
                remark = "OvaParasite";
            }
            else if (rbNoOVaParasite.Checked == true)
            {
                remark = "NoOvaParasite";
            }

            WriteParametersToFile("FecalysisPROCESS", ResultId, Papin, cboColorFecalysis.Text, cboCONSISTENCYFecalysis.Text, txtWhiteBloodCellFecalysis.Text, txtRedBloodCellsFecalysis.Text, txtFatFecalysis.Text, txtBacteriaFecalysis.Text, remark, dt_fecalysis.Value.ToShortDateString());

            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            db.sp_FecalysisPROCESS(ResultId, Papin, cboColorFecalysis.Text, cboCONSISTENCYFecalysis.Text, txtWhiteBloodCellFecalysis.Text, txtRedBloodCellsFecalysis.Text, txtFatFecalysis.Text, txtBacteriaFecalysis.Text, remark, dt_fecalysis.Value.ToShortDateString());
        }

        void ClinicalChemistryPROCESS()
        {

            WriteParametersToFile("ClinicalChemistryPROCESS", ResultId,
                Papin,
                txtFbs.Text,
                txtBun.Text,
                txtUricAcid.Text,
                txtCreatinine.Text,
                txtCholesterol.Text,
                txtTriglyceride.Text,
                txtHdl.Text,
                txtLdl.Text,
                txtVldl.Text,
                txtSgpt.Text,
                txtSgot.Text,
                txtFbsRemark.Text,
                txtBunRemark.Text,
                txtUricAcidRemark.Text,
                txtCreatinineRemark.Text,
                txtCholesterolRemark.Text,
                txtTriglycerideRemark.Text,
                txtHdlRemark.Text,
                txtLdlRemark.Text,
                txtVldlRemark.Text,
                txtSgptRemark.Text,
                txtSgotRemark.Text,
                dt_chem.Value.ToShortDateString());

            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            db.sp_ClinicalChemistryPROCESS(
                ResultId,
                Papin,
                txtFbs.Text,
                txtBun.Text,
                txtUricAcid.Text,
                txtCreatinine.Text,
                txtCholesterol.Text,
                txtTriglyceride.Text,
                txtHdl.Text,
                txtLdl.Text,
                txtVldl.Text,
                txtSgpt.Text,
                txtSgot.Text,
                txtFbsRemark.Text,
                txtBunRemark.Text,
                txtUricAcidRemark.Text,
                txtCreatinineRemark.Text,
                txtCholesterolRemark.Text,
                txtTriglycerideRemark.Text,
                txtHdlRemark.Text,
                txtLdlRemark.Text,
                txtVldlRemark.Text,
                txtSgptRemark.Text,
                txtSgotRemark.Text,
                dt_chem.Value.ToShortDateString());
        }


        public void Search_Patient()
        {
            try
            {

                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var i = db.lab_patient(Papin).FirstOrDefault();


                txtName.Text = i.latname.ToString() + ", " + i.firstname.ToString() + " " + i.middlename.ToString();
                txtAgency.Text = i.employer ?? "-";

           

                gender.Text = i.gender.ToString() ?? "-";




            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


            //
        }
        void BloodTypingPROCESS()
        {


            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            db.sp_BloodTypingPROCESS(ResultId,
                Papin,
                cboBloodTypingTest1.Text,
                cboBloodTypingSpecific1.Text,
                cboBloodTypingResult1.Text,
                cboBloodTypingTest2.Text,
                cboBloodTypingSpecific2.Text,
                cboBloodTypingResult2.Text,
                dt_BloodTyping.Value.ToShortDateString());
        }



    



        public void Availability(bool bl)
        {
         

            //URINALYSIS
           
                cboColor.Enabled = bl;
                cboTransparent.Enabled = bl;
                cboSpecificGravity.Enabled = bl;
                cboPh.Enabled = bl;
                cboGlucose.Enabled = bl;
                cboProtein.Enabled = bl;
                txtWhiteBloodCells.Enabled = bl;
                txtRedBloodCells.Enabled = bl;
                cboEpi.Enabled = bl;
                cboMucus.Enabled = bl;
                cbobacteria.Enabled = bl;
                cboUrate.Enabled = bl;
                cboPhospate.Enabled = bl;
                txtOthers.Enabled = bl;


                //tabControl1.TabPages.Insert(1, tabPageUrinalysis);
                //tabControl1.TabPages.Remove(tabPageSerology);
                //tabControl1.TabPages.Remove(tabPageHematology);
                //tabControl1.TabPages.Remove(tabPageHbOneC);
                //tabControl1.TabPages.Remove(tabPageFecalysis);
                //tabControl1.TabPages.Remove(tabPageBloodTyping);
                //tabControl1.TabPages.Remove(tabPageChem);


                cboTest1.Enabled = bl;
                cboSpecific1.Enabled = bl;
                cboTest2.Enabled = bl;
                cboSpecific2.Enabled = bl;
                cboResult1.Enabled = bl;
                cboResult2.Enabled = bl;

                //tabControl1.TabPages.Remove(tabPageUrinalysis);
                //tabControl1.TabPages.Insert(1,tabPageSerology);
                //tabControl1.TabPages.Remove(tabPageHematology);
                //tabControl1.TabPages.Remove(tabPageHbOneC);
                //tabControl1.TabPages.Remove(tabPageFecalysis);
                //tabControl1.TabPages.Remove(tabPageBloodTyping);
                //tabControl1.TabPages.Remove(tabPageChem);


           
                txtHemaRedBloodCells.Enabled = bl;
                txtHemoglobin.Enabled = bl;
                txtHematocrit.Enabled = bl;
                txtPlateletCount.Enabled = bl;
                txtHemaWhiteBloodCells.Enabled = bl;
                txtNuetrophil.Enabled = bl;
                txtLymphonyte.Enabled = bl;
                txtMonocyte.Enabled = bl;
                txtEosinophil.Enabled = bl;
                txtBasoPhil.Enabled = bl;
                txtOtherHema.Enabled = bl;
            
                txtHbAcResult.Enabled = bl;
           
                cboColorFecalysis.Enabled = bl;
                cboCONSISTENCYFecalysis.Enabled = bl;
                txtWhiteBloodCellFecalysis.Enabled = bl;
                txtRedBloodCellsFecalysis.Enabled = bl;
                txtFatFecalysis.Enabled = bl;
                txtBacteriaFecalysis.Enabled = bl;
                rbOvaParasite.Enabled = bl;
                rbNoOVaParasite.Enabled = bl;
          
                cboBloodTypingTest1.Enabled = bl;
                cboBloodTypingSpecific1.Enabled = bl;
                cboBloodTypingTest2.Enabled = bl;
                cboBloodTypingSpecific2.Enabled = bl;
                cboBloodTypingResult1.Enabled = bl;
                cboBloodTypingResult2.Enabled = bl;
            
                txtFbs.Enabled = bl;
                txtBun.Enabled = bl;
                txtUricAcid.Enabled = bl;
                txtCreatinine.Enabled = bl;
                txtCholesterol.Enabled = bl;
                txtTriglyceride.Enabled = bl;
                txtHdl.Enabled = bl;
                txtLdl.Enabled = bl;
                txtVldl.Enabled = bl;
                txtSgpt.Enabled = bl;
                txtSgot.Enabled = bl;
                txtFbsRemark.Enabled = bl;
                txtBunRemark.Enabled = bl;
                txtUricAcidRemark.Enabled = bl;
                txtCreatinineRemark.Enabled = bl;
                txtCholesterolRemark.Enabled = bl;
                txtTriglycerideRemark.Enabled = bl;
                txtHdlRemark.Enabled = bl;
                txtLdlRemark.Enabled = bl;
                txtVldlRemark.Enabled = bl;
                txtSgptRemark.Enabled = bl;
                txtSgotRemark.Enabled = bl;
            


        }

        public void ClearAll()
        {
          
            Console.WriteLine("CLear All");

        }


     
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (fmain.ts_edit_lab.Enabled == false)
            //{
            //    Availability(false);
            //}
            //else
            //{
            //    Availability(true);
            //}



            //if (fmain.ts_cancel_labReport.Enabled == true)
            //{
            //    //Search();
            //    fmain.ts_edit_labReport.Enabled = true;
            //    fmain.ts_save_labReport.Enabled = false;
            //    fmain.ts_search_labReport.Enabled = true;
            //    fmain.ts_print_labReport.Enabled = true;
            //    fmain.ts_cancel_labReport.Enabled = false;
            //}

            //Save();



        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }



        public void New()
        {
            tabPageUrinalysis.Tag = "";
            tabPageSerology.Tag = "";
            tabPageHematology.Tag = "";
            tabPageHbOneC.Tag = "";
            tabPageFecalysis.Tag = "";
            tabPageChem.Tag = "";
            tabPageBloodTyping.Tag = "";
        }

        void searchUrinalysis()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.sp_SearchUrinalysis(Papin).FirstOrDefault();
            if (item != null)
            {
                tabPageUrinalysis.Tag = item.RecId;
                cboColor.Text = item.Color;
                cboTransparent.Text = item.Transparency;
                cboSpecificGravity.Text = item.SpecificGravity;
                cboPh.Text = item.pH;
                cboGlucose.Text = item.Glucose;
                cboProtein.Text = item.Protein;
                txtWhiteBloodCells.Text = item.WhiteBloodCells;
                txtRedBloodCells.Text = item.RedBloodCells;
                cboEpi.Text = item.EpithelialCells;
                cboMucus.Text = item.MucusThread;

                cbobacteria.Text = item.Bacteria;
                cboUrate.Text = item.AmorphousUrates;
                cboPhospate.Text = item.AmorphousPhospates;
                txtOthers.Text = item.Others;


            }

        }
        void searchSerology()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchSerology(Papin).FirstOrDefault();
            if (item != null)
            {
                tabPageSerology.Tag = item.RecId;
                cboTest1.Text = item.Test1;
                cboTest2.Text = item.Test2;
                cboSpecific1.Text = item.Specific1;
                cboSpecific2.Text = item.Specific2;
                cboResult1.Text = item.Result1;
                cboResult2.Text = item.Result2;
            }

        }
        void searchHematology()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchHematology(Papin).FirstOrDefault();
            if (item != null)
            {
                tabPageHematology.Tag = item.RecId;
                txtHemaRedBloodCells.Text = item.Redbloodcells;
                txtHemaWhiteBloodCells.Text = item.Whitebloodcells;
                txtHematocrit.Text = item.Hematocrit;
                txtPlateletCount.Text = item.Plateletcount;
                txtHemoglobin.Text = item.Hemoglobin;
                txtNuetrophil.Text = item.Neutrophil;
                txtLymphonyte.Text = item.Lymphocyte;
                txtMonocyte.Text = item.Monocyte;
                txtEosinophil.Text = item.Eosinophil;
                txtBasoPhil.Text = item.Basophil;
                txtOtherHema.Text = item.Other;
            }

        }
        void searchHbOneC()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchHbOneC(Papin).FirstOrDefault();
            if (item != null)
            {
                tabPageHbOneC.Tag = item.RecId;
                txtHbAcResult.Text = item.HBA1C;
            }


        }
        void searchFecalysis()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchFecalysis(Papin).FirstOrDefault();
            if (item != null)
            {
                tabPageFecalysis.Tag = item.RecId;
                cboColorFecalysis.Text = item.color;
                cboCONSISTENCYFecalysis.Text = item.Consistency;
                txtWhiteBloodCellFecalysis.Text = item.Whitebloodcell;
                txtRedBloodCellsFecalysis.Text = item.Redbloodcell;
                txtFatFecalysis.Text = item.Fatglobules;
                txtBacteriaFecalysis.Text = item.Bacteria;
                if (item.Findings == "OvaParasite" || item.Findings == "Found")
                {
                    rbOvaParasite.Checked = true;
                }
                else
                {
                    rbNoOVaParasite.Checked = true;
                }
            }

        }
        void searchChem()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchChem(Papin).FirstOrDefault();
            if (item != null)
            {
                tabPageChem.Tag = item.RecId;
                txtFbs.Text = item.Fbs;
                txtFbsRemark.Text = item.Fbs_Remark;

                txtBun.Text = item.Bun;
                txtBunRemark.Text = item.Bun_Remark;

                txtUricAcid.Text = item.UricAcid;
                txtUricAcidRemark.Text = item.UricAcid_Remark;

                txtCholesterol.Text = item.Cholesterol;
                txtCholesterolRemark.Text = item.Cholesterol_Remark;

                txtTriglyceride.Text = item.Triglyceride;
                txtTriglycerideRemark.Text = item.Triglyceride_Remark;


                txtCreatinine.Text = item.Creatinine;
                txtCreatinineRemark.Text = item.Creatinine_Remark;


                txtHdl.Text = item.Hdl;
                txtHdlRemark.Text = item.Hdl_Remark;

                txtLdl.Text = item.Ldl;
                txtLdlRemark.Text = item.Ldl_Remark;

                txtVldl.Text = item.Vldl;
                txtVldlRemark.Text = item.Vldl_Remark;

                txtSgpt.Text = item.Sgpt;
                txtSgptRemark.Text = item.Sgpt_Remark;

                txtSgot.Text = item.Sgot;
                txtSgotRemark.Text = item.Sgot_Remark;


            }



        }
        void searchBloodTyping()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchBloodTyping(Papin).FirstOrDefault();
            if (item != null)
            {
                tabPageBloodTyping.Tag = item.RecId;

                cboBloodTypingTest1.Text = item.Test1;
                cboBloodTypingTest2.Text = item.Test2;

                cboBloodTypingSpecific1.Text = item.Specific1;
                cboBloodTypingSpecific2.Text = item.Specific2;

                cboBloodTypingResult1.Text = item.Result1;
                cboBloodTypingResult2.Text = item.Result2;




            }

        }

        public void Save()
        {


            UrinalysisPROCESS();
            SerologyPROCESS();
            HematologyPROCESS();
            HbAOnecPROCESS();
            FecalysisPROCESS();
            ClinicalChemistryPROCESS();
            BloodTypingPROCESS();

            
            Availability(false);


            fmain.ts_edit_labReport.Enabled = true;
            fmain.ts_save_labReport.Enabled = false;
            fmain.ts_search_labReport.Enabled = true;
            fmain.ts_print_labReport.Enabled = true;
            fmain.ts_cancel_labReport.Enabled = false;

        }

        private void triggerReport()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            db.TriggerReport(Papin);
        }

        public void Edit()
        {



            Availability(true);

            fmain.ts_edit_labReport.Enabled = false;
            fmain.ts_save_labReport.Enabled = true;
            fmain.ts_cancel_labReport.Enabled = true;
            fmain.ts_search_labReport.Enabled = false;
            fmain.ts_print_labReport.Enabled = false;


            if (tabControl1.SelectedTab == tabPageUrinalysis)
            {
                

             


            }
            else if (tabControl1.SelectedTab == tabPageSerology)
            {
               



            }
            else if (tabControl1.SelectedTab == tabPageHematology)
            {
              
            }
            else if (tabControl1.SelectedTab == tabPageHbOneC)
            {
                
            }
            else if (tabControl1.SelectedTab == tabPageFecalysis)
            {
               
            }
            else if (tabControl1.SelectedTab == tabPageBloodTyping)
            {
            }
            else if (tabControl1.SelectedTab == tabPageChem)
            {
             
            }




        }

        public void Delete()
        {
            MessageBox.Show("Delete");
        }

        public void Cancel()
        {

            Availability(false);
            fmain.ts_edit_labReport.Enabled = true;
            fmain.ts_save_labReport.Enabled = false;
            fmain.ts_cancel_labReport.Enabled = false;
            fmain.ts_search_labReport.Enabled = true;
            fmain.ts_print_labReport.Enabled = true;
        }

        public void Print()
        {
            FrmLapPrints f = new FrmLapPrints();
            f.Name = txtName.Text;
            f.Company = txtAgency.Text;
            f.AgeSex = gender.Text;
            f.ResultDate_Urinalysis = dt_urinalysis.Text;
            f.ResultDate_Serology = dt_serology.Text;
            f.ResultDate_Hematolgy = dt_hematology.Text;
            f.ResultDate_hba1c = dt_hba.Text;
            f.ResultDate_Fecalysis = dt_fecalysis.Text;
            f.ResultDate_BloodTyping = dt_BloodTyping.Text;
            f.ResultDate_ClinicalChem = dt_BloodTyping.Text;
            f.Tag = Papin;
            f.ShowDialog();
        }

        public void Search()
        {
            clearAll();

            searchUrinalysis();
            searchSerology();
            searchHematology();
            searchHbOneC();
            searchFecalysis();
            searchChem();
            searchBloodTyping();
        }

        private void FrmLaboratoryReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fmain.ts_cancel_labReport.Enabled == true)
                { Cancel(); }
                else
                { this.Close(); }

            }
            else if (e.KeyCode == Keys.Add && e.Modifiers == Keys.Control)
            {

            }

            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_save_labReport.Enabled == true)
                {
                    Save();

                }

            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_print_labReport.Enabled == true)
                {
                    Print();
                }
            }
            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {

                if (fmain.ts_search_labReport.Enabled == true)
                {
                    fmain.Search_Lab("LAB");
                 
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (fmain.ts_edit_labReport.Enabled == true)
                {
                    Edit();

                }
            }
            else if (e.KeyCode == Keys.Delete)
            {


            }
            //else if(e.KeyCode == Keys.F5){
            //    Search();
            //}
        }

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

        private void txtHemaRedBloodCells_TextChanged(object sender, EventArgs e)
        {
            if (txtHemaRedBloodCells.Text != "." && txtHemaRedBloodCells.Text != "")
            {
                txtHemaRedBloodCells.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtHemaRedBloodCells.Text) < 4.0 || Convert.ToDouble(txtHemaRedBloodCells.Text) > 5.4)
                {
                    txtHemaRedBloodCells.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtHemoglobin_TextChanged(object sender, EventArgs e)
        {
            if (txtHemoglobin.Text != "." && txtHemoglobin.Text != "")
            {
                txtHemoglobin.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtHemoglobin.Text) < 120 || Convert.ToDouble(txtHemoglobin.Text) > 160)
                {
                    txtHemoglobin.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtHematocrit_TextChanged(object sender, EventArgs e)
        {
            if (txtHematocrit.Text != "." && txtHematocrit.Text != "")
            {
                txtHematocrit.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtHematocrit.Text) < 0.36 || Convert.ToDouble(txtHematocrit.Text) > 0.46)
                {
                    txtHematocrit.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtPlateletCount_TextChanged(object sender, EventArgs e)
        {
            if (txtPlateletCount.Text != "." && txtPlateletCount.Text != "")
            {
                txtPlateletCount.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtPlateletCount.Text) < 150 || Convert.ToDouble(txtPlateletCount.Text) > 450)
                {
                    txtPlateletCount.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtHemaWhiteBloodCells_TextChanged(object sender, EventArgs e)
        {
            if (txtHemaWhiteBloodCells.Text != "." && txtHemaWhiteBloodCells.Text != "")
            {
                txtHemaWhiteBloodCells.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtHemaWhiteBloodCells.Text) < 5 || Convert.ToDouble(txtHemaWhiteBloodCells.Text) > 10)
                {
                    txtHemaWhiteBloodCells.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtNuetrophil_TextChanged(object sender, EventArgs e)
        {
            if (txtNuetrophil.Text != "." && txtNuetrophil.Text != "")
            {
                txtNuetrophil.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtNuetrophil.Text) < 0.43 || Convert.ToDouble(txtNuetrophil.Text) > 0.73)
                {
                    txtNuetrophil.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtLymphonyte_TextChanged(object sender, EventArgs e)
        {
            if (txtNuetrophil.Text != "." && txtNuetrophil.Text != "")
            {
                txtLymphonyte.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtNuetrophil.Text) < 0.19 || Convert.ToDouble(txtNuetrophil.Text) > 0.48)
                {
                    txtLymphonyte.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtMonocyte_TextChanged(object sender, EventArgs e)
        {
            if (txtMonocyte.Text != "." && txtMonocyte.Text != "")
            {

                txtMonocyte.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtMonocyte.Text) < 0.04 || Convert.ToDouble(txtMonocyte.Text) > 0.12)
                {
                    txtMonocyte.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
        //

        private void txtEosinophil_TextChanged(object sender, EventArgs e)
        {
            if (txtEosinophil.Text != "." && txtEosinophil.Text != "")
            {
                txtEosinophil.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtEosinophil.Text) < 0.01 || Convert.ToDouble(txtEosinophil.Text) > 0.06)
                {
                    txtEosinophil.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtBasoPhil_TextChanged(object sender, EventArgs e)
        {
            if (txtBasoPhil.Text != "." && txtBasoPhil.Text != "")
            {
                txtBasoPhil.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtBasoPhil.Text) < 0.0 || Convert.ToDouble(txtBasoPhil.Text) > 0.01)
                {
                    txtBasoPhil.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtFbs_TextChanged(object sender, EventArgs e)
        {

            if (txtFbs.Text != "." && txtFbs.Text != "")
            {
                txtFbs.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtFbs.Text) < 70 || Convert.ToDouble(txtFbs.Text) > 115)
                {
                    txtFbs.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtBun_TextChanged(object sender, EventArgs e)
        {
            if (txtBun.Text != "." && txtBun.Text != "")
            {

                txtBun.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtBun.Text) < 4.26 || Convert.ToDouble(txtBun.Text) > 23.25)
                {
                    txtBun.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtUricAcid_TextChanged(object sender, EventArgs e)
        {
            if (txtUricAcid.Text != "." && txtUricAcid.Text != "")
            {

                txtUricAcid.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtUricAcid.Text) < 2.3 || Convert.ToDouble(txtUricAcid.Text) > 6.72)
                {
                    txtUricAcid.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtCreatinine_TextChanged(object sender, EventArgs e)
        {
            if (txtCreatinine.Text != "." && txtCreatinine.Text != "")
            {
                txtCreatinine.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtCreatinine.Text) < 0.49 || Convert.ToDouble(txtCreatinine.Text) > 1.39)
                {
                    txtCreatinine.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtCholesterol_TextChanged(object sender, EventArgs e)
        {
            if (txtCholesterol.Text != "." && txtCholesterol.Text != "")
            {
                txtCholesterol.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtCholesterol.Text) < 0 || Convert.ToDouble(txtCholesterol.Text) > 200)
                {
                    txtCholesterol.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtTriglyceride_TextChanged(object sender, EventArgs e)
        {
            if (txtTriglyceride.Text != "." && txtTriglyceride.Text != "")
            {
                txtTriglyceride.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtTriglyceride.Text) < 65 || Convert.ToDouble(txtTriglyceride.Text) > 150)
                {
                    txtTriglyceride.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtHdl_TextChanged(object sender, EventArgs e)
        {
            if (txtHdl.Text != "." && txtHdl.Text != "")
            {
                txtHdl.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtHdl.Text) < 29 || Convert.ToDouble(txtHdl.Text) > 87)
                {
                    txtHdl.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtLdl_TextChanged(object sender, EventArgs e)
        {
            if (txtLdl.Text != "." && txtLdl.Text != "")
            {
                txtLdl.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtLdl.Text) < 131)
                {
                    txtLdl.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtVldl_TextChanged(object sender, EventArgs e)
        {
            if (txtVldl.Text != "." && txtVldl.Text != "")
            {
                txtVldl.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtVldl.Text) < 30)
                {
                    txtVldl.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtSgpt_TextChanged(object sender, EventArgs e)
        {
            if (txtSgpt.Text != "." && txtSgpt.Text != "")
            {
                txtSgpt.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtSgpt.Text) < 0 || Convert.ToDouble(txtSgpt.Text) > 41)
                {
                    txtSgpt.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtSgot_TextChanged(object sender, EventArgs e)
        {

            if (txtSgot.Text != "." && txtSgot.Text != "")
            {
                txtSgot.ForeColor = System.Drawing.Color.Black;
                if (Convert.ToDouble(txtSgot.Text) < 0 || Convert.ToDouble(txtSgot.Text) > 40)
                {
                    txtSgot.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
