using ClosedXML.Excel;
using System.Reflection;

namespace StudentListExcelManager.Services
{
    public static class ExcelConverter
    {
        public static void ConvertToExcel<T>(IEnumerable<T> data, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(typeof(T).Name);

                // Get properties of the class
                PropertyInfo[] properties = typeof(T).GetProperties();

                // Add headers
                for (int i = 0; i < properties.Length; i++)
                {
                    worksheet.Cell(1, i + 1).Value = properties[i].Name;
                }

                // Add data
                int row = 2;
                foreach (var item in data)
                {
                    for (int i = 0; i < properties.Length; i++)
                    {
                        // Explicitly convert the value to string
                        worksheet.Cell(row, i + 1).Value = Convert.ToString(properties[i].GetValue(item));
                    }
                    row++;
                }

                workbook.SaveAs(filePath);
            }
        }
    }
}
