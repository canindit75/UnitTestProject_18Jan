using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Excel = Microsoft.Office.Interop.Excel;
namespace UnitTestProject_18Jan.Selenium
{
    [TestFixture]
    public class DataDrivenClass
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel.Worksheet xlWorksheet;
        Excel.Range xlUsedRange;
        [Test]
        public void DDTMethod()
        {
            xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open("C:\\Users\\Anindita\\Documents\\Visual Studio 2015\\Projects\\UnitTestProject_18Jan\\UnitTestProject_18Jan\\Selenium\\BMITestData.xlsx");
            xlWorksheet = xlWorkbook.Worksheets[1];
            xlUsedRange = xlWorksheet.UsedRange;
            int rowCount = xlUsedRange.Rows.Count;
            Console.WriteLine("Row Count = " + rowCount);
            int colCount = xlUsedRange.Columns.Count;
            Console.WriteLine("Column Count = " + colCount);

            for (int r = 1; r <= rowCount; r++)
            {
                for (int c = 1; c <= colCount; c++)
                {
                    Console.Write(xlUsedRange.Cells[r, c].Value2.ToString() + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
