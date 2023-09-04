using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace MedicalManagement
{
    public partial class frm_search_Patient_Queuing : Form
    {
        public int Papin; public bool Sea_mlc; public bool tumor; public bool ultraS; public bool queue; public bool Landbase; public bool lab; public bool seafarer; public bool mlc; public bool Psych_Evaluation; public bool xray; public bool hiv;
        Main fmain; private string Patient_cn;

        private const long BUTTON_DOWN_CODE = 0xa1;
        private const long BUTTON_UP_CODE = 0xa0;
        private const long WM_MOVING = 0x216;
        static bool left_button_down = false;
        public string xrayFromType = "";
        public List<QueueSearchList_Model> queueSearchList_Model = new List<QueueSearchList_Model>();

        DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

        public bool isfromVisit = false;

        private DataTable dt_Queue;
        public frm_search_Patient_Queuing(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
        }

        private void cmd_cnacel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void cmd_addnew_Click(object sender, EventArgs e)
        {

            frm_addPatient f_addPatient = new frm_addPatient();
            f_addPatient.ShowDialog();


        }




        void loadImage()
        {


            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                var list = db.Select_Patient_pic(dg_result.SelectedRows[0].Cells[0].Value.ToString()).ToList();
                if (list != null)
                {
                    foreach (var i in list)
                    {


                        pic_.Image = Tool.bytetoimage(i.picture.ToArray());
                    }
                }
                else
                {

                    pic_.Image = Properties.Resources.AnonymousPic;
                    pic_.BackgroundImage = Properties.Resources.AnonymousPic;

                }

            }
            catch //(Exception ex)
            {
                // MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                pic_.Image = Properties.Resources.AnonymousPic;
                pic_.BackgroundImage = Properties.Resources.AnonymousPic;
            }



        }


        private void cmd_clear_criteria_Click(object sender, EventArgs e)
        {
            txt_Search.Clear(); txt_Search.Select();
            pic_.Image = Properties.Resources.AnonymousPic;
            pic_.BackgroundImage = Properties.Resources.AnonymousPic;
        }


        private void frm_search_Patient_Queuing_Load(object sender, EventArgs e)
        {

            txt_Search.Select();

            
            



            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }


        }





        void SelectItem()
        {
            if (dg_result.SelectedRows.Count >= 1)
            {
                Cursor.Current = Cursors.WaitCursor;
                if (queue)
                {

                    using (frm_VisitDetail f_detail = new frm_VisitDetail(this))
                    {
                        f_detail.Tag = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                        f_detail.ShowDialog();

                    }



                }

                else if (lab)
                {


                    string pin = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                    var cnt = db.sp_CountPatient(pin.ToString()).FirstOrDefault();
                    if (cnt.PatientCount >= 1)
                    {

                        if (MessageBox.Show("Previous laboratory examination Detected! Click YES to modify or No to cancel.", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frm_lab.newlab = false;
                            frm_lab.LabId.Clear();

                            var i = db.sp_Que_Lab(pin.ToString()).FirstOrDefault();
                            frm_lab.LabId.Text = i.resultid;
                            frm_lab.Patient_pin.Clear();
                            frm_lab.Patient_pin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();

                            (Application.OpenForms["frm_lab"] as frm_lab).Search_Patient();
                            (Application.OpenForms["frm_lab"] as frm_lab).Search_Hema();
                            (Application.OpenForms["frm_lab"] as frm_lab).Search_Urinalysis();
                            (Application.OpenForms["frm_lab"] as frm_lab).Search_Fecalysis();
                            (Application.OpenForms["frm_lab"] as frm_lab).Lab_Details();
                            (Application.OpenForms["frm_lab"] as frm_lab).Availability(true);
                            fmain.ts_add_lab.Enabled = false; fmain.ts_edit_lab.Enabled = false; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = true; fmain.ts_search_lab.Enabled = false; fmain.ts_print_lab.Enabled = false; fmain.ts_cancel_lab.Enabled = true;

                            this.Close();
                        }
                        else
                        {
                            lab = true;


                        }

                    }
                    else
                    {

                        frm_lab.LabId.Clear();
                        //var i = db.sp_QueeLab_GenerateID().FirstOrDefault();
                        //frm_lab.LabId.Text = i.generated_id;
                        frm_lab.LabId.Text = System.Guid.NewGuid().ToString();

                        frm_lab.Patient_pin.Clear();
                        frm_lab.Patient_pin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();

                        (Application.OpenForms["frm_lab"] as frm_lab).Availability(true);
                        (Application.OpenForms["frm_lab"] as frm_lab).ClearAll();
                        (Application.OpenForms["frm_lab"] as frm_lab).New();
                        (Application.OpenForms["frm_lab"] as frm_lab).Search_Patient();

                        fmain.ts_add_lab.Enabled = false; fmain.ts_edit_lab.Enabled = false; fmain.ts_delete_lab.Enabled = false; fmain.ts_save_lab.Enabled = true; fmain.ts_search_lab.Enabled = false; fmain.ts_print_lab.Enabled = false; fmain.ts_cancel_lab.Enabled = true;

                        this.Close();

                    }



                }
                else if (Landbase)
                {
                    string pin = dg_result.SelectedRows[0].Cells[1].Value.ToString();

                    var cnt = db.sp_Quee_Landabase(pin.ToString()).FirstOrDefault();
                    if (cnt.PatientCount >= 1)
                    {

                        if (MessageBox.Show("Previous laboratory examination Detected! Click YES to modify or No to cancel.", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frm_MedicalExamination.newLandbase = false;
                            //frm_MedicalExamination.LabID.Clear();

                            var i = db.sp_QueeLand_putText(pin.ToString()).FirstOrDefault();
                            //frm_MedicalExamination.LabID.Text = i.resultid;
                            //frm_MedicalExamination.Text_papin.Clear();
                            //frm_MedicalExamination.Text_papin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                            (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).Search_Patient();
                            (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).Search_MedicalHistory();
                            (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).Search_PhyExam();
                            (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).Search_others();
                            (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).search_Ancillary();
                            (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).search_Recomendation();
                            (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).Availability(true);
                            //fmain.ts_add_land.Enabled = false;
                            fmain.ts_edit_land.Enabled = false; fmain.ts_delete_land.Enabled = false; fmain.ts_save_land.Enabled = true; fmain.ts_search_land.Enabled = false; fmain.ts_print_land.Enabled = false; fmain.ts_cancel_land.Enabled = true;



                            this.Close();

                        }
                        else
                        {
                            Landbase = true;


                        }

                    }
                    else
                    {
                        //frm_MedicalExamination.LabID.Clear();
                        //var i = db.sp_QueeLandbase_GenerateID().FirstOrDefault();
                        //frm_MedicalExamination.LabID.Text = i.generated_id;
                        //frm_MedicalExamination.LabID.Text = System.Guid.NewGuid().ToString();


                        //frm_MedicalExamination.Text_papin.Clear();
                        //frm_MedicalExamination.Text_papin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                        frm_MedicalExamination.Count = false;
                        (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).Availability(true);
                        (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).ClearAll();
                        (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).New();
                        //(Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).CheckedallNo(); //
                        (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).Search_Patient();

                        (Application.OpenForms["frm_MedicalExamination"] as frm_MedicalExamination).txt_result_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
                        //fmain.ts_add_land.Enabled = false;
                        fmain.ts_edit_land.Enabled = false; fmain.ts_delete_land.Enabled = false; fmain.ts_save_land.Enabled = true; fmain.ts_search_land.Enabled = false; fmain.ts_print_land.Enabled = false; fmain.ts_cancel_land.Enabled = true;


                        this.Close();


                    }



                }

                else if (xray)
                {



                    //string pin = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                    //var cnt = db.sp_Xray_Count_Column(pin.ToString(), variables.RadiologyFormType).FirstOrDefault();
                    //if (cnt.PatientCount >= 1)
                    //{

                    //    if (MessageBox.Show("Previous laboratory examination Detected! Click YES to modify or No to cancel.", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //    {
                    //        frm_xray.NewXray = false;
                    //        frm_xray.LabID.Clear();
                    //        var i = db.sp_Xray_PutText(pin.ToString(), variables.RadiologyFormType).FirstOrDefault();
                    //        frm_xray.LabID.Text = i.resultid;
                    //        frm_xray.pin.Clear();
                    //        frm_xray.pin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                    //        (Application.OpenForms["frm_xray"] as frm_xray).Search_Patient();
                    //        //(Application.OpenForms["frm_xray"] as frm_xray).search_Medical();
                    //        (Application.OpenForms["frm_xray"] as frm_xray).search_Xray();
                    //        (Application.OpenForms["frm_xray"] as frm_xray).Availability(true);
                    //        fmain.ts_add_xray.Enabled = false; fmain.ts_edit_xray.Enabled = false; fmain.ts_delete_xray.Enabled = false; fmain.ts_save_xray.Enabled = true; fmain.ts_search_xray.Enabled = false; fmain.ts_print_xray.Enabled = false; fmain.ts_cancel_xray.Enabled = true;

                    //        this.Close();
                    //    }
                    //    else
                    //    {
                    //        xray = true;


                    //    }

                    //}
                    //else
                    //{
                    //    frm_xray.LabID.Clear();
                    //    //var i = db.sp_Xray_GenerateID(variables.RadiologyFormType).FirstOrDefault();
                    //    //frm_xray.LabID.Text = i.generated_id;
                    //    frm_xray.LabID.Text = System.Guid.NewGuid().ToString();

                    //    frm_xray.pin.Clear();
                    //    frm_xray.pin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                    //    (Application.OpenForms["frm_xray"] as frm_xray).Availability(true);
                    //    (Application.OpenForms["frm_xray"] as frm_xray).ClearAll();
                    //    (Application.OpenForms["frm_xray"] as frm_xray).setDeafultValue();
                    //    (Application.OpenForms["frm_xray"] as frm_xray).Search_Patient();

                    //    fmain.ts_add_xray.Enabled = false; fmain.ts_edit_xray.Enabled = false; fmain.ts_delete_xray.Enabled = false; fmain.ts_save_xray.Enabled = true; fmain.ts_search_xray.Enabled = false; fmain.ts_print_xray.Enabled = false; fmain.ts_cancel_xray.Enabled = true;

                    //    this.Close();

                    //}



                }
                else if (Psych_Evaluation)
                {



                    string pin = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                    var cnt = db.sp_Psycho_CountColumn(pin.ToString()).FirstOrDefault();
                    if (cnt.PatientCount >= 1)
                    {

                        if (MessageBox.Show("Previous laboratory examination Detected! Click YES to modify or No to cancel.", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frm_Psych_Evaluation.NewPsych_Eval = false;
                            frm_Psych_Evaluation.LabID.Clear();
                            var i = db.sp_Psycho_PutText(pin.ToString()).FirstOrDefault();
                            frm_Psych_Evaluation.LabID.Text = i.resultid;
                            frm_Psych_Evaluation.pin.Clear();
                            frm_Psych_Evaluation.pin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();



                            (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Search_Patient();
                            (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).search_Psych();
                            (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Availability(true);
                            fmain.ts_add_Eval.Enabled = false; fmain.ts_edit_Eval.Enabled = false; fmain.ts_delete_Eval.Enabled = false; fmain.ts_save_Eval.Enabled = true; fmain.ts_search_Eval.Enabled = false; fmain.ts_print_Eval.Enabled = false; fmain.ts_cancel_Eval.Enabled = true;

                            this.Close();
                        }
                        else
                        {
                            Psych_Evaluation = true;


                        }

                    }
                    else
                    {
                        frm_Psych_Evaluation.LabID.Clear();
                        //var i = db.sp_Psycho_GenerateID().FirstOrDefault();
                        //frm_Psych_Evaluation.LabID.Text = i.generated_id;
                        frm_Psych_Evaluation.LabID.Text = System.Guid.NewGuid().ToString();
                        frm_Psych_Evaluation.pin.Clear();
                        frm_Psych_Evaluation.pin.Text = dg_result.SelectedRows[0].Cells[1].Value.ToString();
                        (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Availability(true);
                        (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).ClearAll();
                        (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).Search_Patient();
                        (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation).New();
                        fmain.ts_add_Eval.Enabled = false; fmain.ts_edit_Eval.Enabled = false; fmain.ts_delete_Eval.Enabled = false; fmain.ts_save_Eval.Enabled = true; fmain.ts_search_Eval.Enabled = false; fmain.ts_print_Eval.Enabled = false; fmain.ts_cancel_Eval.Enabled = true;

                        this.Close();

                    }





                }

                //

            }
            else
            {
                MessageBox.Show("Actione Denied! No active or Selected item", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cursor.Current = Cursors.Default;

        }

        private void frm_search_Patient_Queuing_FormClosed(object sender, FormClosedEventArgs e)
        {
            lab = false; Landbase = false; queue = false;

        }

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtmiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dg_searresult_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectItem();
        }



        private void dg_searresult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SelectItem();
            }
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            { dg_result.Select(); }
            //else if (e.KeyCode == Keys.Enter)
            //{ Searach(); }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            // FillDataGridView(txt_Search.Text);
            FillDataGridView();
        }

        private void dg_searresult_DoubleClick_1(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void dg_result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex != 0)
            {
                if (dg_result.SelectedRows.Count >= 1)
                {
                    Patient_cn = dg_result.SelectedRows[0].Cells[0].Value.ToString();

                    loadImage();
                }

            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            // FillDataGridView("%");
            this.Invoke(new MethodInvoker(delegate () {

                try
                {
                    DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                    queueSearchList_Model.Clear();
                    if (lab)
                    {
                      
                        foreach (var i in db.Search_patient_add_a("%"))
                        {
                            queueSearchList_Model.Add(new QueueSearchList_Model
                            {
                                cn = i.cn,
                                papin = i.papin,
                                PatientName = i.PatientName,
                                gender = i.gender,

                            });


                        }

                    }
                    else if (Landbase)
                    {
                        var list = db.sp_LandbaseAddList("%").ToList();
                        Cursor.Current = Cursors.WaitCursor;
                        foreach (var i in list)
                        {
                            queueSearchList_Model.Add(new QueueSearchList_Model
                            {
                                cn = i.cn,
                                papin = i.papin,
                                PatientName = i.patientName,
                                gender = i.gender

                            });


                        }
                    }
                    else if (xray)
                    {

                        var list = db.sp_XrayAdd("%");

                        foreach (var i in list)
                        {

                            queueSearchList_Model.Add(new QueueSearchList_Model
                            {
                                cn = i.cn,
                                papin = i.papin,
                                PatientName = i.PatientName,
                                gender = i.gender

                            });
                        }
                    }
                    else if (isfromVisit)
                    {
                        var list = db.Search_patient_add_a("%").ToList();
                        var count = list.Count();
                        foreach (var i in list)
                        {
                            queueSearchList_Model.Add(new QueueSearchList_Model
                            {
                                cn = i.cn,
                                papin = i.papin,
                                PatientName = i.PatientName,
                                gender = i.gender

                            });
                        }

                    }







                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured" + ex.Message, Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }




            }));

        }

        void FillDataGridView()
        {

            try
            {
               var  list = (from m in queueSearchList_Model where m.PatientName.StartsWith(txt_Search.Text) select m).ToList();
                dg_result.DataSource = list;
                dg_result.Columns[0].Visible = false;
                dg_result.Columns[1].Visible = false;
                dg_result.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg_result.Columns[3].Width = 80;
                lbl_items.Text = "Items: " + list.Count();




            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured" + ex.Message, Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


        }


        private void frm_search_Patient_Queuing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectItem();

            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }
    }
}
