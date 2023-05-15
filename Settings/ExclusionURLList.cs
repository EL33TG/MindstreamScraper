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
     *              This class is responsible for editing your exclusion list. 
     *              If there are url's in which the user do not want to scan, 
     *              they will be included in the list.
     ****************************************
     */
    public class ExclusionURLList : IScraperSettings
    {

        private static readonly string FOLDER = ConfigurationManager.AppSettings.Get(@"ExclusionListFolderLocation");
        private static readonly string FILE_NAME = ConfigurationManager.AppSettings.Get("ExclusionListFileLocation");
        public string fullPath = (FOLDER + FILE_NAME);

        public string FullPath { get { return fullPath; } } // if I need to set value in future add, { fullPath = value; } } Also add set to Interface.

        public ExclusionURLList()
        {
            CheckToCreatFile();
        }

        public void AddURLToList(string exclude)
        {
            string[] settingData = { exclude };

            if (File.Exists(fullPath))
            {
                File.AppendAllLines(fullPath, settingData);

            }
            else
            {
                Directory.CreateDirectory(FOLDER);
                File.WriteAllLines(fullPath, settingData);
            }
        }

        public bool ExclusionListCheck(string exist)
        {
            bool existStat = false;

            // CHECK FOR FILE
            //if (File.Exists(fullPath))
            //{
                string[] lines = File.ReadAllLines(fullPath);

                foreach (string exclusionData in lines)
                {
                    if (lines.Contains(exist))
                    {
                        existStat = true;
                    }
                }
            //}
            //else
            //{
            //    Directory.CreateDirectory(FOLDER);
            //}

            return existStat;
        }

        public void RemoveURLFromList(string exclude)
        {
            if (File.Exists(fullPath))
            {
                File.WriteAllLines(fullPath, File.ReadLines(fullPath).Where(l => l != exclude).ToList());
            }
        }

       private void CheckToCreatFile()
        {
            string[] settingData = { "" };

            if (File.Exists(fullPath))
            {
           

            }
            else
            {
                Directory.CreateDirectory(FOLDER);
                File.WriteAllLines(fullPath, settingData);
            }
        }
    }
}
