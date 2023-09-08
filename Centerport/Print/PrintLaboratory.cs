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

        public PrintLaboratory()
        {
            InitializeComponent();
        }

        private void PrintLaboratory_Load(object sender, EventArgs e)
        {
            loadUrinalysisReport();
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
               
            }
            else if (tabControl1.SelectedIndex == 4)
            {

            }
            else if (tabControl1.SelectedIndex == 5)
            {
                
            }
            else if (tabControl1.SelectedIndex == 6)
            {

            }
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
    }
}
