using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
     *              This class is responsible for all http request in order to gather data for the program 
     ****************************************
     */
    public class WebRequestCaller
    {
        private static string WebPage = string.Empty;
        private bool RedirectedFlag;
        public string storedRedirectValue;
        private string currentWebURL;
        private string mainWebURL;
        public string storedPageData;
        public Dictionary<string, string> statusCode_Link = new Dictionary<string, string>();
        ExportToHTML exp; //= new ExportToHTML();

        ILogHouseKeeping eLog = new ErrorLog();

        public WebRequestCaller(string uLinkmMain, bool redirectedFlag, ExportToHTML testData)
        {
            RedirectedFlag = redirectedFlag;
            mainWebURL = uLinkmMain;
            exp = testData;

        }
        //public WebRequestCaller(string uLinkmMain, ExportToHTML testData)
        //{
        //    RedirectedFlag = true;
        //    mainWebURL = uLinkmMain;
        //    exp = testData;

        //}
        //public WebRequestCaller()
        //{
        //}

        /// <summary>
        /// This will grab the URL string and return back the requested webpage tags, and source data
        /// </summary>
        /// <param name="WebURL"> String to call</param>
        /// <returns>String</returns>
        public string RequestWebPage(string WebURL)
        {
            currentWebURL = WebURL;
            string reqResult = "";
            
         //   GetRedirectValue(WebURL);

            try
            {
                GetRedirectValue(WebURL);

                HttpWebRequest HttpRequest = (HttpWebRequest)WebRequest.Create(WebURL);
                HttpRequest.Method = "GET";
                HttpRequest.AllowAutoRedirect = true; // Allow pr don't allow page redirects
              //  HttpRequest.Timeout = 21600000; // Dont forget to uncomment this to slow down scrape
           //     HttpRequest.CachePolicy = new System.Net.Cache.HttpRequestCachePolicy(System.Net.Cache.HttpRequestCacheLevel.NoCacheNoStore);
                HttpWebResponse PageResponse = (HttpWebResponse)(HttpRequest.GetResponse());           
                reqResult = RedirectValue(PageResponse.StatusCode); // RIGHT HERE WORKING


                if (reqResult == "200")
                {
                    StreamReader sr = new StreamReader(PageResponse.GetResponseStream(), System.Text.Encoding.UTF8);

                    if (PageResponse.ContentType.ToLower().Contains("text/html")) // This could very, double check it.
                    {

                        WebPage = sr.ReadToEnd();
                    }
                    else
                    {
                        WebPage = String.Empty;
                    }

                    sr.Close();
                    PageResponse.Close();

                }
                else
                {
                    WebPage = reqResult;

                }

            }
            catch (IndexOutOfRangeException)
            {

            }
            catch (Exception)
            {

            }
            return WebPage; /// return csvRecord; example(something creative object) 
        }

        private void GetRedirectValue(string WebURL)
        {
            HttpWebRequest HttpRequest = (HttpWebRequest)WebRequest.Create(WebURL);
            HttpRequest.Method = "GET";
            HttpRequest.AllowAutoRedirect = false; // Allow pr don't allow page redirects
                                                            //  HttpRequest.Timeout = 21600000; // Dont forget to uncomment this to slow down scrape
            HttpRequest.CachePolicy = new System.Net.Cache.HttpRequestCachePolicy(System.Net.Cache.HttpRequestCacheLevel.NoCacheNoStore);
            HttpWebResponse PageResponse = (HttpWebResponse)(HttpRequest.GetResponse());
            storedRedirectValue = RedirectValue(PageResponse.StatusCode); // RIGHT HERE WORKING
            PageResponse.Close();
        }

        /// <summary>
        /// Checks to see if the string status code is a redirect and returns bool result
        /// </summary>
        /// <param name="doc">HhtmlDocument</param>
        /// <param name="docValue">String code to check</param>
        /// <returns>bool</returns>
        public bool LinkRedirectCheck(string docValue)
        {
            bool redirectedResult = true;

            switch (docValue)
            {
                //case "301":
                //    //    eLog.CustomLog("URL [" + mainWebURL + "] Redirected: Status code [" + docValue + "] recieved");

                //    redirectedResult = false;
                //    break;

                //case "302":
                ////    eLog.CustomLog("URL ["+ mainWebURL + "] Redirected: Status code ["+docValue+"] recieved");

                //  redirectedResult = false;
                //    break;

                //case "303":
                //    //    eLog.CustomLog("URL [" + mainWebURL + "] Redirected: Status code [" + docValue + "] recieved");

                //    redirectedResult = false;
                //    break;

                //case "307":
                ////    eLog.CustomLog("URL [" + mainWebURL + "] Redirected: Status code [" + docValue + "] recieved");

                //    redirectedResult = false;
                //    break;

                //case "308":
                //    //    eLog.CustomLog("URL [" + mainWebURL + "] Redirected: Status code [" + docValue + "] recieved");

                //    redirectedResult = false;
                //    break;
                default:
                    SaveErrorCodes(docValue);
                    redirectedResult = false;
                    //  Console.WriteLine("Sorry, nothing found....");
                    break;
            }

            return redirectedResult;
        }

        private static string RedirectValue(HttpStatusCode code)
        {
            string value = "";

            switch (code)
            {


                case HttpStatusCode.OK:

                    value = "200"; // Simple redirect

                    break;

                case HttpStatusCode.Found | HttpStatusCode.Found:

                    value = "302"; // Simple redirect

                    break;
                case HttpStatusCode.Moved | HttpStatusCode.MovedPermanently:

                    value = "301"; // Moved rediret

                    break;

                case HttpStatusCode.RedirectKeepVerb:

                    value = "307"; // Moved rediret

                    break;

                default:

                    break;
            }


            return value;
        }


        public void SaveErrorCodes(string docValue)
        {

            statusCode_Link.Add(currentWebURL, docValue);
        }


        /* The end of method */
    }
}

