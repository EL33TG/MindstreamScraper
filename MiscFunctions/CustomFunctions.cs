using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindstreamScraper
{
    public class CustomFunctions
    {
        /* 
         * *************************************
         * Developer: Brenden Boswell
         * 
         * Year: 2020
         * *************************************
         * Description:
         *              This class is responsible providing functionality to many other classes through the application
         ****************************************
         */
#pragma warning disable CS0649 // Field 'CustomFunctions.mainURL' is never assigned to, and will always have its default value null
        private readonly string mainURL;
#pragma warning restore CS0649 // Field 'CustomFunctions.mainURL' is never assigned to, and will always have its default value null
        ILogHouseKeeping eLog = new ErrorLog(); // Comment out if running Unit Test


        public CustomFunctions()
        {

        }

        /// <summary>
        /// Checks depth of URL by counting the number of / in string provided.
        /// </summary>
        /// <param name="URLToCheck"> string URL</param>
        /// <returns>Depth count</returns>
        public int CheckLinkDepth(string URLToCheck)
        {
            int depthValue = 1;     // If only 1 level depth will be = 1

            if (URLToCheck.EndsWith("/"))
            {
                depthValue = URLToCheck.Split('/').Length - 3;
            }
            else
            {
                depthValue = URLToCheck.Split('/').Length - 2;
            }

            return depthValue;
        }

        /// <summary>
        /// Validates the string provided to assure proper http:// syntax
        /// </summary>
        /// <param name="text">URL to input</param>
        /// <returns> Boolean value </returns>
        public bool LinkValidation(string text)
        {
            bool value = false;

            if (text.Length > 8 && (text.StartsWith("http://") || text.StartsWith("https://")))
            {
                value = true;
            }
            else
            {
                /* Comment out the 2 statements below, if running unit test */
                MessageBox.Show("Please enter a valid link using proper http:// format.. ");
                eLog.CustomLog("Invalid link entered.. [" + text + "] ");
                /* End Stataments */
            }

            return value;
        }

        /// <summary>
        /// Replaces sub-directory character "/" with "-"
        /// </summary>
        /// <param name="name">Url string</param>
        /// <returns>Html filename</returns>
        public string GenerateHTMLFileName(string name)
        {
            string fileName = "";


            if (!(name.Equals(mainURL) || name.Equals("")))
            {

                if (name.Contains("http://"))
                {
                    fileName = (name.Remove(name.IndexOf("http://"), 7).Replace('/', '-') + ".html");
                }
                else if (name.Contains("https://"))
                {
                    fileName = (name.Remove(name.IndexOf("https://"), 8).Replace('/', '-') + ".html");
                }
                else
                {
                    fileName = (name.Replace('/', '-') + ".html");
                }

            }
            else
            {
                fileName = ("main" + ".html");
            }

            return fileName;
        }

    }
}
