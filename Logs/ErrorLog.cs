using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MindstreamScraper
{
    /* 
     * *************************************
     * Developer: Brenden Boswell
     * 
     * Year: 2020
     * *************************************
     * Description:
     *              This class is responsible for generating log files throught the program. 
     ****************************************
     */
    public class ErrorLog : ILogHouseKeeping
    {
        private readonly static string applicationName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        private static readonly string FOLDER = ConfigurationManager.AppSettings.Get(@"LogFolderLocation");
        private static readonly string FNAME = ConfigurationManager.AppSettings.Get("LogFileLocation");
        private static string FILE_NAME = ($"{DateTime.Today:MMddyyy}-{applicationName}" + FNAME);
        private readonly string strPath = (FOLDER + FILE_NAME);

        public ErrorLog()
        {
            CreateLogFile();
        }

        /// <summary>
        /// Exports a custom log message of your choice
        /// </summary>
        /// <param name="errorMessage">Message to write</param>
        public void CustomLog(string errorMessage)
        {

            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine(">>>> Custom Error");
                sw.WriteLine("Begin--- " + DateTime.Now.ToString("MMddyy HH:mmsstt"));
                sw.WriteLine("Error Message: " + errorMessage);
                sw.WriteLine("End--- " + DateTime.Now.ToString("MMddyy HH:mmsstt"));

            }
        }

        /// <summary>
        /// Export any exceptions caught through the program
        /// </summary>
        /// <param name="e">Exception message</param>
        public void ExceptionLog(Exception e)
        {

            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine(">>>> Exception Error");
                sw.WriteLine("Begin--- " + DateTime.Now.ToString("MMddyy HH:mmsstt"));
                sw.WriteLine("Error Message: " + e.Message);
                sw.WriteLine("Stack Trace: " + e.StackTrace);
                sw.WriteLine("End--- " + DateTime.Now.ToString("MMddyy HH:mmsstt"));

            }
        }

        private void CreateLogFile()
        {
            if (!File.Exists(strPath))
            {
                Directory.CreateDirectory(FOLDER);
                File.Create(strPath).Dispose();
            }
        }
    }
}
