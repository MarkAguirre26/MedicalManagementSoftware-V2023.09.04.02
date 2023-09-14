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
    public partial class FrmRadiographicalReport : Form
    {

        public RadiographicalModel radiographicalModel;
        public FrmRadiographicalReport()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            ReportViewer1.PrintReport();
        }

        private void FrmRadiographicalReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            RadiographicalReport radiographicalReport = new RadiographicalReport();
            ReportViewer1.ReportSource = radiographicalReport;
            radiographicalReport.SetParameterValue("Name", radiographicalModel.Name);
            radiographicalReport.SetParameterValue("Company", radiographicalModel.Company);
            radiographicalReport.SetParameterValue("Date", radiographicalModel.Date);
            radiographicalReport.SetParameterValue("AgeSex", radiographicalModel.AgeSex);
            radiographicalReport.SetParameterValue("Headeraddress", radiographicalModel.HeaderAddress);
            radiographicalReport.SetParameterValue("Headercontact", radiographicalModel.HeaderContact);
            radiographicalReport.SetParameterValue("result1", radiographicalModel.result1);
            radiographicalReport.SetParameterValue("result1", radiographicalModel.result1);
            radiographicalReport.SetParameterValue("result3", radiographicalModel.result3);
            radiographicalReport.SetParameterValue("CaseNo", radiographicalModel.CaseNo);
            radiographicalReport.SetParameterValue("ReportTitle", radiographicalModel.ReportTitle);
            radiographicalReport.SetParameterValue("Examination", radiographicalModel.Examination);
            radiographicalReport.SetParameterValue("Address2", radiographicalModel.Address2);
            ReportViewer1.ReportSource = radiographicalReport;

        }
    }
}
