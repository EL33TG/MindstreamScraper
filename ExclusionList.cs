using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindstreamScraper
{
    public partial class ExclusionList : Form
    {

        IScraperSettings manageURL = new ExclusionURLList();  // Exclusion list controls methods
        ILogHouseKeeping eLog = new ErrorLog();
        CustomFunctions check = new CustomFunctions();

        public ExclusionList()
        {      
            InitializeComponent();
            
        }
        public string ListBoxValue
        {
            get { return exclusionListBox1.Text; }
            set { exclusionListBox1.Items.Add(value); }

        }

        private void exclusionButton1_Click(object sender, EventArgs e)
        {
            bool goodLink = false;
            goodLink = check.LinkValidation(exclusionTextBox1.Text);

            if (goodLink) // Checking for valid http:// format
            {

                if (File.Exists(manageURL.FullPath) && manageURL.ExclusionListCheck(exclusionTextBox1.Text))
                {
                    DelayMessage(exclusionTextBox1.Text);
                }
                else
                {
                    manageURL.AddURLToList(exclusionTextBox1.Text); // Add URL to list
                    exclusionListBox1.Items.Add(exclusionTextBox1.Text); // Add URL to Listbox
                }
            }

            //if (!(File.Exists(manageURL.FullPath))) // | manageURL.CheckForDuplicateURL(exclusionTextBox1.Text)))
            //{

            //    manageURL.AddURLToList(exclusionTextBox1.Text); // Add URL to list
            //    exclusionListBox1.Items.Add(exclusionTextBox1.Text); // Add URL to Listbox
            //}
            //else if (!(File.Exists(manageURL.FullPath) && manageURL.CheckForDuplicateURL(exclusionTextBox1.Text)))
            //{
            //    manageURL.AddURLToList(exclusionTextBox1.Text); // Add URL to list
            //    exclusionListBox1.Items.Add(exclusionTextBox1.Text); // Add URL to Listbox

            //} else{

            //    DelayMessage(exclusionTextBox1.Text );
            //}
        }

        //private bool LinkValidation(string text)
        //{
        //    bool value = false;

        //    if (text.Length > 7 && text.StartsWith("http://") )
        //    {
        //        value = true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter a link using proper http:// format.. ");
        //        eLog.CustomLog("Invalid link entered in exclusion list.. ["+ text +"] ");
        //    }

        //    return value;
        //}

        private void ExclusionList_Load(object sender, EventArgs e)
        {
           
            if (File.Exists(manageURL.FullPath))
            {
                string[] lines = File.ReadAllLines(manageURL.FullPath);

                foreach (string exclusionData in lines)
                {
                    exclusionListBox1.Items.Add(exclusionData);
                }
            }
        }


        private void removeButton1_Click(object sender, EventArgs e)
        {
            if (exclusionListBox1.SelectedIndex > -1)     // Check whether an item is selected or not > -1
            {
                var result = MessageBox.Show("Are you sure you want to remove\n" + exclusionListBox1.SelectedItem.ToString(), "Delete URL From List", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    manageURL.RemoveURLFromList(exclusionListBox1.SelectedItem.ToString()); // Delete from temp file                                                                                            
                    exclusionListBox1.Items.Remove(exclusionListBox1.SelectedItem); // Delete from Listbox view
                }
                else
                {
                    MessageBox.Show("Aborting previous operation!","Aborting...",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    eLog.CustomLog("Aborted: Did not delete ["+ exclusionListBox1.SelectedItem.ToString()+ "] from the exclusion list.");
                }
            }
            else
            {
                MessageBox.Show("No items Selected\nPlease select an item to continue!","Problem Detected",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private async void DelayMessage(string asscURL)
        {
            errorLabel1.Text = ("Error: The following URL already exist in the list");
            linkLabel1.Text = asscURL;
            eLog.CustomLog(errorLabel1.Text + ": " + asscURL);
            await Task.Delay(3000);
            errorLabel1.Text = "";
            linkLabel1.Text = "";
        }



    }
}
