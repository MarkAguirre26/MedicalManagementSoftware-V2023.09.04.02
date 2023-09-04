using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class FrmLapPrints : Form
    {
        public string Name;
        public string Company;
        public string ResultDate_Urinalysis;
        public string ResultDate_Serology;
        public string ResultDate_Hematolgy;
        public string ResultDate_hba1c;
        public string ResultDate_Fecalysis;
        public string ResultDate_BloodTyping;
        public string ResultDate_ClinicalChem;
        public string AgeSex;





        public string Color;
        public string Transparency;
        public string SpecificGravity;
        public string pH;
        public string Glucose;
        public string Protein;
        public string WhiteBloodCells;
        public string RedBloodCells;
        public string EpithelialCells;
        public string MucusThread;
        public string Bacteria;
        public string AmorphousUrates;
        public string AmorphousPhospates;
        public string OthersUrinalysis;



        public string Test1;
        public string Test2;
        public string Specific1;
        public string Specific2;
        public string Result1;
        public string Result2;


        public string Redbloodcells;
        public string Whitebloodcells;
        public string Hematocrit;
        public string Plateletcount;
        public string Hemoglobin;
        public string Neutrophil;
        public string Lymphocyte;
        public string Monocyte;
        public string Eosinophil;
        public string Basophil;
        public string OtherHema;



        public string colorFecalysis;
        public string ConsistencyFecalysis;
        public string WhitebloodcellFecalysis;
        public string RedbloodcellFecalysis;
        public string FatglobulesFecalysis;
        public string BacteriaFecalysis;
        public string FindingsFecalysis;



        public string Test1BloodTyping;
        public string Test2BloodTyping;
        public string Specific1BloodTyping;
        public string Specific2BloodTyping;
        public string Result1BloodTyping;
        public string Result2BloodTyping;


        public string HBA1C;


        public string Fbs;
        public string Bun;
        public string UricAcid;
        public string Creatinine;
        public string Cholesterol;
        public string Triglyceride;
        public string Hdl;
        public string Ldl;
        public string Vldl;
        public string Sgpt;
        public string Sgot;
        public string Fbs_Remark;
        public string Bun_Remark;
        public string UricAcid_Remark;
        public string Creatinine_Remark;
        public string Cholesterol_Remark;
        public string Triglyceride_Remark;
        public string Hdl_Remark;
        public string Ldl_Remark;
        public string Vldl_Remark;
        public string Sgpt_Remark;
        public string Sgot_Remark;



        public FrmLapPrints()
        {
            InitializeComponent();
        }

        private void cmdHematology_Click(object sender, EventArgs e)
        {


            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchHematology(this.Tag.ToString()).FirstOrDefault();
            if (item != null)
            {


                Redbloodcells = item.Redbloodcells;
                Whitebloodcells = item.Whitebloodcells;
                Hematocrit = item.Hematocrit;
                Plateletcount = item.Plateletcount;
                Hemoglobin = item.Hemoglobin;
                Neutrophil = item.Neutrophil;
                Lymphocyte = item.Lymphocyte;
                Monocyte = item.Monocyte;
                Eosinophil = item.Eosinophil;
                Basophil = item.Basophil;
                OthersUrinalysis = item.Other;



            }



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
                     Name,
                  Company,
                  ResultDate_Hematolgy,
                  AgeSex,
                    Redbloodcells,
                    Whitebloodcells,
                    Hematocrit,
                    Plateletcount,
                    Hemoglobin,
                    Neutrophil,
                    Lymphocyte,
                    Monocyte,
                    Eosinophil,
                    Basophil,
                    OtherHema,


                        });

            db.sp_PrinthematologyUpdate(this.Tag.ToString());
            db.sp_updateIsPrinted(3, this.Tag.ToString());
        }



        private void cmdUrinalysis_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.sp_SearchUrinalysis(this.Tag.ToString()).FirstOrDefault();
            if (item != null)
            {

                Color = item.Color;
                Transparency = item.Transparency;
                SpecificGravity = item.SpecificGravity;
                pH = item.pH;
                Glucose = item.Glucose;
                Protein = item.Protein;
                WhiteBloodCells = item.WhiteBloodCells;
                RedBloodCells = item.RedBloodCells;
                EpithelialCells = item.EpithelialCells;
                MucusThread = item.MucusThread;
                Bacteria = item.Bacteria;
                AmorphousUrates = item.AmorphousUrates;
                AmorphousPhospates = item.AmorphousPhospates;
                OthersUrinalysis = item.Others;


            }





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

                      Name,
                  Company,
                  ResultDate_Urinalysis,
                  AgeSex,
                    Color,
                    Transparency,
                    SpecificGravity,
                    pH,
                    Glucose,
                    Protein,
                    WhiteBloodCells,
                    RedBloodCells,
                    EpithelialCells,
                    MucusThread,
                    Bacteria,
                    AmorphousUrates,
                    AmorphousPhospates,
                    OthersUrinalysis
                        });


            //
            db.sp_PrintUrinalysisUpdate(this.Tag.ToString());
            db.sp_updateIsPrinted(1,this.Tag.ToString());

        }

        private void cmdSerology_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchSerology(this.Tag.ToString()).FirstOrDefault();
            if (item != null)
            {

                Test1 = item.Test1;
                Test2 = item.Test2;
                Specific1 = item.Specific1;
                Specific2 = item.Specific2;
                Result1 = item.Result1;
                Result2 = item.Result2;
            }



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
                   Name,
                  Company,
                  ResultDate_Serology,
                  AgeSex,
                    Test1,
                    Specific1,
                    Result1
                        });


            db.sp_PrintSerelogyUpdate(this.Tag.ToString());
            db.sp_updateIsPrinted(2, this.Tag.ToString());

        }

        private void cmdFecalysis_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchFecalysis(this.Tag.ToString()).FirstOrDefault();
            if (item != null)
            {

                colorFecalysis = item.color;
                ConsistencyFecalysis = item.Consistency;
                WhitebloodcellFecalysis = item.Whitebloodcell;
                RedbloodcellFecalysis = item.Redbloodcell;
                FatglobulesFecalysis = item.Fatglobules;
                BacteriaFecalysis = item.Bacteria;
                FindingsFecalysis = item.Findings;
            }



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
              new string[] { Name,
                  Company,
                  ResultDate_Fecalysis,
                  AgeSex,
                   colorFecalysis,
                     ConsistencyFecalysis,
                 WhitebloodcellFecalysis,
                 RedbloodcellFecalysis,
                 FatglobulesFecalysis,
                 BacteriaFecalysis,
                 FindingsFecalysis
                        });

            db.sp_PrintfecalysisUpdate(this.Tag.ToString());
            db.sp_updateIsPrinted(5, this.Tag.ToString());
        }

        private void cmdBloodTyping_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchBloodTyping(this.Tag.ToString()).FirstOrDefault();
            if (item != null)
            {


                Test1BloodTyping = item.Test1;
                Test2BloodTyping = item.Test2;
                Specific1BloodTyping = item.Specific1;
                Specific2BloodTyping = item.Specific2;
                Result1BloodTyping = item.Result1;
                Result2BloodTyping = item.Result2;




            }




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
                   Name,
                  Company,
                  ResultDate_BloodTyping,
                  AgeSex,
                  Test1BloodTyping,
                  Test2BloodTyping,
                  Specific1BloodTyping,
                  Specific2BloodTyping,
                  Result1BloodTyping,
                Result2BloodTyping,
               });



            db.sp_PrintbloodTypingUpdate(this.Tag.ToString());
            db.sp_updateIsPrinted(6, this.Tag.ToString());

        }

        private void cmdHBa1C_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchHbOneC(this.Tag.ToString()).FirstOrDefault();
            if (item != null)
            {

                HBA1C = item.HBA1C;
            }




            Reporting.Write("HBA1C_TEMPLATE",
               new string[] { 
                   "B9",
                   "B10",
                   "G8",
                   "G9",
                   "D19"
                   
                   },
               new string[] { 
                   Name,
                  Company,
                  ResultDate_hba1c,
                  AgeSex,
                  HBA1C
               });


            db.sp_PrintHbAOnecUpdate(this.Tag.ToString());
            db.sp_updateIsPrinted(4, this.Tag.ToString());

        }

        private void cmdClinicalChemistry_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var item = db.searchChem(this.Tag.ToString()).FirstOrDefault();
            if (item != null)
            {

                Fbs = item.Fbs;
                Fbs_Remark = item.Fbs_Remark;

                Bun = item.Bun;
                Bun_Remark = item.Bun_Remark;

                UricAcid = item.UricAcid;
                UricAcid_Remark = item.UricAcid_Remark;

                Cholesterol = item.Cholesterol;
                Cholesterol_Remark = item.Cholesterol_Remark;

                Triglyceride = item.Triglyceride;
                Triglyceride_Remark = item.Triglyceride_Remark;


                Creatinine = item.Creatinine;
                Creatinine_Remark = item.Creatinine_Remark;


                Hdl = item.Hdl;
                Hdl_Remark = item.Hdl_Remark;

                Ldl = item.Ldl;
                Ldl_Remark = item.Ldl_Remark;

                Vldl = item.Vldl;
                Vldl_Remark = item.Vldl_Remark;

                Sgpt = item.Sgpt;
                Sgpt_Remark = item.Sgpt_Remark;

                Sgot = item.Sgot;
                Sgot_Remark = item.Sgot_Remark;

                //ClinicalChemistry_TEMPLATE
            }


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
                   Name,
                  Company,
                  ResultDate_ClinicalChem,
                  AgeSex,
                  Fbs,
                    Bun,
                    UricAcid,
                    Creatinine,
                    Cholesterol,
                    Triglyceride,
                    Hdl,
                    Ldl,
                    Vldl,
                    Sgpt,
                    Sgot,
                    Fbs_Remark,
                    Bun_Remark,
                    UricAcid_Remark,
                    Creatinine_Remark,
                    Cholesterol_Remark,
                    Triglyceride_Remark,
                    Hdl_Remark,
                    Ldl_Remark,
                    Vldl_Remark,
                    Sgpt_Remark,
                    Sgot_Remark

               });


            db.sp_PrintClinicalChemistryUpdate(this.Tag.ToString());
            db.sp_updateIsPrinted(7, this.Tag.ToString());
        }

        private void FrmLapPrints_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
