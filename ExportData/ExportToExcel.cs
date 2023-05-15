using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Excel = Microsoft.Office.Interop.Excel;

namespace MindstreamScraper
{
    /* 
 * *************************************
 * Developer: Brenden Boswell
 * 
 * Year: 2020
 * *************************************
 * Description:
 *              This class is responsible for Exporting the data recieved to an Excel file
 ****************************************
 */
    class ScraperExcelLogic
    {
        string Path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        /* Constructor which will handle/hold the parameters that are passed to it */
        public ScraperExcelLogic()
        {
            excel.DisplayAlerts = false;
        }
        public ScraperExcelLogic(string path, int sheet)
        {
            Path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];

        }

        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        }

        public void WriteCell(int row, int column, string s)
        {
            row++; // because cells/columns start @ 1
            column++; // because cells/columns start @ 1
            ws.Cells[row, column].Value = s;

        }
        public void CreateWorksheet(string Name, int indexPos)
        {
            if (indexPos == 1)
            {
                ws = wb.Worksheets[indexPos];
                ws.Name = Name;
                ws.Activate();
            }
            else
            {
                ws = this.wb.Worksheets.Add(ws, Type.Missing, Type.Missing, Type.Missing);
                ws.Name = Name;
            }
        }

        public void AddCellHeadColor()
        {

            Range formatRange;
            formatRange = ws.get_Range("a1", "c1");
            formatRange.Font.Bold = true;
            formatRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);
            formatRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

        }

        public void Save()
        {

            wb.Save();

        }

        public void SavAs(string path)
        {

            wb.SaveAs(path);

        }

        public void Close()
        {
            wb.Close(0); // set to 0 or False value upon closing due to parameters asked upon closing
            excel.Quit();

        }
    }
}
