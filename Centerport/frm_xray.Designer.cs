namespace MedicalManagement
{
    partial class frm_xray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_speciment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_medical_cn = new System.Windows.Forms.Label();
            this.txt_AgeSex = new System.Windows.Forms.TextBox();
            this.dt_result_Date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_agency = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.overlayShadow1 = new MedicalManagement.Class.OverlayShadow();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Xray_Result_Cn = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_impression = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_findings = new System.Windows.Forms.RichTextBox();
            this.cb_normal = new System.Windows.Forms.CheckBox();
            this.txt_xrayNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExamination = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_title.Location = new System.Drawing.Point(11, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(74, 24);
            this.lbl_title.TabIndex = 16;
            this.lbl_title.Text = "Result";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 440);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_speciment);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(697, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 35);
            this.panel3.TabIndex = 2;
            // 
            // txt_speciment
            // 
            this.txt_speciment.BackColor = System.Drawing.Color.White;
            this.txt_speciment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_speciment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_speciment.Location = new System.Drawing.Point(125, 3);
            this.txt_speciment.Name = "txt_speciment";
            this.txt_speciment.Size = new System.Drawing.Size(112, 21);
            this.txt_speciment.TabIndex = 4;
            this.txt_speciment.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Arial", 9F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(59, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 262;
            this.label13.Text = "LAB. NO.:";
            this.label13.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_medical_cn);
            this.groupBox1.Controls.Add(this.txt_AgeSex);
            this.groupBox1.Controls.Add(this.dt_result_Date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_agency);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(8, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PATIENT INFORMATION";
            // 
            // lbl_medical_cn
            // 
            this.lbl_medical_cn.AutoSize = true;
            this.lbl_medical_cn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medical_cn.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_medical_cn.Location = new System.Drawing.Point(365, -8);
            this.lbl_medical_cn.Name = "lbl_medical_cn";
            this.lbl_medical_cn.Size = new System.Drawing.Size(19, 25);
            this.lbl_medical_cn.TabIndex = 294;
            this.lbl_medical_cn.Text = "-";
            this.lbl_medical_cn.Visible = false;
            // 
            // txt_AgeSex
            // 
            this.txt_AgeSex.BackColor = System.Drawing.SystemColors.Control;
            this.txt_AgeSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AgeSex.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_AgeSex.Location = new System.Drawing.Point(531, 47);
            this.txt_AgeSex.Name = "txt_AgeSex";
            this.txt_AgeSex.ReadOnly = true;
            this.txt_AgeSex.Size = new System.Drawing.Size(114, 22);
            this.txt_AgeSex.TabIndex = 258;
            // 
            // dt_result_Date
            // 
            this.dt_result_Date.CustomFormat = "MM/dd/yyyy";
            this.dt_result_Date.Font = new System.Drawing.Font("Arial", 9F);
            this.dt_result_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_result_Date.Location = new System.Drawing.Point(531, 18);
            this.dt_result_Date.Name = "dt_result_Date";
            this.dt_result_Date.ShowUpDown = true;
            this.dt_result_Date.Size = new System.Drawing.Size(112, 21);
            this.dt_result_Date.TabIndex = 1;
            this.dt_result_Date.ValueChanged += new System.EventHandler(this.dt_result_Date_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(477, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 257;
            this.label5.Text = "Age/Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(492, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 251;
            this.label3.Text = "Date:";
            // 
            // txt_agency
            // 
            this.txt_agency.BackColor = System.Drawing.SystemColors.Control;
            this.txt_agency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_agency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_agency.Location = new System.Drawing.Point(74, 46);
            this.txt_agency.Name = "txt_agency";
            this.txt_agency.ReadOnly = true;
            this.txt_agency.Size = new System.Drawing.Size(385, 22);
            this.txt_agency.TabIndex = 250;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_name.Location = new System.Drawing.Point(74, 20);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(385, 22);
            this.txt_name.TabIndex = 249;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 246;
            this.label1.Text = "Company:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Arial", 9F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(24, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 15);
            this.label24.TabIndex = 245;
            this.label24.Text = "Name:";
            // 
            // overlayShadow1
            // 
            this.overlayShadow1.Location = new System.Drawing.Point(0, 0);
            this.overlayShadow1.Name = "overlayShadow1";
            this.overlayShadow1.Size = new System.Drawing.Size(275, 27);
            this.overlayShadow1.TabIndex = 297;
            this.overlayShadow1.Click += new System.EventHandler(this.overlayShadow1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExamination);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_Xray_Result_Cn);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txt_xrayNo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(9, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 292);
            this.groupBox2.TabIndex = 298;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "X-RAY RESULT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 264;
            this.label2.Text = " Examination:";
            // 
            // lbl_Xray_Result_Cn
            // 
            this.lbl_Xray_Result_Cn.AutoSize = true;
            this.lbl_Xray_Result_Cn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Xray_Result_Cn.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Xray_Result_Cn.Location = new System.Drawing.Point(377, 17);
            this.lbl_Xray_Result_Cn.Name = "lbl_Xray_Result_Cn";
            this.lbl_Xray_Result_Cn.Size = new System.Drawing.Size(202, 25);
            this.lbl_Xray_Result_Cn.TabIndex = 294;
            this.lbl_Xray_Result_Cn.Text = "lbl_Xray_Result_Cn";
            this.lbl_Xray_Result_Cn.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_impression);
            this.groupBox4.Location = new System.Drawing.Point(5, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(876, 112);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "*Impression";
            // 
            // txt_impression
            // 
            this.txt_impression.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_impression.Location = new System.Drawing.Point(9, 20);
            this.txt_impression.Name = "txt_impression";
            this.txt_impression.Size = new System.Drawing.Size(856, 86);
            this.txt_impression.TabIndex = 7;
            this.txt_impression.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_findings);
            this.groupBox3.Controls.Add(this.cb_normal);
            this.groupBox3.Location = new System.Drawing.Point(5, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "*Radiology Findings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 256;
            this.label8.Text = "REMARK";
            // 
            // txt_findings
            // 
            this.txt_findings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_findings.Location = new System.Drawing.Point(9, 20);
            this.txt_findings.Name = "txt_findings";
            this.txt_findings.Size = new System.Drawing.Size(856, 58);
            this.txt_findings.TabIndex = 6;
            this.txt_findings.Text = "";
            // 
            // cb_normal
            // 
            this.cb_normal.AutoSize = true;
            this.cb_normal.Location = new System.Drawing.Point(73, 87);
            this.cb_normal.Name = "cb_normal";
            this.cb_normal.Size = new System.Drawing.Size(67, 19);
            this.cb_normal.TabIndex = 7;
            this.cb_normal.Text = "Normal";
            this.cb_normal.UseVisualStyleBackColor = true;
            // 
            // txt_xrayNo
            // 
            this.txt_xrayNo.BackColor = System.Drawing.Color.White;
            this.txt_xrayNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_xrayNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xrayNo.Location = new System.Drawing.Point(750, 17);
            this.txt_xrayNo.Name = "txt_xrayNo";
            this.txt_xrayNo.Size = new System.Drawing.Size(120, 21);
            this.txt_xrayNo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(719, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 256;
            this.label6.Text = "No.:";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Note: You can\'t open the UTZ, XRAY and ECG form at the same time.";
            // 
            // txtExamination
            // 
            this.txtExamination.BackColor = System.Drawing.Color.White;
            this.txtExamination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExamination.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamination.Location = new System.Drawing.Point(108, 19);
            this.txtExamination.Name = "txtExamination";
            this.txtExamination.Size = new System.Drawing.Size(120, 21);
            this.txtExamination.TabIndex = 295;
            // 
            // frm_xray
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(922, 485);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.overlayShadow1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_xray";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_xray_FormClosing);
            this.Load += new System.EventHandler(this.frm_xray_Load);
            this.Enter += new System.EventHandler(this.frm_xray_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_xray_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_AgeSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_agency;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_speciment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dt_result_Date;
        private Class.OverlayShadow overlayShadow1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.CheckBox cb_normal;
        private System.Windows.Forms.Label lbl_medical_cn;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Xray_Result_Cn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox txt_impression;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txt_findings;
        private System.Windows.Forms.TextBox txt_xrayNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExamination;
    }
}