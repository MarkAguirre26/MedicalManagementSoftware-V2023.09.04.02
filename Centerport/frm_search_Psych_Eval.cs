using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_search_Psych_Eval : Form
    {
   
    
        public bool isOpen;
        DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
        public List<Psychology_Model> Psychology_model = new List<Psychology_Model>();
        Main fmain;
        public frm_search_Psych_Eval(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
        }

        private void frm_search_Psych_Eval_Load(object sender, EventArgs e)
        {
    
            isOpen = true;
            cbo_filter.Text = "Patient Name"; 
            txt_search.Select();
            if (!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }

           



        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dg_result.SelectedRows.Count >= 1)
            { cmd_select.Enabled = true; }
            else
            { cmd_select.Enabled = false; }
        }



        void SelectItem()
        {
            if (dg_result.SelectedRows.Count >= 1)
            {
                this.Close();
                Cursor.Current = Cursors.WaitCursor;
                
                
                string pin = dg_result.SelectedRows[0].Cells[1].Value.ToString();               
                var p = (from m in db.t_psychologies where m.papin.Contains(pin) select m).ToList();


               if (p.Count() >= 1)
                {                                      
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).ClearAll();
                    frm_Psych_Evaluation.NewPsych_Eval = false;
                    frm_Psych_Evaluation.pin.Clear();
                    frm_Psych_Evaluation.pin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();                  
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Search_Patient();             
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).search_Psych();
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Availability(false);
                   fmain.ts_add_Eval.Enabled = true; fmain.ts_edit_Eval.Enabled = true; fmain.ts_delete_Eval.Enabled = false; fmain.ts_save_Eval.Enabled = false; fmain.ts_search_Eval.Enabled = true; fmain.ts_print_Eval.Enabled = true; fmain.ts_cancel_Eval.Enabled = false;

                    this.Close();

                }
                else
                {
                  
                    frm_Psych_Evaluation.NewPsych_Eval = true;
                    frm_Psych_Evaluation.pin.Clear();
                    frm_Psych_Evaluation.pin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();                 
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Availability(true);
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).ClearAll();
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Search_Patient();
                    (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).New();
                    fmain.ts_add_Eval.Enabled = false; fmain.ts_edit_Eval.Enabled = false; fmain.ts_delete_Eval.Enabled = false; fmain.ts_save_Eval.Enabled = true; fmain.ts_search_Eval.Enabled = false; fmain.ts_print_Eval.Enabled = false; fmain.ts_cancel_Eval.Enabled = true;

                    this.Close();

                }                
                               
                Cursor.Current = Cursors.Default;

            }


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

        private void frm_search_Psych_Eval_KeyDown(object sender, KeyEventArgs e)
        {
         
            if (e.KeyCode == Keys.Enter)
            { SelectItem(); }
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            { dg_result.Focus(); }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            txt_search.Clear();
            txt_search.Select();          

        }

        private void dg_result_DoubleClick(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dg_result.SelectedRows.Count >= 1)
            {
                frm_patient_Info info = new frm_patient_Info();
                info.Tag = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                info.ShowDialog();


            }
        }

     


        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
          
            this.Invoke(new MethodInvoker(delegate() { FillDataGridView(); }));
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

               
          
          

        }

      public  void FillDataGridView()
        {

            try
            {
               
                Psychology_model = (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Psychology_model;
                var list = (from m in Psychology_model select m).ToList();
                if (cbo_filter.Text == "Patient Pin")
                {
                    list = (from m in Psychology_model where m.papin.StartsWith(txt_search.Text) select m).ToList();
                }
                else if (cbo_filter.Text == "Patient Name")
                {
                    list = (from m in Psychology_model where m.PatientName.StartsWith(txt_search.Text) select m).ToList();
                }
                dg_result.DataSource = list;
                dg_result.Columns[0].Visible = false;
                dg_result.Columns[1].Visible = false;
                dg_result.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }

          
        }

      private void frm_search_Psych_Eval_FormClosing(object sender, FormClosingEventArgs e)
      {
          isOpen = false;
      }


      



     
      

    }
}
