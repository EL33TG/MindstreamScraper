using HtmlAgilityPack;
using MindstreamScraper.WebpageRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace MindstreamScraper
{
    public partial class ScraperMainForm : Form
    {


        Form resultForm = null;
        WebResponseCode wb = new WebResponseCode();
        CustomFunctions check = new CustomFunctions();
        ILogHouseKeeping eLog = new ErrorLog();
  

        public ScraperMainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void outputOptions_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxDepth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDepth.Checked == true)
            {
                labelMax.Visible = true;
                textBoxMax.Visible = true;
            }
            else
            {
                labelMax.Visible = false;
                textBoxMax.Visible = false;
            }
        }


        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckIfOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach ( Form form in fc)
            {
                if (form.Text == name)
                {
                    return true;
                }
            }

            return false;

        }
        private void runScraper()
        {
            bool goodLink = false;
            goodLink = check.LinkValidation(textBoxMainURL.Text);

            if (goodLink) // Checking for valid http:// format
            {
                
                if (resultForm == null || CheckIfOpened(resultForm.Text) == false)
                {
                    resultForm = new Results(textBoxMainURL.Text.TrimEnd('/'), checkBoxInternal.Checked, checkBoxExternal.Checked, 
                        exclusionListCB.Checked, checkBoxDepth.Checked, redirectedCB.Checked, hierarchyCB.Checked, 
                        responseCodeCB.Checked, htmlCB.Checked, textBoxMax.Text, wb);
                    // resultForm.TopMost = true;

                    resultForm.Show();
                }
                else
                {
                    resultForm.BringToFront();
                }
            }
         
        }

        private void buttonScrape_Click(object sender, EventArgs e)
        {
            /*Start - Execute main scraper program calls */

            runScraper(); 

            /* End */
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new About();
            aboutForm.TopMost = true;

            aboutForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsMenu = new SettingsMenu(); 
            settingsMenu.TopMost = true;

            settingsMenu.Show();
        }

        private void ScraperMainForm_Load(object sender, EventArgs e)
        {
            wb.code301 = wb.code302 = wb.code303 = wb.code307 = wb.code308 = true;
            this.Activate();
            this.TopMost = true;
            this.TopMost = false;
           
        }

        private void redirectedCB_CheckedChanged(object sender, EventArgs e)
        {
     
            if (redirectedCB.Checked == true )
            {
                redirectedCB.CheckState = CheckState.Checked;
                redirectCodeGroupBox.Visible = true;              
            }
            else if(redirectedCB.Checked == false)
            {
                redirectCB301.Checked = redirectCB302.Checked = redirectCB303.Checked = redirectCB307.Checked = redirectCB308.Checked = false;
                redirectedCB.CheckState = CheckState.Unchecked;
                redirectCodeGroupBox.Visible = false;

            }
        }


        private void redirectCB301_CheckedChanged(object sender, EventArgs e)
        {
   
            wb.code301 = !wb.code301;

        }

        private void redirectCB302_CheckedChanged(object sender, EventArgs e)
        {
           
            wb.code302 = !wb.code302;
        }

        private void redirectCB303_CheckedChanged(object sender, EventArgs e)
        {
            
            wb.code303 = !wb.code303;
        }

        private void redirectCB307_CheckedChanged(object sender, EventArgs e)
        {

            wb.code307 = !wb.code307;
        }

        private void redirectCB308_CheckedChanged(object sender, EventArgs e)
        {
            
            wb.code308 = !wb.code308;
        }
    }
}
