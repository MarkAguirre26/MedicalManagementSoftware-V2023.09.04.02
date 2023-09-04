namespace MedicalManagement
{
    partial class FrmReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cboReportType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboReportCategory = new System.Windows.Forms.ComboBox();
            this.cboLabTest = new System.Windows.Forms.ComboBox();
            this.cboMonths = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboWeekNumber = new System.Windows.Forms.ComboBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cboReportType
            // 
            this.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportType.FormattingEnabled = true;
            this.cboReportType.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.cboReportType.Location = new System.Drawing.Point(392, 3);
            this.cboReportType.Name = "cboReportType";
            this.cboReportType.Size = new System.Drawing.Size(100, 21);
            this.cboReportType.TabIndex = 0;
            this.cboReportType.SelectedIndexChanged += new System.EventHandler(this.cboFilterCategory_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.cboReportCategory);
            this.flowLayoutPanel1.Controls.Add(this.cboLabTest);
            this.flowLayoutPanel1.Controls.Add(this.cboReportType);
            this.flowLayoutPanel1.Controls.Add(this.cboMonths);
            this.flowLayoutPanel1.Controls.Add(this.cboYear);
            this.flowLayoutPanel1.Controls.Add(this.cboWeekNumber);
            this.flowLayoutPanel1.Controls.Add(this.cmdSearch);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(883, 28);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter:";
            // 
            // cboReportCategory
            // 
            this.cboReportCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportCategory.FormattingEnabled = true;
            this.cboReportCategory.Items.AddRange(new object[] {
            "Maximum number of clients",
            "Laboratory Test Delay",
            "Profitable Package/Laboratory Test"});
            this.cboReportCategory.Location = new System.Drawing.Point(41, 3);
            this.cboReportCategory.Name = "cboReportCategory";
            this.cboReportCategory.Size = new System.Drawing.Size(239, 21);
            this.cboReportCategory.TabIndex = 7;
            this.cboReportCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboLabTest
            // 
            this.cboLabTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLabTest.FormattingEnabled = true;
            this.cboLabTest.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.cboLabTest.Location = new System.Drawing.Point(286, 3);
            this.cboLabTest.Name = "cboLabTest";
            this.cboLabTest.Size = new System.Drawing.Size(100, 21);
            this.cboLabTest.TabIndex = 11;
            this.cboLabTest.Visible = false;
            // 
            // cboMonths
            // 
            this.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonths.FormattingEnabled = true;
            this.cboMonths.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.cboMonths.Location = new System.Drawing.Point(498, 3);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Size = new System.Drawing.Size(100, 21);
            this.cboMonths.TabIndex = 8;
            this.cboMonths.Visible = false;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
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
            "2033"});
            this.cboYear.Location = new System.Drawing.Point(604, 3);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(79, 21);
            this.cboYear.TabIndex = 9;
            this.cboYear.Visible = false;
            // 
            // cboWeekNumber
            // 
            this.cboWeekNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeekNumber.FormattingEnabled = true;
            this.cboWeekNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboWeekNumber.Location = new System.Drawing.Point(689, 3);
            this.cboWeekNumber.Name = "cboWeekNumber";
            this.cboWeekNumber.Size = new System.Drawing.Size(79, 21);
            this.cboWeekNumber.TabIndex = 10;
            this.cboWeekNumber.Visible = false;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSearch.Location = new System.Drawing.Point(774, 3);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 5;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdPrint);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 39);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPrint.Location = new System.Drawing.Point(896, 11);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(75, 23);
            this.cmdPrint.TabIndex = 4;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // chartReport
            // 
            this.chartReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReport.Legends.Add(legend1);
            this.chartReport.Location = new System.Drawing.Point(9, 57);
            this.chartReport.Name = "chartReport";
            this.chartReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReport.Series.Add(series1);
            this.chartReport.Size = new System.Drawing.Size(977, 419);
            this.chartReport.TabIndex = 12;
            this.chartReport.Text = "chart1";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 488);
            this.Controls.Add(this.chartReport);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboReportType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboReportCategory;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.ComboBox cboMonths;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboWeekNumber;
        private System.Windows.Forms.ComboBox cboLabTest;
    }
}