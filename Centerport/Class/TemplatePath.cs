using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Class
{
    public class TemplatePath
    {
        //  public static string basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"MMSDATA\Template\");
        public static string pdfPath = "";
        public static string basePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"MMSDATA\Template\");

    }
}
