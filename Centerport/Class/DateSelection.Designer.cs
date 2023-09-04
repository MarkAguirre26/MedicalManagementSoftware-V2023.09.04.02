namespace MedicalManagement.Class
{
    partial class DateSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmd_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.MaxSelectionCount = 366;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // cmd_ok
            // 
            this.cmd_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_ok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmd_ok.Location = new System.Drawing.Point(0, 163);
            this.cmd_ok.Name = "cmd_ok";
            this.cmd_ok.Size = new System.Drawing.Size(228, 23);
            this.cmd_ok.TabIndex = 1;
            this.cmd_ok.Text = "Select";
            this.cmd_ok.UseVisualStyleBackColor = true;
            this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
            // 
            // DateSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cmd_ok);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "DateSelection";
            this.Size = new System.Drawing.Size(228, 186);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button cmd_ok;
    }
}
