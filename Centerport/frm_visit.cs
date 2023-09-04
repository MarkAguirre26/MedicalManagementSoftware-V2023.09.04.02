using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_visit : Form, MyInter
    {
        Main fmain;
        DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
        public frm_visit(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
        }







        public void New()
        {


        }

        public void Save()
        {
            //MessageBox.Show("Save");
        }






        public static void Close_Form()
        {



        }



        private void frm_visit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Add && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_add_visit.Enabled == true)
                {
                    dt_from.Enabled = false;
                    fmain.add_Visit();
                }
            }

            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_save_visit.Enabled == true)
                {
                    Save();

                }

            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_print_visit.Enabled == true)
                {
                    Print();
                }
            }
            //else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            //{

            //    MessageBox.Show("Search");
            //}
            else if (e.KeyCode == Keys.F5)
            { loadlist(); }

        }

        private void frm_visit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // fmain.Strip_sub.Visible = false;           
            Main.f_visit = true;


            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ts_Save_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }
        public void Edit()
        { }
        public void Delete()
        { }
        public void Cancel()
        { }
        public void Print()
        {

           
            List<visitModel> visitModel = new List<Class.visitModel>();
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            var list = db.sp_visitReport().ToList();
            foreach (var i in list)
            {
                visitModel.Add(new visitModel
                {
                    papin = i.papin,
                    PatientName = i.PatientName,
                    Gender = i.gender,
                    Type = i.pxtype,
                    Date = i.trans_date
                });
            }
            string source = TemplatePath.basePath + @"Source\Patients Visit - TEMPLATE.xlsx";
            string file = TemplatePath.basePath + "Patients Visit - TEMPLATE.xlsx";
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            File.Copy(source, file);

            Reporting.ExportVisit(file.Replace(".xlsx", ""), visitModel);
            //



        }

        public void Search()
        { }






        public class TableFields
        {
            public string cn, papin, name, gender, purpose, Date;
            public DateTime TimeIn;
        }

        List<visitModel> visitModel = new List<visitModel>();
        public void loadlist()
        {


            try
            {

                var list = db.visit();



                dg_listQueue.DataSource = list;

                // txt_count.Text = "Item(s): " + list.Count().ToString();
                Tool.setRowNumber(dg_listQueue);

                if (dg_listQueue.Rows.Count >= 1)
                {

                    fmain.ts_print_visit.Enabled = true;
                }
                else
                {
                    fmain.ts_print_visit.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }



        }

        private void cmd_retrieve_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            { backgroundWorker1.RunWorkerAsync(); }

        }


        private void cmd_refresh_Click(object sender, EventArgs e)
        {

            if (!backgroundWorker1.IsBusy)
            { backgroundWorker1.RunWorkerAsync(); }




        }

        private void frm_visit_Leave(object sender, EventArgs e)
        {

        }

        private void frm_visit_Enter(object sender, EventArgs e)
        {
            //Visit_Add_model.Clear();
            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync();
            //}
        }



        private void dt_from_ValueChanged(object sender, EventArgs e)
        {
            //SendKeys.Send("{RIGHT}");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //TableFields fields = (TableFields)e.Argument;
            //int i = 1;


            this.Invoke(new MethodInvoker(delegate() { loadlist(); }));







        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {


            if (!backgroundWorker1.CancellationPending)
            {



                if (dg_listQueue.Rows.Count >= 1)
                {

                    fmain.ts_print_visit.Enabled = true;
                }
                else
                {
                    fmain.ts_print_visit.Enabled = false;
                }


            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (!backgroundWorker2.IsBusy)
            //{ backgroundWorker2.RunWorkerAsync(); }

        }

        public List<QueueSearchList_Model> Visit_Add_model = new List<QueueSearchList_Model>();

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate() { LoadDataAdd(); }));
        }


        void LoadDataAdd()
        {

            try
            {


                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var list = db.Search_patient_add_a("%").ToList();
                var count = list.Count();
                foreach (var i in list)
                {
                    Visit_Add_model.Add(new QueueSearchList_Model
                    {
                        cn = i.cn,
                        papin = i.papin,
                        PatientName = i.PatientName,
                        gender = i.gender

                    });
                }

                //

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
        }

        private void frm_visit_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void dg_listQueue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dg_listQueue.SelectedRows.Count >= 1)
                {
                  
                    if (DialogResult.Yes == MessageBox.Show(this, string.Format("Are you sure you want to delete this item?", "Confirm Delete"), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        this.Tag = dg_listQueue.SelectedRows[0].Cells[0].Value.ToString();

                        DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                        db.sp_deleteVisit(this.Tag.ToString());
                        backgroundWorker1.RunWorkerAsync();
                    }


                   

                }
            }
        }

        private void dg_listQueue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_listQueue.SelectedRows.Count >= 1)
            {
                this.Tag = dg_listQueue.SelectedRows[0].Cells[0].Value.ToString();
                //(Application.OpenForms["frm_VisitDetail"] as frm_VisitDetail).Tag = this.Tag.ToString();
                //(Application.OpenForms["frm_VisitDetail"] as frm_VisitDetail).ShowDialog();

                //frm_VisitDetail f = new frm_VisitDetail(this);
                //f.Tag = this.Tag.ToString();
                //f.ShowDialog();
               


            }
        }



    }
}
