namespace MedicalManagement.Print
{
    partial class FrmRadiographicalReport
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
            this.ReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportViewer1
            // 
            this.ReportViewer1.ActiveViewIndex = -1;
            this.ReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewer1.DisplayStatusBar = false;
            this.ReportViewer1.DisplayToolbar = false;
            this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer1.Name = "ReportViewer1";
            this.ReportViewer1.ShowCloseButton = false;
            this.ReportViewer1.ShowCopyButton = false;
            this.ReportViewer1.ShowExportButton = false;
            this.ReportViewer1.ShowGotoPageButton = false;
            this.ReportViewer1.ShowGroupTreeButton = false;
            this.ReportViewer1.ShowLogo = false;
            this.ReportViewer1.ShowPageNavigateButtons = false;
            this.ReportViewer1.ShowParameterPanelButton = false;
            this.ReportViewer1.ShowPrintButton = false;
            this.ReportViewer1.ShowRefreshButton = false;
            this.ReportViewer1.ShowTextSearchButton = false;
            this.ReportViewer1.ShowZoomButton = false;
            this.ReportViewer1.Size = new System.Drawing.Size(908, 431);
            this.ReportViewer1.TabIndex = 1;
            this.ReportViewer1.TabStop = false;
            this.ReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(795, 448);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(102, 32);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrint.Location = new System.Drawing.Point(667, 448);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(102, 32);
            this.cmdPrint.TabIndex = 3;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // FrmRadiographicalReport
            // 
            this.AcceptButton = this.cmdPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(909, 502);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.ReportViewer1);
            this.MinimizeBox = false;
            this.Name = "FrmRadiographicalReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Radiographical Report";
            this.Load += new System.EventHandler(this.FrmRadiographicalReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewer1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdPrint;
    }
}