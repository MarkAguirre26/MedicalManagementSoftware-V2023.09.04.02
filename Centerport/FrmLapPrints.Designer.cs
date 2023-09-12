namespace MedicalManagement
{
    partial class FrmLapPrints
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdBloodTyping = new System.Windows.Forms.Button();
            this.cmdUrinalysis = new System.Windows.Forms.Button();
            this.cmdSerology = new System.Windows.Forms.Button();
            this.cmdHematology = new System.Windows.Forms.Button();
            this.cmdHBa1C = new System.Windows.Forms.Button();
            this.cmdFecalysis = new System.Windows.Forms.Button();
            this.cmdClinicalChemistry = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmdBloodTyping, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmdUrinalysis, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdSerology, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdHematology, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdHBa1C, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdFecalysis, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmdClinicalChemistry, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmdBloodTyping
            // 
            this.cmdBloodTyping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBloodTyping.Location = new System.Drawing.Point(3, 129);
            this.cmdBloodTyping.Name = "cmdBloodTyping";
            this.cmdBloodTyping.Size = new System.Drawing.Size(135, 36);
            this.cmdBloodTyping.TabIndex = 1;
            this.cmdBloodTyping.Text = "Blood Typing";
            this.cmdBloodTyping.UseVisualStyleBackColor = true;
            this.cmdBloodTyping.Click += new System.EventHandler(this.cmdBloodTyping_Click);
            // 
            // cmdUrinalysis
            // 
            this.cmdUrinalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdUrinalysis.Location = new System.Drawing.Point(3, 3);
            this.cmdUrinalysis.Name = "cmdUrinalysis";
            this.cmdUrinalysis.Size = new System.Drawing.Size(135, 36);
            this.cmdUrinalysis.TabIndex = 0;
            this.cmdUrinalysis.Text = "Urinalysis";
            this.cmdUrinalysis.UseVisualStyleBackColor = true;
            this.cmdUrinalysis.Click += new System.EventHandler(this.cmdUrinalysis_Click);
            // 
            // cmdSerology
            // 
            this.cmdSerology.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSerology.Location = new System.Drawing.Point(145, 3);
            this.cmdSerology.Name = "cmdSerology";
            this.cmdSerology.Size = new System.Drawing.Size(135, 36);
            this.cmdSerology.TabIndex = 1;
            this.cmdSerology.Text = "Serology";
            this.cmdSerology.UseVisualStyleBackColor = true;
            this.cmdSerology.Click += new System.EventHandler(this.cmdSerology_Click);
            // 
            // cmdHematology
            // 
            this.cmdHematology.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdHematology.Location = new System.Drawing.Point(3, 45);
            this.cmdHematology.Name = "cmdHematology";
            this.cmdHematology.Size = new System.Drawing.Size(135, 36);
            this.cmdHematology.TabIndex = 2;
            this.cmdHematology.Text = "Hematology";
            this.cmdHematology.UseVisualStyleBackColor = true;
            this.cmdHematology.Click += new System.EventHandler(this.cmdHematology_Click);
            // 
            // cmdHBa1C
            // 
            this.cmdHBa1C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdHBa1C.Location = new System.Drawing.Point(145, 45);
            this.cmdHBa1C.Name = "cmdHBa1C";
            this.cmdHBa1C.Size = new System.Drawing.Size(135, 36);
            this.cmdHBa1C.TabIndex = 3;
            this.cmdHBa1C.Text = "HBa1C";
            this.cmdHBa1C.UseVisualStyleBackColor = true;
            this.cmdHBa1C.Click += new System.EventHandler(this.cmdHBa1C_Click);
            // 
            // cmdFecalysis
            // 
            this.cmdFecalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdFecalysis.Location = new System.Drawing.Point(3, 87);
            this.cmdFecalysis.Name = "cmdFecalysis";
            this.cmdFecalysis.Size = new System.Drawing.Size(135, 36);
            this.cmdFecalysis.TabIndex = 4;
            this.cmdFecalysis.Text = "Fecalysis";
            this.cmdFecalysis.UseVisualStyleBackColor = true;
            this.cmdFecalysis.Click += new System.EventHandler(this.cmdFecalysis_Click);
            // 
            // cmdClinicalChemistry
            // 
            this.cmdClinicalChemistry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClinicalChemistry.Location = new System.Drawing.Point(145, 87);
            this.cmdClinicalChemistry.Name = "cmdClinicalChemistry";
            this.cmdClinicalChemistry.Size = new System.Drawing.Size(135, 36);
            this.cmdClinicalChemistry.TabIndex = 5;
            this.cmdClinicalChemistry.Text = "Clinical Chemistry";
            this.cmdClinicalChemistry.UseVisualStyleBackColor = true;
            this.cmdClinicalChemistry.Click += new System.EventHandler(this.cmdClinicalChemistry_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(145, 129);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 36);
            this.button8.TabIndex = 6;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // FrmLapPrints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 211);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 211);
            this.Name = "FrmLapPrints";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Laboratory Results";
            this.Load += new System.EventHandler(this.FrmLapPrints_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLapPrints_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmdUrinalysis;
        private System.Windows.Forms.Button cmdSerology;
        private System.Windows.Forms.Button cmdHematology;
        private System.Windows.Forms.Button cmdHBa1C;
        private System.Windows.Forms.Button cmdFecalysis;
        private System.Windows.Forms.Button cmdClinicalChemistry;
        private System.Windows.Forms.Button cmdBloodTyping;
        private System.Windows.Forms.Button button8;
    }
}