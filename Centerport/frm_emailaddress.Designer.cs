namespace MedicalManagement
{
    partial class frm_emailaddress
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmd_send = new System.Windows.Forms.Button();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.lbl_validate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 131);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmd_send
            // 
            this.cmd_send.Enabled = false;
            this.cmd_send.Location = new System.Drawing.Point(137, 24);
            this.cmd_send.Name = "cmd_send";
            this.cmd_send.Size = new System.Drawing.Size(159, 36);
            this.cmd_send.TabIndex = 1;
            this.cmd_send.Text = "Send";
            this.cmd_send.UseVisualStyleBackColor = true;
            this.cmd_send.Click += new System.EventHandler(this.cmd_send_Click);
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_cancel.Location = new System.Drawing.Point(303, 24);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(123, 36);
            this.cmd_cancel.TabIndex = 2;
            this.cmd_cancel.Text = "Cancel";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // lbl_validate
            // 
            this.lbl_validate.AutoSize = true;
            this.lbl_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_validate.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_validate.Location = new System.Drawing.Point(14, 211);
            this.lbl_validate.Name = "lbl_validate";
            this.lbl_validate.Size = new System.Drawing.Size(147, 18);
            this.lbl_validate.TabIndex = 3;
            this.lbl_validate.Text = "Invalid email address!";
            this.lbl_validate.Visible = false;
            // 
            // frm_emailaddress
            // 
            this.AcceptButton = this.cmd_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmd_cancel;
            this.ClientSize = new System.Drawing.Size(438, 239);
            this.Controls.Add(this.lbl_validate);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_send);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_emailaddress";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter email address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmd_send;
        private System.Windows.Forms.Button cmd_cancel;
        private System.Windows.Forms.Label lbl_validate;
    }
}