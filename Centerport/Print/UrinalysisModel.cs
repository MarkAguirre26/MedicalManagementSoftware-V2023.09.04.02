using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Print
{
   public class UrinalysisModel
    {

        public string Name { get; set; }
        public string Company { get; set; }
        public string Date { get; set; }
        public string AgeSex { get; set; }



        public string HeaderAddress { get; set; }
        public string HeaderContact { get; set; }
        public string Color { get; set; }
        public string Transparency { get; set; }
        public string SpecificGravity { get; set; }
        public string pH { get; set; }
        public string Glucose { get; set; }
        public string Protein { get; set; }
        public string WhiteBloodCells { get; set; }
        public string RedBloodCells { get; set; }
        public string EpithelialCells { get; set; }
        public string MucusThreads { get; set; }
        public string Bacteria { get; set; }
        public string AmorphousUrates { get; set; }
        public string AmorphousPhosphates { get; set; }
        public string Other { get; set; }
    }
}
