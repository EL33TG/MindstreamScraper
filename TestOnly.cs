using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindstreamScraper
{
    public partial class TestOnly : Form
    {
        ExportToHTML test = new ExportToHTML();

        public TestOnly()
        {
            InitializeComponent();
        }

        private void addValueButton1_Click(object sender, EventArgs e)
        {
            test.AddToList("www.test.com","GoogleGop Data, Yay, whatever <>");
        }

        private void testButton1_Click(object sender, EventArgs e)
        {

            int value = test.TotalCount();

            Console.WriteLine("Test Display");
            Console.WriteLine("The Total amount of files are: " + value);
        }

        private void createButton1_Click(object sender, EventArgs e)
        {
         //   test.WriteDataToFile("home/test/yes","<html><title>File was created successfully!</title><body><h1>Hello</h1></body></title></html>");
          //  test.WriteDataToFile("https://home/test/yes", "<html><title>File was created successfully!</title><body><h1>Hello</h1></body></title></html>");

        }
    }
}
