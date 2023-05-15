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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void aboutTextBox1_TextChanged(object sender, EventArgs e)
        {
           // aboutTextBox1.Text = "This was created for internal use only. This tools will be used to assist with webpage research.";
        }

        private void About_Load(object sender, EventArgs e)
        {
            aboutTextBox1.Text = "This was created for internal use only. This tools will be used to assist with webpage research.";
        }
    }
}
