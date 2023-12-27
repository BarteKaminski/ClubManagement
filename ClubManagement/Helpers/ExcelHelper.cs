using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Helpers
{
    class ExcelHelper
    {
        public static DataTable ConvertExcelToDataTable(Stream fileStream, string fileName)
        {
            try
            {
                //FileStream fstream = new FileStream(filePath, FileMode.Open);

                Workbook workbook = new Workbook(fileStream);
                Worksheet worksheet = workbook.Worksheets[0];

                DataTable dataTable = worksheet.Cells.ExportDataTableAsString(3, 0, 100000, 12, true); //(startRow,startCol,rowTotal,colTotal,exportColName)

                fileStream.Close();

                //if (dataTable.Rows[0][0].ToString().ToLower().Contains("data"))
                //{
                //    dataTable.Rows[0].Delete();
                //    dataTable.AcceptChanges();
                //}

                //for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
                //{
                //    if (dataTable.Rows[i][2].ToString() == "" && dataTable.Rows[i][4].ToString() == "" || (!dataTable.Rows[i][2].ToString().StartsWith("WZ") && !dataTable.Rows[i][2].ToString().StartsWith("WZE")))
                //        dataTable.Rows[i].Delete();
                //}
                //foreach (DataRow row in dataTable.Rows)
                //{
                //    string productCode = row.ItemArray[3].ToString();
                //    if (productCode.StartsWith("CAS-"))
                //    {
                //        string correctProductCode = productCode.Substring(4);
                //        row.SetField(3, correctProductCode);
                //    }
                //}
                //dataTable.AcceptChanges();
                return dataTable;
            }
            catch (Exception ex)
            {
                MainForm.ShowError($"Wystąpił błąd podczas odczytu pliku excel {fileName} : " + ex.ToString());
                return null;
            }
        }
    }
}
