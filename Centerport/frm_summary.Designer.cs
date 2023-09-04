namespace MedicalManagement
{
    partial class frm_summary
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_items = new System.Windows.Forms.Label();
            this.cmd_download = new System.Windows.Forms.Button();
            this.cmd_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmd_loadEmployer = new System.Windows.Forms.Button();
            this.txt_employer = new System.Windows.Forms.TextBox();
            this.cmd_send = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(1, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(997, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employer:";
            // 
            // lbl_items
            // 
            this.lbl_items.AutoSize = true;
            this.lbl_items.Location = new System.Drawing.Point(6, 466);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(44, 13);
            this.lbl_items.TabIndex = 3;
            this.lbl_items.Text = "Items: 0";
            // 
            // cmd_download
            // 
            this.cmd_download.Enabled = false;
            this.cmd_download.Location = new System.Drawing.Point(896, 11);
            this.cmd_download.Name = "cmd_download";
            this.cmd_download.Size = new System.Drawing.Size(75, 23);
            this.cmd_download.TabIndex = 4;
            this.cmd_download.Text = "Download";
            this.cmd_download.UseVisualStyleBackColor = true;
            this.cmd_download.Click += new System.EventHandler(this.cmd_download_Click);
            // 
            // cmd_search
            // 
            this.cmd_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_search.Location = new System.Drawing.Point(616, 11);
            this.cmd_search.Name = "cmd_search";
            this.cmd_search.Size = new System.Drawing.Size(75, 23);
            this.cmd_search.TabIndex = 5;
            this.cmd_search.Text = "Search";
            this.cmd_search.UseVisualStyleBackColor = true;
            this.cmd_search.Click += new System.EventHandler(this.cmd_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmd_loadEmployer);
            this.groupBox1.Controls.Add(this.txt_employer);
            this.groupBox1.Controls.Add(this.cmd_send);
            this.groupBox1.Controls.Add(this.cmd_search);
            this.groupBox1.Controls.Add(this.cmd_download);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 40);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cmd_loadEmployer
            // 
            this.cmd_loadEmployer.Location = new System.Drawing.Point(574, 11);
            this.cmd_loadEmployer.Name = "cmd_loadEmployer";
            this.cmd_loadEmployer.Size = new System.Drawing.Size(36, 23);
            this.cmd_loadEmployer.TabIndex = 9;
            this.cmd_loadEmployer.Text = "...";
            this.cmd_loadEmployer.UseVisualStyleBackColor = true;
            this.cmd_loadEmployer.Click += new System.EventHandler(this.cmd_loadEmployer_Click);
            // 
            // txt_employer
            // 
            this.txt_employer.Location = new System.Drawing.Point(64, 12);
            this.txt_employer.Name = "txt_employer";
            this.txt_employer.ReadOnly = true;
            this.txt_employer.Size = new System.Drawing.Size(508, 20);
            this.txt_employer.TabIndex = 8;
            // 
            // cmd_send
            // 
            this.cmd_send.Enabled = false;
            this.cmd_send.Location = new System.Drawing.Point(773, 11);
            this.cmd_send.Name = "cmd_send";
            this.cmd_send.Size = new System.Drawing.Size(120, 23);
            this.cmd_send.TabIndex = 7;
            this.cmd_send.Text = "Send as Attachment";
            this.cmd_send.UseVisualStyleBackColor = true;
            this.cmd_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(140, 462);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(858, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // frm_summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 488);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_items);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1014, 527);
            this.MinimumSize = new System.Drawing.Size(1014, 527);
            this.Name = "frm_summary";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consolidate";
            this.Load += new System.EventHandler(this.frm_summary_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_summary_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_items;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cmd_loadEmployer;
        public System.Windows.Forms.TextBox txt_employer;
        public System.Windows.Forms.Button cmd_download;
        public System.Windows.Forms.Button cmd_search;
        public System.Windows.Forms.Button cmd_send;
    }
}