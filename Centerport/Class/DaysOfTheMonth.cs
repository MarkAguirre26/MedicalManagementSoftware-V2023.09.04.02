using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Class
{
    class DaysOfTheMonth
    {


        public List<string> days(int y, int m)
        
        {
            List<string> d = new List<string>();
            //int[] years = { 2012, 2014 };
            DateTimeFormatInfo dtfi = DateTimeFormatInfo.CurrentInfo;
            //Console.WriteLine("Days in the Month for the {0} culture " +
            //                  "using the {1} calendar\n",
            //                  CultureInfo.CurrentCulture.Name,
            //                  dtfi.Calendar.GetType().Name.Replace("Calendar", ""));
            //Console.WriteLine("{0,-10}{1,-15}{2,4}\n", "Year", "Month", "Days");

           
                for (int ctr = 0; ctr <= dtfi.MonthNames.Length - 1; ctr++)
                {
                    if (String.IsNullOrEmpty(dtfi.MonthNames[ctr]))
                        continue;
                   

                    //Console.WriteLine("{0,-10}{1,-15}{2,4}", y,
                    //                  dtfi.MonthNames[ctr],
                    //                  DateTime.DaysInMonth(y, ctr + 1));
                    d.Add(y+" "+dtfi.MonthNames[ctr]+" "+ DateTime.DaysInMonth(y, ctr + 1));
                }


                return d;
                
            }
        
    }
}
