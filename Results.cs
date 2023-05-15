using HtmlAgilityPack;
using MindstreamScraper.WebpageRequest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace MindstreamScraper
{
    /* 
     * *************************************
     * Developer: Brenden Boswell
     * 
     * Year: 2020
     * *************************************
     * Description:
     *              This class is responsible for generating & displaying all of the data scraped from the 
     *              link in which the user provides.
     ****************************************
     */

    public partial class Results : Form
    {
        private string uLink, uLinkMain;
        private bool result, redirectedFlag, internalFlag, externalFlag, exclusionListFlag, hierarchyFlag, depthFlag, responCodeFlag, htmlCodeFlag;
        private int MaxDepth, flagger, totalInternalLinks, depthCount, newDepthLinkCount, i;
        private WebResponseCode responseCodeStatus;
        private WebRequestCaller callData;
        private CancellationTokenSource cts;
        private IScraperSettings manageURL = new ExclusionURLList();
        private ILogHouseKeeping eLog = new ErrorLog();
        private CustomFunctions check = new CustomFunctions();
        private ExportToHTML exp = new ExportToHTML();
        // internal
        List<string> internalLinkAddressList, internalLinkAddressListDupeCheck, internalLinkAddressListCount, 
            internalHierarchy, internalSave;
        // external
        List<string> externalLinkAddressListDupeCheck, externalHierarchy, externalSave;


        public Results(string urlLink, bool internalCstate, bool externalCstate, bool exclusionListCB,
            bool checkBoxDepth, bool redirectedCB, bool hierarchyCB, bool responseCodeCB, bool htmlCB, string maxDepth, WebResponseCode wb)
        {

            uLinkMain = urlLink;
            MaxDepth = Convert.ToInt16(maxDepth);
            internalFlag = internalCstate;
            externalFlag = externalCstate;
            exclusionListFlag = exclusionListCB;
            redirectedFlag = redirectedCB;
            hierarchyFlag = hierarchyCB;
            responCodeFlag = responseCodeCB;
            htmlCodeFlag = htmlCB;
            depthFlag = checkBoxDepth;
            responseCodeStatus = wb;

            InitializeComponent();
        }

        private void resultButtonClose_Click(object sender, EventArgs e)
        {
            var test = MessageBox.Show("Are you sure you want to stop loading A-links?", "Canceling", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (test == DialogResult.Yes)
            {
                if (cts.Token != null && !cts.IsCancellationRequested) // ObjectDisposedException)
                {
                    errorLabel1.Visible = true;
                    errorLabel1.Text = "Attention: Job stopped by user. Check the log file for more information";
                    eLog.CustomLog("Stopped processing data, [button] pressed...");
                    this.Text = "Anchor Tag Results - Cancelled......";
                    cts.Cancel(); // cts.Dispose();
                }
                else
                {
                    MessageBox.Show("Sorry, the process has already ended");
                }
            }


        }

        private async void Results_Load(object sender, EventArgs e)
        {
            /* Calling out to perform asynchronus task */
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            try
            {
                Task task = Task.Run(() =>
                {
                    LoadData(token);
                    Thread.Sleep(100);
                    if (token.IsCancellationRequested)
                    {
                        //  cts.Token.ThrowIfCancellationRequested();
                        //    MessageBox.Show("Loading Stopped", "Task Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Text = "Anchor Tag Results - Cancelled......";
                        eLog.CustomLog("Cancelled asynchronus operation triggered");
                        return;
                    }
                    else
                    {
                  //########   this.Text = "Anchor Tag Results - Loading Complete!";
                        MessageBox.Show("Loading Complete !!", "Task Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        eLog.CustomLog("Program completed processing!");
                    }
                    cts.Cancel();

                }, cts.Token);

                await task;
            }
            catch (Exception ex)
            {
                //    MessageBox.Show("Loading stopped","Stopped",MessageBoxButtons.OK,MessageBoxIcon.Information);
                eLog.ExceptionLog(ex);
            }
            // progressBar1.Style = ProgressBarStyle.Blocks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFiles save = new SaveFiles(uLinkMain, internalSave, externalSave, htmlCodeFlag, internalFlag,
                externalFlag, responCodeFlag, depthFlag, hierarchyFlag, exp, responseCodeStatus, internalHierarchy, externalHierarchy,
                tabControl1, iLinkTextBox1, eLinkTextBox1);

            save.ExportDataToFile();

            //   ExportDataToFile();
        }



        /* Other methods below here */

        /* Grab all data from URI submitted, return string values*/
        private string ParseHTMLData(string WebPage, string uLinkVal)
        {

            HtmlDocument doc = new HtmlDocument();
            var test = doc.DocumentNode;


                result = responseCodeStatus.LinkRedirectCheck(WebPage, uLink, callData.storedRedirectValue);
    
            if ( !String.IsNullOrEmpty(WebPage) && result)
            {
                string hrefValue = "";

                if (uLinkVal.Length >= uLinkMain.Length)
                    exp.AddToList(uLinkVal.Remove(0, uLinkMain.Length), WebPage);

                doc.LoadHtml(WebPage);

                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    flagger = 0;
                    hrefValue = link.GetAttributeValue("href", string.Empty);

                    flagger = OrganizeLinkType(hrefValue); // Main method in charge of posting data

                    if (flagger == 1)
                    {
                        continue;
                    }
                }

                depthCount = 0;

            }
            else if (result == false && uLink == uLinkMain)
            {
               
                ////////eLog.CustomLog("The main URL link you entered, [" + uLinkMain + "] is being redirected with http status code [" + WebPage + "] ....");
            }

            return WebPage;
        }

        /*--------------*/
        /* Method that is called through a thread process (Refactor later) */
        /*--------------*/
        private void StopProgressBar()
        {
        //###########  progressBar1.MarqueeAnimationSpeed = 0;
        }

        /* Starting Function */
        private void LoadData(CancellationToken token)
        {
            totalInternalLinks = 0;
            i = 0;
            depthCount = 0;
            uLink = uLinkMain;  // Ulink starts out to be the first address input

            internalLinkAddressList = new List<string>();
            internalLinkAddressListDupeCheck = new List<string>();
            internalLinkAddressListCount = new List<string>();
            internalHierarchy = new List<string>();
            internalSave = new List<string>();
            externalLinkAddressListDupeCheck = new List<string>();
            externalHierarchy = new List<string>();
            externalSave = new List<string>();

            callData = new WebRequestCaller(uLinkMain, responseCodeStatus.GetValue(), exp);


            //########## this.Text = "Anchor Tag Results - Loading Data......";
            while (i <= totalInternalLinks && !result)//&& token.IsCancellationRequested == false) // Number needs to be set to total in list
            {
        
                if (token.IsCancellationRequested)
                {
                    StopProgressBar();
                    token.ThrowIfCancellationRequested();
                }

                newDepthLinkCount = (totalInternalLinks - depthCount);

                if (!(CheckForExclusion(uLink) != true && String.IsNullOrEmpty(ParseHTMLData(callData.RequestWebPage(uLink), uLink))))
                {

                    // only iterate if the link is an internal one
                    if (internalFlag == true) //(internalLinkAddressList.Count != 0 && internalFlag == true)
                    {

                        //  uLink = internalLinkAddressList[totalInternalLinks-(totalInternalLinks - i)];
                        if (internalLinkAddressListCount.Count != 0 && i < newDepthLinkCount)
                        {
                            uLink = internalLinkAddressListCount[i]; // 0 -- Getting first link inside of list (12 links on main mindstream page)
                                                                     //   internalLinkAddressListCount.Clear();
                        }
                        else
                        {

                            try
                            {
                                //   iLinkTextBox1.AppendText("\nNo more new links @ this depth: " + uLink + "\n\n"); // Testing only
                                uLink = internalLinkAddressList[i];
                            }
                            catch (IndexOutOfRangeException)
                            {
                            }
                            catch (Exception e)
                            {
                                eLog.ExceptionLog(e);
                            }

                        }
                    }
                    else
                    {
                        break; // If external exit out of the loop, done 
                    }


                    //  iLinkTextBox1.AppendText(internalLinkAddressList[5] + "\n");

                }
                else        // You recieved an empty or null "webpage" from link
                {

                    try
                    {
                        uLink = internalLinkAddressList[i];
                    }
                    catch (IndexOutOfRangeException)
                    {
                    }
                    catch (Exception e)
                    {
                        eLog.ExceptionLog(e);
                    }

                }

                i++;
            }

            /* Cleanup */

            StopProgressBar();
            button1.Enabled = true;
         //####  resultButtonStop.Enabled = false;
            /* End CLeanup */
            /* Done processing all links */
        }


        private int OrganizeLinkType(string hrefValueLink) 
        {
            int internalValue = 0;
            if (hrefValueLink != "" && hrefValueLink.StartsWith("/"))   /* Check for / characters to succeeding page links*/
            {
                if (!(hrefValueLink.Length == 1 || internalLinkAddressListDupeCheck.Contains(uLinkMain + hrefValueLink))) // gets rid of initial link and duplicate findings
                {

                    AddToHierarchy(uLink, 1);

                  //  PrepareHTMLFile(hrefValueLink); // ###################

                    GetInternalLinkResults(hrefValueLink = uLinkMain + hrefValueLink);
                    totalInternalLinks++;
                    depthCount++;

                }

            }
            else if (hrefValueLink != "" && hrefValueLink.StartsWith("#"))
            {
                // getInternalLinkResults(hrefValueLink = (uLink + "/" + hrefValueLink));

            }
            else if (hrefValueLink != "" && hrefValueLink.StartsWith(uLink))
            {
                //    getInternalLinkResults(hrefValueLink);

            }
            else
            {
                if (!(externalLinkAddressListDupeCheck.Contains(hrefValueLink)))
                {
                    GetExternalLinkResults(hrefValueLink);
                    AddToHierarchy(uLink, 2);
                }
                internalValue = 1;
            }

            return internalValue; // return value of 1 to continue to the next iteration
        }


        private void GetInternalLinkResults(string hrefValueLink)
        {

            if (hrefValueLink != "" && internalFlag == true)
            {
                /* Needed in order to access other threads methods/variable */

                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        iLinkTextBox1.AppendText(hrefValueLink + "\n");
                        internalSave.Add(hrefValueLink);
                    }));

                }
                else
                {
                    //   iLinkTextBox1.AppendText(hrefValueLink + "\n");
                }

                /* End of thread-check logic */

                internalLinkAddressList.Add(hrefValueLink); // Adding all addresses to list set
                internalLinkAddressListDupeCheck.Add(hrefValueLink); // Adding to check for duplicates
                internalLinkAddressListCount.Add(hrefValueLink); // count

            }

        }
        private void GetExternalLinkResults(string hrefValueLink)
        {

            if (hrefValueLink != "" && externalFlag == true)
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        eLinkTextBox1.AppendText(hrefValueLink + "\n");
                        externalSave.Add(hrefValueLink);
                    }));

                }
                else
                {
                    eLinkTextBox1.AppendText(hrefValueLink + "\n");
                }

                externalLinkAddressListDupeCheck.Add(hrefValueLink); // Adding to check for duplicates

            }
        }

        private bool CheckForExclusion(string link)
        {
            bool result = false;

            if (exclusionListFlag == true && manageURL.ExclusionListCheck(link) == true)
            {
                result = true;
            }
            if (depthFlag == true && check.CheckLinkDepth(uLink) > MaxDepth)
            {
                result = true;
            }

            return result;
        }

        private void AddToHierarchy(string linkToAdd, int v)
        {
            if ((hierarchyFlag | depthFlag) && v == 1)
            {
                internalHierarchy.Add(linkToAdd);
            }
            else if ((hierarchyFlag | depthFlag) && v == 2)
            {
                externalHierarchy.Add(linkToAdd);
                // eLog.CustomLog("Unable to display values, hierarchy & depth checkbox is set to false.");
            }

        }

        /* The end */

    }
}
