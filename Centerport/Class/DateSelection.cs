using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Class
{
    public partial class DateSelection : UserControl
    {
        public DateSelection()
        {
            InitializeComponent();
        }

        private void cmd_ok_Click(object sender, EventArgs e)
        {
            variables.dateStart = monthCalendar1.SelectionRange.Start.ToShortDateString();
            variables.dateEnd = monthCalendar1.SelectionRange.End.ToShortDateString();
            this.Visible = false;
        }
    }
}
