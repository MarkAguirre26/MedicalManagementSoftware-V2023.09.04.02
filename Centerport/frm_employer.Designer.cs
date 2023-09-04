namespace MedicalManagement
{
    partial class frm_employer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_employer = new System.Windows.Forms.TextBox();
            this.cmd_action = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employer Name";
            // 
            // txt_employer
            // 
            this.txt_employer.Location = new System.Drawing.Point(4, 31);
            this.txt_employer.Name = "txt_employer";
            this.txt_employer.Size = new System.Drawing.Size(274, 20);
            this.txt_employer.TabIndex = 2;
            this.txt_employer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmd_action
            // 
            this.cmd_action.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_action.Location = new System.Drawing.Point(284, 29);
            this.cmd_action.Name = "cmd_action";
            this.cmd_action.Size = new System.Drawing.Size(42, 23);
            this.cmd_action.TabIndex = 3;
            this.cmd_action.Text = "Add";
            this.cmd_action.UseVisualStyleBackColor = true;
            this.cmd_action.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(-8, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "___________________________________________________________________";
            // 
            // cmd_close
            // 
            this.cmd_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_close.Location = new System.Drawing.Point(250, 377);
            this.cmd_close.Name = "cmd_close";
            this.cmd_close.Size = new System.Drawing.Size(75, 23);
            this.cmd_close.TabIndex = 4;
            this.cmd_close.Text = "Close";
            this.cmd_close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_close.UseVisualStyleBackColor = true;
            this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.ContextMenuStrip = this.cms1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(4, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(329, 311);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cn";
            this.Column1.HeaderText = "cn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Employer";
            this.Column2.HeaderText = "Employer";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(114, 54);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmdSelect
            // 
            this.cmdSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSelect.Location = new System.Drawing.Point(105, 377);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(134, 23);
            this.cmdSelect.TabIndex = 6;
            this.cmdSelect.Text = "&Select";
            this.cmdSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frm_employer
            // 
            this.AcceptButton = this.cmdSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmd_close;
            this.ClientSize = new System.Drawing.Size(337, 412);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmd_close);
            this.Controls.Add(this.cmd_action);
            this.Controls.Add(this.txt_employer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(353, 347);
            this.Name = "frm_employer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employer";
            this.Load += new System.EventHandler(this.frm_employer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_employer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cms1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_employer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button cmdSelect;
        public System.Windows.Forms.Button cmd_action;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}