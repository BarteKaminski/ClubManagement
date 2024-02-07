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

                Workbook workbook = new Workbook(fileStream);
                Worksheet worksheet = workbook.Worksheets[0];

                DataTable dataTable = worksheet.Cells.ExportDataTableAsString(3, 0, 100000, 12, true); //(startRow,startCol,rowTotal,colTotal,exportColName)

                fileStream.Close();

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
