using Ini;

using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MedicalManagement.Class
{
    public class Reporting
    {

        public static byte[] img;
        public static void Write(string filename, string[] workSheetCells, string[] workSheetValue)
        {

            Tool.DeleteTemporaryFilesFromTemplate(TemplatePath.basePath);




            string source = TemplatePath.basePath + @"Source\" + filename + ".xlsx";
            string fileDestination = TemplatePath.basePath + filename + ".xlsx";
            if (File.Exists(fileDestination))
            {
                File.Delete(fileDestination);
            }
            File.Copy(source, fileDestination);








            try
            {

              

                //WRITE ALL VALUES TO EXCEL
                //  string basepath = TemplatePath.basePath;
                var Filee = new FileInfo(fileDestination);

                using (ExcelPackage package = new ExcelPackage(Filee))
                {
                    ExcelWorkbook workBook = package.Workbook;
                    if (workBook != null)
                    {
                        if (workBook.Worksheets.Count > 0)
                        {
                            OfficeOpenXml.ExcelWorksheet s = workBook.Worksheets.First();
                            Datas d = new Datas();
                            for (int i = 0; i < workSheetCells.Length; i++)
                            {
                                s.Cells[workSheetCells[i]].Value = workSheetValue[i] ?? "";

                            }







                            if (fileDestination.Contains("Pre-Employment Medical Exam-TEMPLATE"))
                            {
                                System.Drawing.Color colFromHex = System.Drawing.ColorTranslator.FromHtml("#64bbd2");
                                System.Drawing.Color colFromHexNone = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                                s.Cells["B86"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                s.Cells["B86"].Style.Fill.BackgroundColor.SetColor(colFromHexNone);
                                s.Cells["B87"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                s.Cells["B87"].Style.Fill.BackgroundColor.SetColor(colFromHexNone);
                                s.Cells["B88"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                s.Cells["B88"].Style.Fill.BackgroundColor.SetColor(colFromHexNone);
                                s.Cells["B89"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                s.Cells["B89"].Style.Fill.BackgroundColor.SetColor(colFromHexNone);
                                s.Cells["B90"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                s.Cells["B90"].Style.Fill.BackgroundColor.SetColor(colFromHexNone);

                                if (Datas.classificationA.Contains("Class A: "))
                                {

                                    s.Cells["B86"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                    s.Cells["B86"].Style.Fill.BackgroundColor.SetColor(colFromHex);

                                }
                                else if (Datas.classificationA.Contains("Class B: "))
                                {

                                    s.Cells["B87"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                    s.Cells["B87"].Style.Fill.BackgroundColor.SetColor(colFromHex);

                                }
                                else if (Datas.classificationA.Contains("Class C: "))
                                {
                                    s.Cells["B88"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                    s.Cells["B88"].Style.Fill.BackgroundColor.SetColor(colFromHex);
                                }
                                else if (Datas.classificationA.Contains("Pending"))
                                {
                                    s.Cells["B89"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                    s.Cells["B89"].Style.Fill.BackgroundColor.SetColor(colFromHex);
                                }
                                else if (Datas.classificationA.Contains("Unfit"))
                                {
                                    s.Cells["B90"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                    s.Cells["B90"].Style.Fill.BackgroundColor.SetColor(colFromHex);
                                }

                            }

                        }
                    }

                    package.Save();
                    Process.Start(fileDestination);

                 

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message here", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        internal static void Export(string v1, object summaryList, bool v2)
        {
            throw new NotImplementedException();
        }

        public static void Export(string filename, List<Summary> summary, bool isDownload)
        {
            try
            {

                string excelFilename = filename + ".xlsx";
                string pdfFilename = filename + ".pdf";


                //WRITE ALL VALUES TO EXCEL
                //  string basepath = TemplatePath.basePath;
                var File = new FileInfo(excelFilename);

                using (ExcelPackage package = new ExcelPackage(File))
                {
                    ExcelWorkbook workBook = package.Workbook;
                    if (workBook != null)
                    {
                        if (workBook.Worksheets.Count > 0)
                        {
                            OfficeOpenXml.ExcelWorksheet workSheet = workBook.Worksheets.First();
                            IniFile ini = new IniFile(ClassSql.MMS_Path);
                            int rowIndex = Convert.ToInt32(ini.IniReadValue("ROW", "Start"));
                            int recordIndex = rowIndex;
                            int rowNo = 1;
                            foreach (var i in summary)
                            {
                                workSheet.Cells[recordIndex, 1].Value = rowNo;
                                workSheet.Cells[recordIndex, 2].Value = i.Lastname;
                                workSheet.Cells[recordIndex, 3].Value = i.Firstname;
                                workSheet.Cells[recordIndex, 4].Value = i.gender;
                                workSheet.Cells[recordIndex, 5].Value = i.Contact;
                                workSheet.Cells[recordIndex, 6].Value = i.employer;
                                workSheet.Cells[recordIndex, 7].Value = i.birthdate;
                                workSheet.Cells[recordIndex, 8].Value = i.age;
                                workSheet.Cells[recordIndex, 9].Value = i.BP;
                                workSheet.Cells[recordIndex, 10].Value = i.BMI_Value;
                                workSheet.Cells[recordIndex, 11].Value = i.BMI_Remark;
                                workSheet.Cells[recordIndex, 12].Value = i.OD_With_o_Glasses;
                                workSheet.Cells[recordIndex, 13].Value = i.OS_With_o_Glasses;
                                workSheet.Cells[recordIndex, 14].Value = i.OD_With_Glasses;
                                workSheet.Cells[recordIndex, 15].Value = i.OS_With_Glasses;
                                workSheet.Cells[recordIndex, 16].Value = i.BloodType_result;
                                workSheet.Cells[recordIndex, 17].Value = i.Hema;
                                workSheet.Cells[recordIndex, 18].Value = i.Urinalysis;
                                workSheet.Cells[recordIndex, 19].Value = i.Fecalysis;
                                workSheet.Cells[recordIndex, 20].Value = i.Xray;
                                workSheet.Cells[recordIndex, 21].Value = i.Ecg;
                                workSheet.Cells[recordIndex, 22].Value = i.Class;
                                workSheet.Cells[recordIndex, 23].Value = i.Evaluation;
                                workSheet.Cells[recordIndex, 24].Value = i.remarks;
                                workSheet.Cells[recordIndex, 25].Value = i.recommendation;
                                workSheet.Cells[recordIndex, 26].Value = i.result_date;

                                recordIndex++;
                                rowNo++;
                            }


                        }
                    }
                    package.Save();

                    if (isDownload)
                    {
                        MessageBox.Show("Please use the SAVE AS feature of microsoft excel!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.Start(excelFilename);
                    }




                    //if (MessageBox.Show("Would you like to open the REPORT in MICROSOFT EXCEL application?", "Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    //    Process.Start(excelFilename);
                    //}
                    //else
                    //{

                    //    //CONVERT excel  TO PDF
                    //    GemBox.Spreadsheet.SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY"); //THIS LIBRARY IS FIRST 150 EXCEL ROWS ARE FREE
                    //    GemBox.Spreadsheet.ExcelFile ef = GemBox.Spreadsheet.ExcelFile.Load(File.ToString());
                    //    ef.Save(pdfFilename);
                    //    TemplatePath.pdfPath = pdfFilename;
                    //    new frm_printPreview().ShowDialog();
                    //}


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void ExportVisit(string filename, List<visitModel> model)
        {
            try
            {

                string excelFilename = filename + ".xlsx";
                string pdfFilename = filename + ".pdf";


                //WRITE ALL VALUES TO EXCEL
                //  string basepath = TemplatePath.basePath;
                var File = new FileInfo(excelFilename);

                using (ExcelPackage package = new ExcelPackage(File))
                {
                    ExcelWorkbook workBook = package.Workbook;
                    if (workBook != null)
                    {
                        if (workBook.Worksheets.Count > 0)
                        {
                            OfficeOpenXml.ExcelWorksheet workSheet = workBook.Worksheets.First();
                            IniFile ini = new IniFile(ClassSql.MMS_Path);
                            int rowIndex = Convert.ToInt32(ini.IniReadValue("ROW", "Start"));
                            int recordIndex = rowIndex;
                            int rowNo = 1;
                            foreach (var i in model)
                            {
                                workSheet.Cells[recordIndex, 1].Value = rowNo.ToString();
                                workSheet.Cells[recordIndex, 2].Value = i.papin;
                                workSheet.Cells[recordIndex, 3].Value = i.PatientName;
                                workSheet.Cells[recordIndex, 4].Value = i.Gender;
                                workSheet.Cells[recordIndex, 5].Value = i.Type;
                                workSheet.Cells[recordIndex, 6].Value = i.Date;
                                recordIndex++;
                                rowNo++;
                            }


                        }
                    }
                    package.Save();
                    //  MessageBox.Show("Please use the SAVE AS feature of microsoft excel!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(excelFilename);



                    //if (MessageBox.Show("Would you like to open the REPORT in MICROSOFT EXCEL application?", "Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    //    Process.Start(excelFilename);
                    //}
                    //else
                    //{

                    //    //CONVERT excel  TO PDF
                    //    GemBox.Spreadsheet.SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY"); //THIS LIBRARY IS FIRST 150 EXCEL ROWS ARE FREE
                    //    GemBox.Spreadsheet.ExcelFile ef = GemBox.Spreadsheet.ExcelFile.Load(File.ToString());
                    //    ef.Save(pdfFilename);
                    //    TemplatePath.pdfPath = pdfFilename;

                    //}


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
