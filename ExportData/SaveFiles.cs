using MindstreamScraper.WebpageRequest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindstreamScraper
{
    public class SaveFiles
    {
        /* 
 * *************************************
 * Developer: Brenden Boswell
 * 
 * Year: 2020
 * *************************************
 * Description:
 *              This class is responsible for saving all available file types
 ****************************************
 */
        private int i, j, k;
        private CustomFunctions check = new CustomFunctions();
        private string uLinkMain;
        private readonly List<string> internalSave, externalSave;
        private readonly bool htmlCodeFlag, internalFlag, externalFlag, responCodeFlag, depthFlag, hierarchyFlag;
        private ExportToHTML exp;
        private WebResponseCode webResponse;
        private readonly List<string> internalHierarchy, externalHierarchy;
        private TabControl tabControl1;
        private RichTextBox iLinkTextBox1, eLinkTextBox1;
        private Form sp; //= new SaveProgress(CalculateDate());

        public SaveFiles(string uLinkMain, List<string> internalSave, List<string> externalSave, bool htmlCodeFlag, bool internalFlag, bool externalFlag, bool responCodeFlag, bool depthFlag, bool hierarchyFlag,
            ExportToHTML exp, WebResponseCode wb, List<string> internalHierarchy, List<string> externalHierarchy, TabControl tabControl1, RichTextBox iLinkTextBox1, RichTextBox eLinkTextBox1)
        {
            this.uLinkMain = uLinkMain;
            this.internalSave = internalSave;
            this.externalSave = externalSave;
            this.htmlCodeFlag = htmlCodeFlag;
            this.internalFlag = internalFlag;
            this.externalFlag = externalFlag;
            this.responCodeFlag = responCodeFlag;
            this.depthFlag = depthFlag;
            this.hierarchyFlag = hierarchyFlag;
            this.exp = exp;
            this.webResponse = wb;
            this.internalHierarchy = internalHierarchy;
            this.externalHierarchy = externalHierarchy;
            this.tabControl1 = tabControl1;
            this.iLinkTextBox1 = iLinkTextBox1;
            this.eLinkTextBox1 = eLinkTextBox1;
        }

        public void ExportDataToFile()
        {
            /* Get data total */
           // sp = new SaveProgress(CalculateDate());

            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Excel File (*.xlsx)|*.xlsx|Text File|*.txt", //|Csv File|*.csv",
                Title = "Save Data File",
                FileName = ("Scraped_Results-" + uLinkMain.Substring(uLinkMain.IndexOf('.') + 1))
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {

                if (saveFileDialog1.FilterIndex < 2)
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    fs.Close();
                }

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        /* Save to Excel file */
                        //sp = new SaveProgress();
                        //sp.Show();
                        
                        WriteDataToExcel(saveFileDialog1, sp);

                        break;

                    case 2:
                        /* Save to Text file */
                     //   sp.Show();

                        if (tabControl1.SelectedIndex == 0)
                        {
                            File.WriteAllLines(saveFileDialog1.FileName, internalSave);
                        }
                        else
                        {
                            /* Save to .csv file */
                            File.WriteAllLines(saveFileDialog1.FileName, externalSave);
                        }
                        break;
                    //case 3:

                    //    if (tabControl1.SelectedIndex == 0)
                    //    {
                    //        File.WriteAllLines(saveFileDialog1.FileName, internalSave);
                    //    }
                    //    else
                    //    {
                    //        File.WriteAllLines(saveFileDialog1.FileName, externalSave);
                    //    }
                    //    break;
                }

                /* Create HTML pages */

                if (htmlCodeFlag)
                {
                    exp.WriteDataToFile();
                }

                MessageBox.Show("Saving is Complete","Saving Complete!",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void WriteDataToExcel(SaveFileDialog saveFileDialog1, Form sp)
        {
            int count = 0;
            
          //  sp = new SaveProgress();

            /* Create new file */

            // ScraperExcelLogic exLogic = new ScraperExcelLogic(@"C:\Downloads\TEST.xlsx", 1);
            ScraperExcelLogic exSaveLogic = new ScraperExcelLogic();
            exSaveLogic.CreateNewFile();
            //   exSaveLogic.CreateWorksheet("External Links", 1);
            exSaveLogic.SavAs(saveFileDialog1.FileName);
            exSaveLogic.Close();
            // Look into making these two calls one
            ScraperExcelLogic exLogic = new ScraperExcelLogic(saveFileDialog1.FileName, 1);

            //if (tabControl1.SelectedIndex == 0)
            //{
            i = 1; // shift file row position for header
            exLogic.CreateWorksheet("Internal Links", 1);
            exLogic.WriteCell(0, 0, "Anchor Tags Found"); // exLogic.WriteCell(0, 0, "TESTING ONLY");
            exLogic.WriteCell(0, 1, "URL Location"); // exLogic.WriteCell(0, 0, "TESTING ONLY");
            exLogic.WriteCell(0, 2, "Depth"); // Depth
            exLogic.AddCellHeadColor(); // Turns it to Red

            if (internalFlag == true && internalSave.Count > 0)
            {
                while (iLinkTextBox1.Lines[i] != "") //(internalSave[k] != "")
                {
                    exLogic.WriteCell(i, 0, iLinkTextBox1.Lines[i]); //internalSave[k]); // A-LINKS - exLogic.WriteCell(0, 0, "TESTING ONLY");
                    if (hierarchyFlag)
                    {
                        exLogic.WriteCell(i, 1, internalHierarchy[i]); // URL LOCATIOn
                    }

                    if (depthFlag)
                    {
                        /* Output Depth number */
                        count = check.CheckLinkDepth(internalHierarchy[i]);
                        exLogic.WriteCell(i, 2, count.ToString()); // DEPTH
                    }
                    /* End of Depth logic*/
                
                    i++;
                }
            }

            //}
            //else
            //{
            j = 1; // shift file row position for header
            exLogic.CreateWorksheet("External Links", 2);
            exLogic.WriteCell(0, 0, "Anchor Tags Found"); // exLogic.WriteCell(0, 0, "TESTING ONLY");
            exLogic.WriteCell(0, 1, "URL Location"); // exLogic.WriteCell(0, 0, "TESTING ONLY");
            exLogic.AddCellHeadColor(); // Turns it to Red

            if (externalFlag == true && externalSave.Count > 0)
            {
                while (eLinkTextBox1.Lines[j] != "") // (externalSave[kE] != "")
                {
                    exLogic.WriteCell(j, 0, eLinkTextBox1.Lines[j]); // externalSave[kE]); // exLogic.WriteCell(0, 0, "TESTING ONLY");

                    if (hierarchyFlag)
                    {
                        exLogic.WriteCell(j, 1, externalHierarchy[j]); // URL LOCATIOn
                    }

                    j++;
                }
            }

            k = 1; // shift file row position for header
            exLogic.CreateWorksheet("Response Codes", 3);
            // exLogic.WriteCell(0, 0, "Anchor Tags Found"); // exLogic.WriteCell(0, 0, "TESTING ONLY");
            exLogic.WriteCell(0, 0, "URL Location"); // exLogic.WriteCell(0, 0, "TESTING ONLY");
            exLogic.WriteCell(0, 1, "StatusCode"); // exLogic.WriteCell(0, 0, "TESTING ONLY");
            exLogic.AddCellHeadColor(); // Turns it to Red

            if (responCodeFlag == true)
            {
                foreach (var val in webResponse.statusCode_Link)
                {
                    exLogic.WriteCell(k, 0, val.Key);
                    exLogic.WriteCell(k, 1, val.Value);
                    // Console.WriteLine("Value: {0}", val.Key);
                    k++;
                }
            }

            exLogic.Save();
            exLogic.Close();

            /* Export to html file*/

        }

        private int CalculateDate()
        {


            return 0;
        }
    }
}
