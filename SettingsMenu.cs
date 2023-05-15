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
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void exclusionButton1_Click(object sender, EventArgs e)
        {
            var exclusionList = new ExclusionList();
            exclusionList.TopMost = true;
            exclusionList.Show();
            this.Close();

        }
    }
}
