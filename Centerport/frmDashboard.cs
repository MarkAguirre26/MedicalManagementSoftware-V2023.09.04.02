using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedicalManagement
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            getPatientByGender();
            getPatientByGroup();
            getMostProfitable();
            getLabTestTurnArountTime();
        }

        private void getPatientByGender()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

            var packages = db.sp_PatientByGender().ToList();

            this.chartPatientByGender.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chartPatientByGender.Titles.Clear();
            this.chartPatientByGender.Titles.Add("Patient by Gender");

            chartPatientByGender.Series.Clear();
            chartPatientByGender.Series.Add("Male");
            chartPatientByGender.Series.Add("Female");




            foreach (var p in packages)
            {
                chartPatientByGender.Series["Male"].Points.AddXY("", p.Male);
                chartPatientByGender.Series["Female"].Points.AddXY("", p.Female);
            }
        }

        private void getPatientByGroup()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

            var packages = db.sp_PatientByGroup().ToList();

            this.chartPatientByGroup.Palette = ChartColorPalette.SeaGreen;

            this.chartPatientByGroup.Titles.Clear();
            this.chartPatientByGroup.Titles.Add("Patient by Group");

            chartPatientByGroup.Series.Clear();
            chartPatientByGroup.Series.Add("Senior");
            chartPatientByGroup.Series.Add("Adult");
            chartPatientByGroup.Series.Add("Teenager");
            chartPatientByGroup.Series.Add("Child");


            foreach (var p in packages)
            {
                chartPatientByGroup.Series["Senior"].Points.AddXY("", p.Senior);
                chartPatientByGroup.Series["Adult"].Points.AddXY("", p.Adult);
                chartPatientByGroup.Series["Teenager"].Points.AddXY("", p.Teenager);
                chartPatientByGroup.Series["Child"].Points.AddXY("", p.Child);
            }
        }


        private void getMostProfitable()
        {

            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

            var list = db.sp_MostAvailedLaboratoryTestForTheMonth().ToList();

            //dgMostProfiatable.Columns.Clear();
            dgMostProfiatable.Rows.Clear();
            //dgMostProfiatable.DataSource = list;
            int ind = 1;
            foreach (var i in list)
            {
                dgMostProfiatable.Rows.Add(ind, i.LabTest, i.Count);
                ind++;
            }


        }

        double ComputeAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Length;

            if (average < 1)
            {
                average = 1;
            }

            return average;
        }

        private void getLabTestTurnArountTime()
        {

            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

            var Urinalysis = (from m in db.sp_LaboratoryTestTurnAroundTime().ToList() where m.Test.Equals("Urinalysis") select m);
            dgTurnAround.Rows.Clear();

            int[] UrinalysisArray = new int[] { };
            foreach (var i in Urinalysis)
            {
                string d = "";
                if (i.d == 0)
                {
                    d = "1";
                }
                else
                {
                    d = i.d.ToString();
                }

                UrinalysisArray = UrinalysisArray.Concat(new int[] { Convert.ToInt32(i.d) }).ToArray();            

            }

            dgTurnAround.Rows.Add("Urinalysis", "1 Day", ComputeAverage(UrinalysisArray).ToString("#.#") + " Day");


            var Serology = (from m in db.sp_LaboratoryTestTurnAroundTime().ToList() where m.Test.Equals("Serology") select m);
            int[] SerologyArray = new int[] { };
            foreach (var i in Serology)
            {
                string d = "";
                if (i.d == 0)
                {
                    d = "1";
                }
                else
                {
                    d = i.d.ToString();
                }

                SerologyArray = SerologyArray.Concat(new int[] { Convert.ToInt32(i.d) }).ToArray();

               

            }
            dgTurnAround.Rows.Add("Serology", "1 Day", ComputeAverage(SerologyArray).ToString("#.#") + " Day");


            var Hematology = (from m in db.sp_LaboratoryTestTurnAroundTime().ToList() where m.Test.Equals("Hematology") select m);
            int[] HematologyArray = new int[] { };
            foreach (var i in Hematology)
            {
                string d = "";
                if (i.d == 0)
                {
                    d = "1";
                }
                else
                {
                    d = i.d.ToString();
                }

                HematologyArray = HematologyArray.Concat(new int[] { Convert.ToInt32(i.d) }).ToArray();
                               

            }

            dgTurnAround.Rows.Add("Hematology", "1 Day", ComputeAverage(HematologyArray).ToString("#.#") + " Day");


            var Hba1c = (from m in db.sp_LaboratoryTestTurnAroundTime().ToList() where m.Test.Equals("Hba1c") select m);
            int[] Hba1cArray = new int[] { };
            foreach (var i in Hba1c)
            {
                string d = "";
                if (i.d == 0)
                {
                    d = "1";
                }
                else
                {
                    d = i.d.ToString();
                }

                Hba1cArray = Hba1cArray.Concat(new int[] { Convert.ToInt32(i.d) }).ToArray();


            }

            dgTurnAround.Rows.Add("Hba1c", "1 Day", ComputeAverage(Hba1cArray).ToString("#.#") + " Day");



            var Fecalysis = (from m in db.sp_LaboratoryTestTurnAroundTime().ToList() where m.Test.Equals("Fecalysis") select m);
            int[] FecalysisArray = new int[] { };
            foreach (var i in Fecalysis)
            {
                string d = "";
                if (i.d == 0)
                {
                    d = "1";
                }
                else
                {
                    d = i.d.ToString();
                }

                FecalysisArray = FecalysisArray.Concat(new int[] { Convert.ToInt32(i.d) }).ToArray();


            }

            dgTurnAround.Rows.Add("Fecalysis", "1 Day", ComputeAverage(FecalysisArray).ToString("#.#") + " Day");



            var BloodTyping = (from m in db.sp_LaboratoryTestTurnAroundTime().ToList() where m.Test.Equals("BloodTyping") select m);
            int[] BloodTypingArray = new int[] { };
            foreach (var i in BloodTyping)
            {
                string d = "";
                if (i.d == 0)
                {
                    d = "1";
                }
                else
                {
                    d = i.d.ToString();
                }

                BloodTypingArray = BloodTypingArray.Concat(new int[] { Convert.ToInt32(i.d) }).ToArray();


            }

            dgTurnAround.Rows.Add("BloodTyping", "1 Day", ComputeAverage(BloodTypingArray).ToString("#.#") + " Day");



            var ClinicalChemistry = (from m in db.sp_LaboratoryTestTurnAroundTime().ToList() where m.Test.Equals("Clinical Chemistry") select m);
            int[] ClinicalChemistryArray = new int[] { };
            foreach (var i in ClinicalChemistry)
            {
                string d = "";
                if (i.d == 0)
                {
                    d = "1";
                }
                else
                {
                    d = i.d.ToString();
                }

                ClinicalChemistryArray = ClinicalChemistryArray.Concat(new int[] { Convert.ToInt32(i.d) }).ToArray();


            }

            dgTurnAround.Rows.Add("ClinicalChemistry", "1 Day", ComputeAverage(ClinicalChemistryArray).ToString("#.#") + " Day");









        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            getPatientByGender();
            getPatientByGroup();
            getMostProfitable();
            getLabTestTurnArountTime();
        }
    }
}
