using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Print
{
   public class HematologyModel
    {

        public string Name { get; set; }
        public string Company { get; set; }
        public string Date { get; set; }
        public string AgeSex { get; set; }

        public string HeaderAddress { get; set; }
        public string HeaderContact { get; set; }



        public string Redbloodcells { get; set; }
        public string Hemoglobin { get; set; }
        public string Hematocrit { get; set; }
        public string Plateletcount { get; set; }
        public string Whitebloodcells { get; set; }
        public string Neutrophil { get; set; }
        public string Lymphocyte { get; set; }
        public string Monocyte { get; set; }
        public string Eosinophil { get; set; }
        public string Basophil { get; set; }
        public string Others { get; set; }


        public string Rmt_Name { get; set; }

        public string Rmt_License { get; set; }
        public string Address2 { get; set; }

    }
}
