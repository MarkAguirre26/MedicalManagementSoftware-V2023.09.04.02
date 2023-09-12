using MedicalManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    public partial class frm_emailaddress : Form
    {
        private List<Summary> summaryList = new List<Summary>();
        public frm_emailaddress()
        {
            InitializeComponent();
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (textBox1.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(textBox1.Text.Trim()))

                {
                    // MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_validate.Visible = true;
                    cmd_send.Enabled = false;
                    textBox1.Focus();

                }
                else
                {
                    lbl_validate.Visible = false;
                    cmd_send.Enabled = true;
                }

            }
            else
            {
                lbl_validate.Visible = false;
                cmd_send.Enabled = false;
            }
        }

        private void cmd_send_Click(object sender, EventArgs e)
        {
          
          sendEmail();
            this.Close();
        }

        public void sendEmail()
        {

            try
            {

                Random rand = new Random();
                int r = rand.Next(1, 500);
                string source = TemplatePath.basePath + @"Source\ListOfPatients-TEMPLATE.xlsx";
                string file = TemplatePath.basePath + "ListOfPatients-TEMPLATE" + "_" + r + ".xlsx";


                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                File.Copy(source, file);

                Reporting.Export(file.Replace(".xlsx", ""), summaryList, false);




              
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("markaguirre26@gmail.com");
                mail.To.Add("mark.aguirre@gamosatechnologysolutions.com");
                mail.Subject = "file";
                var filename = file;
                mail.Attachments.Add(new Attachment(filename));
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new
                System.Net.NetworkCredential("markaguirre26@gmail.com", "SoMMersOn26");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

             


                MessageBox.Show("Email sent", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
                return;
            }




        }

        private void frm_emailaddress_Load(object sender, EventArgs e)
        {

        }
    }
}
