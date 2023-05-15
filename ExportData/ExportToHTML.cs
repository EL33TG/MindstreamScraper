using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindstreamScraper
{
    /* 
 * *************************************
 * Developer: Brenden Boswell
 * 
 * Year: 2020
 * *************************************
 * Description:
 *              This class is responsible for Exporting the data scraped/recieved and creating an html document to disk
 ****************************************
 */
    public class ExportToHTML
    {

        private static readonly string FOLDER = ConfigurationManager.AppSettings.Get(@"HTMLFolderLocation");
        public Dictionary<string, string> htmlData_URL = new Dictionary<string, string>();
        private ErrorLog eLog = new ErrorLog();
        CustomFunctions cFunc = new CustomFunctions();

        public int TotalCount() { return htmlData_URL.Count(); }

        public ExportToHTML()
        {
            CreateFolderCheck();
        }

        private void CreateFolderCheck()
        {

            if (!Directory.Exists(FOLDER))
            {
                Directory.CreateDirectory(FOLDER);
            }
            else
            {
                eLog.CustomLog("Folder already exist [ " + FOLDER + " ]");
            }
        }

        public void WriteDataToFile()
        {
            try
            {
                CreateFolderCheck();

                foreach (var val in htmlData_URL)
                {
                    File.WriteAllText((FOLDER + cFunc.GenerateHTMLFileName(val.Key)), val.Value);
                    // File.WriteAllText(fullPath, data);
                }
            }
            catch (Exception e)
            {

                eLog.ExceptionLog(e);
            }

        }
        public void AddToList(string htmLink, string httpData)
        {
            try
            {
                htmlData_URL.Add(htmLink, httpData);
            }
            catch (Exception e)
            {
                eLog.ExceptionLog(e);
            }

        }

    }
}
