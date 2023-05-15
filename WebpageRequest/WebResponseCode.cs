using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindstreamScraper.WebpageRequest
{
    /* 
     * *************************************
     * Developer: Brenden Boswell
     * 
     * Year: 2020
     * *************************************
     * Description:
     *              This class is responsible for housing any important response codes that will be used.
     ****************************************
     */
    public class WebResponseCode
    {
        public bool code301;
        public bool code302;
        public bool code303;
        public bool code307;
        public bool code308;
        public Dictionary<string, string> statusCode_Link; // = new Dictionary<string, string>();

        public WebResponseCode(){
            statusCode_Link = new Dictionary<string, string>();
        }

        public bool redirectCode301
        {
            get { return code301; }
            set { code301 = value; }
        }
        public bool redirectCode302
        {
            get { return code302; }
            set { code302 = value; }
        }
        public bool redirectCode303
        {
            get { return code303; }
            set { code303 = value; }
        }
        public bool redirectCode307
        {
            get { return code307; }
            set { code307 = value; }
        }
        public bool redirectCode308
        {
            get { return code308; }
            set { code308 = value; }
        }


        /// <summary>
        /// Checks to see if the string status code is a redirect and returns bool result
        /// </summary>
        /// <param name="doc">HhtmlDocument</param>
        /// <param name="docValue">String code to check</param>
        /// <param name="code">String passes status code</param>
        /// <returns>bool</returns>
        public bool LinkRedirectCheck(string docValue, string currentWebURL, string code)
        {
            bool redirectedResult = true;

            switch (code)
            {
                case "301":
                    if (!redirectCode301)
                    {
                        redirectedResult = redirectCode301;
                    }
                    //    eLog.CustomLog("URL [" + mainWebURL + "] Redirected: Status code [" + docValue + "] recieved");
                   
                    break;

                case "302":
                    if (!redirectCode302)
                    {
                        redirectedResult = redirectCode302;
                    }
                    //    eLog.CustomLog("URL ["+ mainWebURL + "] Redirected: Status code ["+docValue+"] recieved");
                  
                    break;

                case "303":
                    if (!redirectCode303)
                    {
                        redirectedResult = redirectCode303;
                    }
                        //    eLog.CustomLog("URL [" + mainWebURL + "] Redirected: Status code [" + docValue + "] recieved");
                       
                    break;

                case "307":
                    if (!redirectCode307)
                    {
                        redirectedResult = redirectCode307;
                    }
                    //    eLog.CustomLog("URL [" + mainWebURL + "] Redirected: Status code [" + docValue + "] recieved");
                    
                    break;

                case "308":
                    if (!redirectCode308)
                    {
                        redirectedResult = redirectCode308;
                    }
                    //    eLog.CustomLog("URL [" + mainWebURL + "] Redirected: Status code [" + docValue + "] recieved");
                    break;
              
                default:

                    break;
            }

            if (code.Length == 3)
            {
                SaveErrorCodes(code, currentWebURL);
            }
            return redirectedResult;
        }

        public void SaveErrorCodes(string docValue, string currentWebURL)
        {
            if (!statusCode_Link.ContainsKey(currentWebURL))
            {
               statusCode_Link.Add(currentWebURL, docValue);
            }
            
        }

        /// <summary>
        /// Return stored redirectCode status
        /// </summary>
        /// <returns>boolean</returns>
        public bool GetValue()
        {
           bool value = false;

            if (redirectCode301|| redirectCode302|| redirectCode303 || redirectCode307 || redirectCode308 )
            {
                value = true;
            }

            return value;
        }

    }
}
