﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Class
{
   public class Seabase_SearchList_Model
    {
        public int cn { get; set; }
        public string papin { get; set; }
        public string resultID { get; set; }
        public string patientName { get; set; }

        public string resultDate { get; set; }
        public string recommendation { get; set; }
    }
}