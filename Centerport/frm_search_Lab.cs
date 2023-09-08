using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_search_Lab : Form
    {

        Main fmain;
        private const long BUTTON_DOWN_CODE = 0xa1;
        private const long BUTTON_UP_CODE = 0xa0;
        private const long WM_MOVING = 0x216;
        static bool left_button_down = false;

        public string cameFrom = "";

        public bool isopen;
        DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
        public List<laboratory_search> labsearch = new List<laboratory_search>();
        public frm_search_Lab(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;

        }

        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            //Check the state of the Left Mouse Button
            if ((long)m.Msg == BUTTON_DOWN_CODE)
                left_button_down = true;
            else if ((long)m.Msg == BUTTON_UP_CODE)
                left_button_down = false;

            if (left_button_down)
            {
                if ((long)m.Msg == WM_MOVING)
                {
                    //Set the forms opacity to 50% if user is moving
                    if (this.Opacity != 0.5)
                        this.Opacity = 0.5;
                }
            }

            else if (!left_button_down)
                if (this.Opacity != 1.0)
                    this.Opacity = 1.0;

            base.DefWndProc(ref m);
        }
        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Foo
        {
            public string cn, papin, Name, resultid, patientName, resultDate;
        }



        private void cbo_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_search_Patient_Lab_Load(object sender, EventArgs e)
        {
            isopen = true;
          

            txt_search.Select();


            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }



        }

        private void dg_result_DoubleClick(object sender, EventArgs e)
        {
            SelectItem();
        }


        void SelectItem()
        {
            if (dg_result.SelectedRows.Count >= 1)
            {

                if (cameFrom.Equals("LAB"))
                {
                    this.Close();
                    Cursor.Current = Cursors.WaitCursor;
                    (Application.OpenForms["FrmLaboratoryReport"] as FrmLaboratoryReport).Papin = this.dg_result.SelectedRows[0].Cells[2].Value.ToString();

                    (Application.OpenForms["FrmLaboratoryReport"] as FrmLaboratoryReport).ClearAll();
                    (Application.OpenForms["FrmLaboratoryReport"] as FrmLaboratoryReport).Search_Patient();
                    (Application.OpenForms["FrmLaboratoryReport"] as FrmLaboratoryReport).Search();

             
                    fmain.ts_edit_labReport.Enabled = true;
                   
                    fmain.ts_save_labReport.Enabled = false;
                    fmain.ts_search_labReport.Enabled = true;
                    fmain.ts_print_labReport.Enabled = true;
                    fmain.ts_cancel_labReport.Enabled = false;
                    Cursor.Current = Cursors.Default;
                }
                else if (cameFrom.Equals("XRAY"))
                {
                    this.Close();
                    Cursor.Current = Cursors.WaitCursor;
                    (Application.OpenForms["frm_xray"] as frm_xray).Papin = this.dg_result.SelectedRows[0].Cells[2].Value.ToString();

                    

                    (Application.OpenForms["frm_xray"] as frm_xray).ClearAll();
                    (Application.OpenForms["frm_xray"] as frm_xray).Search_Patient();                    
                    (Application.OpenForms["frm_xray"] as frm_xray).search_Xray("XRAY");

                    fmain.ts_printPreview_Xray.Enabled = true;  fmain.ts_edit_xray.Enabled = true; fmain.ts_save_xray.Enabled = false; fmain.ts_search_xray.Enabled = true; fmain.ts_print_xray.Enabled = true; fmain.ts_cancel_xray.Enabled = false;
                    Cursor.Current = Cursors.Default;
                    

                }
                else if (cameFrom.Equals("ECG"))
                {
                    this.Close();
                    Cursor.Current = Cursors.WaitCursor;
                    (Application.OpenForms["frm_xray"] as frm_xray).Papin = this.dg_result.SelectedRows[0].Cells[2].Value.ToString();



                    (Application.OpenForms["frm_xray"] as frm_xray).ClearAll();
                    (Application.OpenForms["frm_xray"] as frm_xray).Search_Patient();
                    (Application.OpenForms["frm_xray"] as frm_xray).search_Xray("ECG");

                    fmain.ts_printPreview_Xray.Enabled = true; fmain.ts_edit_xray.Enabled = true; fmain.ts_save_xray.Enabled = false; fmain.ts_search_xray.Enabled = true; fmain.ts_print_xray.Enabled = true; fmain.ts_cancel_xray.Enabled = false;



                    Cursor.Current = Cursors.Default;
                }
                else if (cameFrom.Equals("UTZ"))
                {
                    this.Close();
                    Cursor.Current = Cursors.WaitCursor;
                    (Application.OpenForms["frm_xray"] as frm_xray).Papin = this.dg_result.SelectedRows[0].Cells[2].Value.ToString();



                    (Application.OpenForms["frm_xray"] as frm_xray).ClearAll();
                    (Application.OpenForms["frm_xray"] as frm_xray).Search_Patient();
                    (Application.OpenForms["frm_xray"] as frm_xray).search_Xray("UTZ");

                    fmain.ts_printPreview_Xray.Enabled = true; fmain.ts_edit_xray.Enabled = true; fmain.ts_save_xray.Enabled = false; fmain.ts_search_xray.Enabled = true; fmain.ts_print_xray.Enabled = true; fmain.ts_cancel_xray.Enabled = false;



                    Cursor.Current = Cursors.Default;
                }
                else if (cameFrom.Equals("MEDEX"))
                {
                    this.Close();
                    Cursor.Current = Cursors.WaitCursor;



                    (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).ClearAll();

                    (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).txtPapin.Text = this.dg_result.SelectedRows[0].Cells[2].Value.ToString();

                    (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).searchAll();



                    fmain.ts_print_land.Enabled = true; 
                    fmain.ts_edit_land.Enabled = true;
                    fmain.ts_save_land.Enabled = false;
                    fmain.ts_search_land.Enabled = true; 
                    fmain.ts_print_land.Enabled = true;
                    fmain.ts_cancel_land.Enabled = false;



                    Cursor.Current = Cursors.Default;



                }
                //MEDEX

                
                

            }




        }

        private void frm_search_Patient_Lab_Shown(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            FillDataGridView();
        }

        private void cmd_search_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectItem();
        }


        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            { dg_result.Focus(); }

        }

        private void frm_search_Lab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { SelectItem(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txt_search.Clear();
            txt_search.Select();


        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dg_result.SelectedRows.Count >= 1)
            {
                frm_patient_Info info = new frm_patient_Info();
                info.Tag = dg_result.SelectedRows[0].Cells[2].Value.ToString();
                info.ShowDialog();


            }
        }





        public void FillDataGridView()
        {
            try
            {

                var list = labsearch.ToList();

             
                    list = (from m in list where m.PatientName.StartsWith(txt_search.Text) select m).ToList();
                

                dg_result.DataSource = list;
                dg_result.AutoGenerateColumns = true;
                dg_result.Columns[0].Visible = false;
                dg_result.Columns[1].Visible = false;
                dg_result.Columns[2].Visible = false;
                dg_result.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg_result.Columns[4].Width = 130;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
        }


        private void frm_search_Lab_FormClosing(object sender, FormClosingEventArgs e)
        {
            isopen = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate()
            {


                try
                {




                    var list = db.Patient_search("%").ToList();
                    labsearch.Clear();


                    foreach (var item in list)
                    {
                        labsearch.Add(new laboratory_search
                        {
                            cn = Convert.ToInt32(item.cn),
                            papin = item.papin,
                            PatientName = item.Name

                        });


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

                }


            }));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }
    }
}
