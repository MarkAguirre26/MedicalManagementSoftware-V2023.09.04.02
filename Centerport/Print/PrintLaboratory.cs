using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Print
{




    public partial class PrintLaboratory : Form
    {






        public int tabIndex;

        FrmLaboratoryReport frmLaboratoryReport;
        public PrintLaboratory(FrmLaboratoryReport f)
        {
            InitializeComponent();
            frmLaboratoryReport = f;
        }

        private void PrintLaboratory_Load(object sender, EventArgs e)
        {
            loadUrinalysisReport(true);

            tabControl1.SelectedIndex = tabIndex;
        }

        private void loadUrinalysisReport(bool isNewFormat)
        {
            UrinalysisModel urinalysisModel = new UrinalysisModel();
            urinalysisModel = frmLaboratoryReport.prepareTheUrinalysisReportData();
            Urinalysis urinalysisReport = new Urinalysis();

            if (isNewFormat)
            {

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
            else
            {


                Reporting.Write("URINALYSIS_TEMPLATE",
                    new string[] { 
                     "B9",
                    "B10",
                    "G9",
                    "G10",
                    "F18",
                    "F19",
                    "F21",
                    "F22",
                    "F23",
                    "F24",
                    "F26",
                    "F27",
                    "F28",
                    "F29",
                    "F30",
                    "F31",
                    "F32",
                    "C34"},
                    new string[] { 

                      urinalysisModel.Name,
                  urinalysisModel.Company,
                  urinalysisModel.Date,
                  urinalysisModel.AgeSex,
                    urinalysisModel.Color,
                    urinalysisModel.Transparency,
                    urinalysisModel.SpecificGravity,
                    urinalysisModel.pH,
                    urinalysisModel.Glucose,
                    urinalysisModel.Protein,
                    urinalysisModel.WhiteBloodCells,
                    urinalysisModel.RedBloodCells,
                    urinalysisModel.EpithelialCells,
                    urinalysisModel.MucusThreads,
                    urinalysisModel.Bacteria,
                    urinalysisModel.AmorphousUrates,
                    urinalysisModel.AmorphousPhosphates,
                    urinalysisModel.Other
                        });



            }





        }


        private void loadSerologyReport(bool isNewFormat)
        {
            SerologyModel serologyModel = new SerologyModel();
            serologyModel = frmLaboratoryReport.prepareTheSerologyReportData();
            Serology serologyReport = new Serology();

            if (isNewFormat)
            {
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
            else
            {
                Reporting.Write("SEROLOGY_TEMPLATE",
             new string[] { 
                   "B9",
                   "B10",
                   "G9",
                   "G10",
                    "B17",
                    "B18",
                    "F17"
                   },
             new string[] { 
                   serologyModel.Name,
                  serologyModel.Company,
                  serologyModel.Date,
                  serologyModel.AgeSex,
                    serologyModel.Test1,
                    serologyModel.Test1_sub,
                    serologyModel.result1
                        });


            }


        }


        private void loadBloodTypingReport(bool isNewFormat)
        {
            BloodTypingModel bloodTypingModel = new BloodTypingModel();
            bloodTypingModel = frmLaboratoryReport.prepareTheBloodTypingReportData();

            BloodTypingReport bloodTypingReport = new BloodTypingReport();
            if (isNewFormat)
            {
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
            else
            {
                Reporting.Write("BLOOD_TYPING",
             new string[] { 
                   "B9",
                   "B10",
                   "G9",
                   "G10",
                    "B20",
                    "B24",
                    "B21",
                    "B25",
                    "F20",
                    "F24"
                   },
             new string[] { 
                   bloodTypingModel.Name,
                  bloodTypingModel.Company,
                  bloodTypingModel.Date,
                  bloodTypingModel.AgeSex,
                  bloodTypingModel.Test1,
                  bloodTypingModel.Test2,
                  bloodTypingModel.Test1_sub,
                  bloodTypingModel.Test2_sub,
                  bloodTypingModel.result1,
                bloodTypingModel.result3,
               });




            }


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
                frmLaboratoryReport.tabControl1.SelectedIndex = 0;

                loadUrinalysisReport(true);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                frmLaboratoryReport.tabControl1.SelectedIndex = 1;

                loadSerologyReport(true);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                frmLaboratoryReport.tabControl1.SelectedIndex = 2;

                loadHematologyReport(true);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                frmLaboratoryReport.tabControl1.SelectedIndex = 3;

                loadClinicalChemistryReport(true);
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                frmLaboratoryReport.tabControl1.SelectedIndex = 4;

                loadFecalysisReport(true);
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                frmLaboratoryReport.tabControl1.SelectedIndex = 5;

                loadBloodTypingReport(true);
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                frmLaboratoryReport.tabControl1.SelectedIndex = 6;

                loadChemistryReport(true);
            }
        }

        private void loadFecalysisReport(bool isnewFormat)
        {
            FecalysisModel fecalysisModel = new FecalysisModel();
            fecalysisModel = frmLaboratoryReport.prepareTheFecalysisReportData();
            FecalysisReport fecalysisReport = new FecalysisReport();

            if (isnewFormat)
            {
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
            else
            {

                string Ovaparasite = fecalysisModel.Ovaparasite == "OvaParasite" ? "OVA/PARASITE SEEN" : "NO OVA/PARASITE SEEN";
                fecalysisReport.SetParameterValue("Ovaparasite", Ovaparasite);



                Reporting.Write("FECALYSIS_TEMPLATE",
             new string[] { "B9",
                  "B10",
                  "G9",
                  "G10",
                   "F19",
                    "F20",
                    "F22",
                    "F23",
                    "F24",
                    "F25",
                    "F26"
                   },
             new string[] { fecalysisModel.Name,
                  fecalysisModel.Company,
                  fecalysisModel.Date,
                  fecalysisModel.AgeSex,
                   fecalysisModel.Color,
                     fecalysisModel.Consistency,
                 fecalysisModel.Whitebloodcell,
                 fecalysisModel.Redbloodcell,
                 fecalysisModel.Fatglobules,
                 fecalysisModel.Bacteria,
                 Ovaparasite
                        });

            }

        }

        private void loadClinicalChemistryReport(bool isNewFormat)
        {
            ClinicalChemistryModel clinicalChemistryModel = new ClinicalChemistryModel();
            clinicalChemistryModel = frmLaboratoryReport.prepareTheclinicalChemistryReportReportData();
            ClinicalChemistryReport clinicalChemistryReport = new ClinicalChemistryReport();
            if (isNewFormat)
            {
                clinicalChemistryReport.SetParameterValue("Name", clinicalChemistryModel.Name);
                clinicalChemistryReport.SetParameterValue("Company", clinicalChemistryModel.Company);
                clinicalChemistryReport.SetParameterValue("Date", clinicalChemistryModel.Date);
                clinicalChemistryReport.SetParameterValue("AgeSex", clinicalChemistryModel.AgeSex);
                clinicalChemistryReport.SetParameterValue("Headeraddress", clinicalChemistryModel.HeaderAddress);
                clinicalChemistryReport.SetParameterValue("Headercontact", clinicalChemistryModel.HeaderContact);
                clinicalChemistryReport.SetParameterValue("Result1", clinicalChemistryModel.Result1);
                ReportViewer4.ReportSource = clinicalChemistryReport;
            }
            else
            {
                Reporting.Write("HBA1C_TEMPLATE",
              new string[] { 
                   "B9",
                   "B10",
                   "G8",
                   "G9",
                   "D19"
                   
                   },
              new string[] { 
                   clinicalChemistryModel.Name,
                   clinicalChemistryModel.Company,
                  clinicalChemistryModel.Date,
                  clinicalChemistryModel.AgeSex,
                  clinicalChemistryModel.Result1
               });
            }

        }

        private void loadHematologyReport(bool isNewFormat)
        {
            HematologyModel hematologyModel = new HematologyModel();
            hematologyModel = frmLaboratoryReport.prepareTheHematologyReportData();
            HematologyReport hematologyReport = new HematologyReport();

            if (isNewFormat)
            {
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
            else
            {
                Reporting.Write("HEMATOLOGY_TEMPLATE",
               new string[] {
                    "B9",
                    "B10",
                    "G9",
                    "G10",
                    "E20",
                    "E21",
                    "E22",
                    "E23",
                    "E24",
                    "E26",
                    "E27",
                    "E28",
                    "E29",
                    "E30"                 },
               new string[] { 
                     hematologyModel.Name,
                  hematologyModel.Company,
                  hematologyModel.Date,
                  hematologyModel.AgeSex,
                    hematologyModel.Redbloodcells,
                    hematologyModel.Hemoglobin,
                    hematologyModel.Hematocrit,
                    hematologyModel.Plateletcount,
                     hematologyModel.Whitebloodcells,
                    hematologyModel.Neutrophil,
                    hematologyModel.Lymphocyte,
                    hematologyModel.Monocyte,
                    hematologyModel.Eosinophil,
                    hematologyModel.Basophil,
                    hematologyModel.Others,


                        });
            }

        }



        private void loadChemistryReport(bool isNewFormat)
        {
            ChemistryModel chemistryModel = new ChemistryModel();
            chemistryModel = frmLaboratoryReport.prepareTheChemistryReportData();
            ChemistryReport chemistryReport = new ChemistryReport();

            if (isNewFormat)
            {
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
            else
            {


                Reporting.Write("ClinicalChemistry_TEMPLATE",
               new string[] { 
                   "B9",
                   "B10",
                   "G8",
                   "G9",
                  "D19",
                    "D20",
                    "D21",
                    "D22",
                    "D23",
                    "D24",
                    "D25",
                    "D26",
                    "D27",
                    "D28",
                    "D29",
                    "G19",
                    "G20",
                    "G21",
                    "G22",
                    "G23",
                    "G24",
                    "G25",
                    "G26",
                    "G27",
                    "G28",
                    "G29"
                   
                   },

               new string[] { 
                   chemistryModel.Name,
                  chemistryModel.Company,
                  chemistryModel.Date,
                  chemistryModel.AgeSex,
                  chemistryModel.Fbs,
                    chemistryModel.Bun,
                    chemistryModel.Uricacid,
                    chemistryModel.Creatinine,
                    chemistryModel.Cholesterol,
                    chemistryModel.Triglyceride,
                    chemistryModel.Hdl,
                    chemistryModel.Ldl,
                    chemistryModel.Vldl,
                    chemistryModel.Sgptalt,
                    chemistryModel.Sgotast,
                    chemistryModel.FbsRemark,
                    chemistryModel.BunRemark,
                     chemistryModel.UricacidRemark,
                    chemistryModel.CreatinineRemark,
                    chemistryModel.CholesterolRemark,
                    chemistryModel.TriglycerideRemark,
                     chemistryModel.HdlRemark,
                    chemistryModel.LdlRemark,
                    chemistryModel.VldlRemark,
                    chemistryModel.SgptaltRemark,
                    chemistryModel.SgotastRemark
               });
            }





        }

        private void cmdSprintSpreadSheet_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                loadUrinalysisReport(false);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                loadSerologyReport(false);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                loadHematologyReport(false);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                loadClinicalChemistryReport(false);
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                loadFecalysisReport(false);
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                loadBloodTypingReport(false);
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                loadChemistryReport(false);
            }




        }


    }
}
