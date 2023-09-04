using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedicalManagement
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (cboReportType.SelectedItem.ToString() == "Weekly")
            {
                getReportWeekly(cboReportCategory.SelectedIndex);
            }
            else
            {
                getReportMonthly(cboReportCategory.SelectedIndex);
            }
           
        }



        //private void CreateChart()
        //{

        //    if (comboBox1.SelectedIndex != -1 && cboFilterCategory.SelectedIndex != -1)
        //    {
        //        //most profitable package / laboratory test.

        //        if (comboBox1.SelectedIndex == 1)
        //        {


        //            int dayDifference = CalculateDayDifference(dtFrom.Value, dtTo.Value);

        //            if (dayDifference >= 7)
        //            {
        //                MessageBox.Show("Day covered for lab Test Delay Report is Max of 7 day only", "Lab Test Delay Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        //            }
        //            else
        //            {
        //                LabTestDelay();
        //            }


        //        }
        //        else
        //        {





        //            if (cboFilterCategory.SelectedIndex == 0)
        //            {



        //                int dayDifference = CalculateDayDifference(dtFrom.Value, dtTo.Value);

        //                if (dayDifference >= 3)
        //                {
        //                    DialogResult dialogResult = MessageBox.Show("Day difference are more than 3 day, Report display may affect, Would you like to continue?", "Daily Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //                    if (dialogResult == DialogResult.Yes)
        //                    {
        //                        selectReport(comboBox1.SelectedIndex);
        //                    }

        //                }
        //                else
        //                {
        //                    selectReport(comboBox1.SelectedIndex);
        //                }



        //            }
        //            else
        //            {
        //                selectReport(comboBox1.SelectedIndex);

        //            }

        //        }



        //    }




        //}

        private void LabTestDelayWeekly()
        {


           
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

            var packages = db.sp_ChartDelay(cboLabTest.Text, cboMonths.SelectedIndex + 1, cboWeekNumber.Text).ToList();

            this.chartReport.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chartReport.Titles.Clear();
            this.chartReport.Titles.Add(cboReportCategory.SelectedItem.ToString());
            //

            chartReport.Series.Clear();
            chartReport.Series.Add("Count");





            foreach (var p in packages)
            {
                chartReport.Series["Count"].Points.AddXY(p.DateResult, p.Count);


            }
            




        }


        private void LabTestDelayMonthly()
        {



            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

            var packages = db.sp_ChartDelayMonthly(cboLabTest.Text, Convert.ToInt32(cboYear.SelectedItem.ToString())).ToList();

            this.chartReport.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chartReport.Titles.Clear();
            this.chartReport.Titles.Add(cboReportCategory.SelectedItem.ToString());
            //

            chartReport.Series.Clear();
            chartReport.Series.Add("Count");





            foreach (var p in packages)
            {
                chartReport.Series["Count"].Points.AddXY(p.YearMonth, p.Count);


            }





        }



        int CalculateDayDifference(DateTime startDate, DateTime endDate)
        {
            TimeSpan difference = endDate - startDate;
            return (int)difference.TotalDays;
        }



        void getReportWeekly(int index)
        {
            //
            //most profitable package / laboratory test.
            if (index.Equals(0) || index.Equals(2))  //MAX NUMBER OF CLIENTS
            {
                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

                var packages = db.sp_ChartReport(cboMonths.SelectedIndex + 1, Convert.ToInt32(cboWeekNumber.SelectedItem)).ToList();

                this.chartReport.Palette = ChartColorPalette.SeaGreen;

                // Set title.
                this.chartReport.Titles.Clear();
                this.chartReport.Titles.Add(cboReportCategory.SelectedItem.ToString());

                chartReport.Series.Clear();
                chartReport.Series.Add("Urinalysis");
                chartReport.Series.Add("Serology");
                chartReport.Series.Add("Hematology");
                chartReport.Series.Add("HBa1c");
                chartReport.Series.Add("Fecalysis");
                chartReport.Series.Add("BloodTyping");
                chartReport.Series.Add("ClinicalChemistry");
                chartReport.Series.Add("Ultrasound");
                chartReport.Series.Add("CBC");
                chartReport.Series.Add("Xray");






                foreach (var p in packages)
                {
                    chartReport.Series["Urinalysis"].Points.AddXY(p.DateResult, p.Urinalysis);
                    chartReport.Series["Serology"].Points.AddXY(p.DateResult, p.Serology);
                    chartReport.Series["Hematology"].Points.AddXY(p.DateResult, p.Hematology);
                    chartReport.Series["HBa1c"].Points.AddXY(p.DateResult, p.HBa1c);
                    chartReport.Series["Fecalysis"].Points.AddXY(p.DateResult, p.Fecalysis);
                    chartReport.Series["BloodTyping"].Points.AddXY(p.DateResult, p.BloodTyping);
                    chartReport.Series["ClinicalChemistry"].Points.AddXY(p.DateResult, p.ClinicalChemistry);
                    chartReport.Series["Ultrasound"].Points.AddXY(p.DateResult, p.Ultrasound);
                    chartReport.Series["CBC"].Points.AddXY(p.DateResult, p.CBC);
                    chartReport.Series["Xray"].Points.AddXY(p.DateResult, p.Xray);


                }


            }
            else if (index.Equals(1))
            {
                LabTestDelayWeekly();
            }

        }


        void getReportMonthly(int index)
        {
            
            //most profitable package / laboratory test.
            if (index.Equals(0) || index.Equals(2))  //MAX NUMBER OF CLIENTS
            {
                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

                var packages = db.sp_ChartReportMonthly(Convert.ToInt32(cboYear.SelectedItem.ToString())).ToList();

                this.chartReport.Palette = ChartColorPalette.SeaGreen;

                // Set title.
                this.chartReport.Titles.Clear();
                this.chartReport.Titles.Add(cboReportCategory.SelectedItem.ToString());

                chartReport.Series.Clear();
                chartReport.Series.Add("Urinalysis");
                chartReport.Series.Add("Serology");
                chartReport.Series.Add("Hematology");
                chartReport.Series.Add("HBa1c");
                chartReport.Series.Add("Fecalysis");
                chartReport.Series.Add("BloodTyping");
                chartReport.Series.Add("ClinicalChemistry");
                chartReport.Series.Add("Ultrasound");
                chartReport.Series.Add("CBC");
                chartReport.Series.Add("Xray");



                foreach (var p in packages)
                {
                    chartReport.Series["Urinalysis"].Points.AddXY(p.YearMonth, p.Urinalysis);
                    chartReport.Series["Serology"].Points.AddXY(p.YearMonth, p.Serology);
                    chartReport.Series["Hematology"].Points.AddXY(p.YearMonth, p.Hematology);
                    chartReport.Series["HBa1c"].Points.AddXY(p.YearMonth, p.HBa1c);
                    chartReport.Series["Fecalysis"].Points.AddXY(p.YearMonth, p.Fecalysis);
                    chartReport.Series["BloodTyping"].Points.AddXY(p.YearMonth, p.BloodTyping);
                    chartReport.Series["ClinicalChemistry"].Points.AddXY(p.YearMonth, p.ClinicalChemistry);
                    chartReport.Series["Ultrasound"].Points.AddXY(p.YearMonth, p.Ultrasound);
                    chartReport.Series["CBC"].Points.AddXY(p.YearMonth, p.CBC);
                    chartReport.Series["Xray"].Points.AddXY(p.YearMonth, p.Xray);


                }


            }
            else if (index.Equals(1))
            {
                LabTestDelayMonthly();
            }

        }



        private void FrmReport_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReportCategory.SelectedIndex == 2)
            {
                
                cboLabTest.Visible = true;
                cboLabTest.Items.Clear();
                cboLabTest.Items.Add("Urinalysis");
                cboLabTest.Items.Add("Serology");
                cboLabTest.Items.Add("Hematology");
                cboLabTest.Items.Add("HBa1C");
                cboLabTest.Items.Add("Fecalysis");
                cboLabTest.Items.Add("BloodTyping");
                cboLabTest.Items.Add("ClinicalChemistry");
            }
            else
            {
                cboLabTest.Visible = false;
            }
           
        }

        private void cboFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReportType.SelectedIndex == 0)
            {

                cboYear.Visible = false;
                cboMonths.Visible = true;
                cboWeekNumber.Visible = true;
                cboMonths.Items.Clear();
                string[] months = new string[]{
                    "January",
                    "February",
                    "March",
                    "April",
                    "May",
                    "June",
                    "July",
                    "August",
                    "September",
                    "October",
                    "November",
                    "December"

                };


                foreach (var m in months)
                {
                    cboMonths.Items.Add(m);
                }
            }
            else
            {

                cboYear.Visible = true;
                cboMonths.Visible = false;
                cboWeekNumber.Visible = false;
                cboYear.Items.Clear();
                string[] years = new string[]{
                   "2021",
                   "2022",
                   "2023",
                   "2024",
                   "2025",
                   "2026",
                   "2027",
                   "2028",
                   "2029",
                   "2030",
                   "2031",
                   "2032",
                   "2033"
                };


                foreach (var y in years)
                {
                    cboYear.Items.Add(y);
                }


            }
        }


        private void cmdPrint_Click(object sender, EventArgs e)
        {
            chartReport.Printing.PrintPreview();
        }

    }
}
