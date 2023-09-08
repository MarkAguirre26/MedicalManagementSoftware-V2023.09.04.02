using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Print
{




    public partial class PrintLaboratory : Form
    {

        public UrinalysisModel urinalysisModel;
        public SerologyModel serologyModel;
        public HematologyModel hematologyModel;
        public ClinicalChemistryModel clinicalChemistryModel;
        public FecalysisModel fecalysisModel;

        public BloodTypingModel bloodTypingModel;

        public ChemistryModel chemistryModel;

        public int tabIndex;


        public PrintLaboratory()
        {
            InitializeComponent();
        }

        private void PrintLaboratory_Load(object sender, EventArgs e)
        {
            loadUrinalysisReport();

            tabControl1.SelectedIndex = tabIndex;
        }

        private void loadUrinalysisReport()
        {
            Urinalysis urinalysisReport = new Urinalysis();
            ReportViewer1.ReportSource = urinalysisReport;

            urinalysisReport.SetParameterValue("Name", urinalysisModel.Name);
            urinalysisReport.SetParameterValue("Company", urinalysisModel.Company);
            urinalysisReport.SetParameterValue("Date", urinalysisModel.Date);
            urinalysisReport.SetParameterValue("AgeSex", urinalysisModel.AgeSex);
            urinalysisReport.SetParameterValue("Headeraddress", urinalysisModel.HeaderAddress);
            urinalysisReport.SetParameterValue("Headercontact", urinalysisModel.HeaderContact);
            urinalysisReport.SetParameterValue("Color", urinalysisModel.Color);
            urinalysisReport.SetParameterValue("Transparency", urinalysisModel.Transparency);
            urinalysisReport.SetParameterValue("Specificgravity", urinalysisModel.SpecificGravity);
            urinalysisReport.SetParameterValue("Ph", urinalysisModel.pH);
            urinalysisReport.SetParameterValue("Glucose", urinalysisModel.Glucose);
            urinalysisReport.SetParameterValue("Protein", urinalysisModel.Protein);
            urinalysisReport.SetParameterValue("Whitebloodcells", urinalysisModel.WhiteBloodCells);
            urinalysisReport.SetParameterValue("Redbloodcells", urinalysisModel.RedBloodCells);
            urinalysisReport.SetParameterValue("Epithelialcells", urinalysisModel.EpithelialCells);
            urinalysisReport.SetParameterValue("Mucusthreads", urinalysisModel.MucusThreads);
            urinalysisReport.SetParameterValue("Bacteria", urinalysisModel.Bacteria);
            urinalysisReport.SetParameterValue("Amorphousurates", urinalysisModel.AmorphousUrates);
            urinalysisReport.SetParameterValue("Amorphousphosphates", urinalysisModel.AmorphousPhosphates);
            urinalysisReport.SetParameterValue("Other", urinalysisModel.Other);
            ReportViewer1.ReportSource = urinalysisReport;
        }


        private void loadSerologyReport()
        {
            Serology serologyReport = new Serology();
            ReportViewer2.ReportSource = serologyReport;

            serologyReport.SetParameterValue("Name", serologyModel.Name);
            serologyReport.SetParameterValue("Company", serologyModel.Company);
            serologyReport.SetParameterValue("Date", serologyModel.Date);
            serologyReport.SetParameterValue("AgeSex", serologyModel.AgeSex);
            serologyReport.SetParameterValue("Headeraddress", serologyModel.HeaderAddress);
            serologyReport.SetParameterValue("Headercontact", serologyModel.HeaderContact);
            serologyReport.SetParameterValue("Test1", serologyModel.Test1);
            serologyReport.SetParameterValue("Test2", serologyModel.Test2);
            serologyReport.SetParameterValue("Test1_sub", serologyModel.Test1_sub);
            serologyReport.SetParameterValue("Test2_sub", serologyModel.Test2_sub);
            serologyReport.SetParameterValue("result1", serologyModel.result1);
            serologyReport.SetParameterValue("result3", serologyModel.result3);

            ReportViewer2.ReportSource = serologyReport;
        }


        private void loadBloodTypingReport()
        {
            BloodTypingReport bloodTypingReport = new BloodTypingReport();
            ReportViewer6.ReportSource = bloodTypingReport;

            bloodTypingReport.SetParameterValue("Name", bloodTypingModel.Name);
            bloodTypingReport.SetParameterValue("Company", bloodTypingModel.Company);
            bloodTypingReport.SetParameterValue("Date", bloodTypingModel.Date);
            bloodTypingReport.SetParameterValue("AgeSex", bloodTypingModel.AgeSex);
            bloodTypingReport.SetParameterValue("Headeraddress", bloodTypingModel.HeaderAddress);
            bloodTypingReport.SetParameterValue("Headercontact", bloodTypingModel.HeaderContact);
            bloodTypingReport.SetParameterValue("Test1", bloodTypingModel.Test1);
            bloodTypingReport.SetParameterValue("Test2", bloodTypingModel.Test2);
            bloodTypingReport.SetParameterValue("Test1_sub", bloodTypingModel.Test1_sub);
            bloodTypingReport.SetParameterValue("Test2_sub", bloodTypingModel.Test2_sub);
            bloodTypingReport.SetParameterValue("result1", bloodTypingModel.result1);
            bloodTypingReport.SetParameterValue("result3", bloodTypingModel.result3);
            ReportViewer6.ReportSource = bloodTypingReport;
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                ReportViewer1.PrintReport();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                ReportViewer2.PrintReport();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                ReportViewer3.PrintReport();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                ReportViewer4.PrintReport();
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                ReportViewer5.PrintReport();
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                ReportViewer6.PrintReport();
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                ReportViewer7.PrintReport();
            }

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                loadUrinalysisReport();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                loadSerologyReport();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                loadHematologyReport();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                loadClinicalChemistryReport();
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                loadFecalysisReport();
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                loadBloodTypingReport();
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                loadChemistryReport();
            }
        }

        private void loadFecalysisReport()
        {
            FecalysisReport fecalysisReport = new FecalysisReport();
            ReportViewer5.ReportSource = fecalysisReport;
            fecalysisReport.SetParameterValue("Name", fecalysisModel.Name);
            fecalysisReport.SetParameterValue("Company", fecalysisModel.Company);
            fecalysisReport.SetParameterValue("Date", fecalysisModel.Date);
            fecalysisReport.SetParameterValue("AgeSex", fecalysisModel.AgeSex);
            fecalysisReport.SetParameterValue("Headeraddress", fecalysisModel.HeaderAddress);
            fecalysisReport.SetParameterValue("Headercontact", fecalysisModel.HeaderContact);
            fecalysisReport.SetParameterValue("Color", fecalysisModel.Color);
            fecalysisReport.SetParameterValue("Consistency", fecalysisModel.Consistency);
            fecalysisReport.SetParameterValue("Whitebloodcell", fecalysisModel.Whitebloodcell);
            fecalysisReport.SetParameterValue("Redbloodcell", fecalysisModel.Redbloodcell);
            fecalysisReport.SetParameterValue("Fatglobules", fecalysisModel.Fatglobules);
            fecalysisReport.SetParameterValue("Bacteria", fecalysisModel.Bacteria);

            string Ovaparasite = fecalysisModel.Ovaparasite == "OvaParasite" ? "OVA/PARASITE SEEN" : "NO OVA/PARASITE SEEN";
            fecalysisReport.SetParameterValue("Ovaparasite", Ovaparasite);
            ReportViewer5.ReportSource = fecalysisReport;
        }

        private void loadClinicalChemistryReport()
        {
            ClinicalChemistryReport clinicalChemistryReport = new ClinicalChemistryReport();
            ReportViewer4.ReportSource = clinicalChemistryReport;
            clinicalChemistryReport.SetParameterValue("Name", clinicalChemistryModel.Name);
            clinicalChemistryReport.SetParameterValue("Company", clinicalChemistryModel.Company);
            clinicalChemistryReport.SetParameterValue("Date", clinicalChemistryModel.Date);
            clinicalChemistryReport.SetParameterValue("AgeSex", clinicalChemistryModel.AgeSex);
            clinicalChemistryReport.SetParameterValue("Headeraddress", clinicalChemistryModel.HeaderAddress);
            clinicalChemistryReport.SetParameterValue("Headercontact", clinicalChemistryModel.HeaderContact);
            clinicalChemistryReport.SetParameterValue("Result1", clinicalChemistryModel.Result1);
            ReportViewer4.ReportSource = clinicalChemistryReport;
        }

        private void loadHematologyReport()
        {
            HematologyReport hematologyReport = new HematologyReport();
            ReportViewer3.ReportSource = hematologyReport;

            hematologyReport.SetParameterValue("Name", hematologyModel.Name);
            hematologyReport.SetParameterValue("Company", hematologyModel.Company);
            hematologyReport.SetParameterValue("Date", hematologyModel.Date);
            hematologyReport.SetParameterValue("AgeSex", hematologyModel.AgeSex);
            hematologyReport.SetParameterValue("Headeraddress", hematologyModel.HeaderAddress);
            hematologyReport.SetParameterValue("Headercontact", hematologyModel.HeaderContact);

            hematologyReport.SetParameterValue("Redbloodcells", hematologyModel.Redbloodcells);
            hematologyReport.SetParameterValue("Hemoglobin", hematologyModel.Hemoglobin);
            hematologyReport.SetParameterValue("Hematocrit", hematologyModel.Hematocrit);
            hematologyReport.SetParameterValue("Plateletcount", hematologyModel.Plateletcount);
            hematologyReport.SetParameterValue("Whitebloodcells", hematologyModel.Whitebloodcells);
            hematologyReport.SetParameterValue("Neutrophil", hematologyModel.Neutrophil);
            hematologyReport.SetParameterValue("Lymphocyte", hematologyModel.Lymphocyte);
            hematologyReport.SetParameterValue("Monocyte", hematologyModel.Monocyte);
            hematologyReport.SetParameterValue("Eosinophil", hematologyModel.Eosinophil);
            hematologyReport.SetParameterValue("Basophil", hematologyModel.Basophil);
            hematologyReport.SetParameterValue("Others", hematologyModel.Others);
            ReportViewer3.ReportSource = hematologyReport;
        }



        private void loadChemistryReport()
        {
            ChemistryReport chemistryReport = new ChemistryReport();
            ReportViewer7.ReportSource = chemistryReport;

            chemistryReport.SetParameterValue("Name", chemistryModel.Name);
            chemistryReport.SetParameterValue("Company", chemistryModel.Company);
            chemistryReport.SetParameterValue("Date", chemistryModel.Date);
            chemistryReport.SetParameterValue("AgeSex", chemistryModel.AgeSex);
            chemistryReport.SetParameterValue("Headeraddress", chemistryModel.HeaderAddress);
            chemistryReport.SetParameterValue("Headercontact", chemistryModel.HeaderContact);
            chemistryReport.SetParameterValue("Fbs", chemistryModel.Fbs);
            chemistryReport.SetParameterValue("Bun", chemistryModel.Bun);
            chemistryReport.SetParameterValue("Uricacid", chemistryModel.Uricacid);
            chemistryReport.SetParameterValue("Creatinine", chemistryModel.Creatinine);
            chemistryReport.SetParameterValue("Cholesterol", chemistryModel.Cholesterol);
            chemistryReport.SetParameterValue("Triglyceride", chemistryModel.Triglyceride);
            chemistryReport.SetParameterValue("Hdl", chemistryModel.Hdl);
            chemistryReport.SetParameterValue("Ldl", chemistryModel.Ldl);
            chemistryReport.SetParameterValue("Vldl", chemistryModel.Vldl);
            chemistryReport.SetParameterValue("Sgptalt", chemistryModel.Sgptalt);
            chemistryReport.SetParameterValue("Sgotast", chemistryModel.Sgotast);
            chemistryReport.SetParameterValue("FbsRemark", chemistryModel.FbsRemark);
            chemistryReport.SetParameterValue("BunRemark", chemistryModel.BunRemark);
            chemistryReport.SetParameterValue("UricacidRemark", chemistryModel.UricacidRemark);
            chemistryReport.SetParameterValue("CreatinineRemark", chemistryModel.CreatinineRemark);
            chemistryReport.SetParameterValue("CholesterolRemark", chemistryModel.CholesterolRemark);
            chemistryReport.SetParameterValue("TriglycerideRemark", chemistryModel.TriglycerideRemark);
            chemistryReport.SetParameterValue("HdlRemark", chemistryModel.HdlRemark);
            chemistryReport.SetParameterValue("LdlRemark", chemistryModel.LdlRemark);
            chemistryReport.SetParameterValue("VldlRemark", chemistryModel.VldlRemark);
            chemistryReport.SetParameterValue("SgptaltRemark", chemistryModel.SgptaltRemark);
            chemistryReport.SetParameterValue("SgotastRemark", chemistryModel.SgotastRemark);
            ReportViewer7.ReportSource = chemistryReport;
        }


    }
}
