using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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
 *              This partial class is responsible for checking the users internet request while displaying a splash screen 
 ****************************************
 */
    public partial class SplashScreen : Form
    {
        int stepValue = 0;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            switch (stepValue)
            {
                case 1:
                    statusLabel.Text = "Checking internet connection...";

                    if (!CheckForInternetConnection())
                    {
                        timer1.Stop();
                        statusLabel.Text = "Error: No internet connection found...";
                        MessageBox.Show("Please check your internet connection!","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                        this.Close();
                    }

                    break;
                case 2:
                    statusLabel.Text = "Cleaning up...";
                    break;
                case 3:

                    statusLabel.Text = "Starting...";

                    break;
                case 4:

                    LoadMainForm();

                    break;

                default:
                    break;
            }

            stepValue++;

        }

        private static bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com"; // Using reliable Google, change if the world turns over :)
                byte[] buffer = new byte[32];
                int timeout = 2000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);

                return (reply.Status == IPStatus.Success);
            }
            catch
            {
                
                return false;
            }
        }

        private void LoadMainForm()
        {
            timer1.Stop();
            this.Hide();
            Form mainForm = new ScraperMainForm();

            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();

            //Form testForm = new TestOnly();
            //testForm.FormClosed += (s, args) => this.Close();
            //testForm.Show();
        }

        /////////
        // Below method is commented in case you wanted to check against loading a website instead of a ping request.
        // This could be useful if ping requests aren't allowed.
        // Also could be wrapped in a if else statement.
        /////////
        //public static bool CheckForInternetConnection()
        //{
        //    try
        //    {
        //        using (var client = new WebClient())
        //        using (client.OpenRead("http://google.com/generate_204")) 
        //            return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}
