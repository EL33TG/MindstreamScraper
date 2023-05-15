namespace MindstreamScraper
{
    partial class ScraperMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScraperMainForm));
            this.textBoxMainURL = new System.Windows.Forms.TextBox();
            this.labelMainURL = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonScrape = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputOptions = new System.Windows.Forms.TabPage();
            this.responseCodeCB = new System.Windows.Forms.CheckBox();
            this.redirectCodeGroupBox = new System.Windows.Forms.GroupBox();
            this.redirectCB308 = new System.Windows.Forms.CheckBox();
            this.redirectCB307 = new System.Windows.Forms.CheckBox();
            this.redirectCB303 = new System.Windows.Forms.CheckBox();
            this.redirectCB302 = new System.Windows.Forms.CheckBox();
            this.redirectCB301 = new System.Windows.Forms.CheckBox();
            this.redirectedCB = new System.Windows.Forms.CheckBox();
            this.hierarchyCB = new System.Windows.Forms.CheckBox();
            this.htmlCB = new System.Windows.Forms.CheckBox();
            this.inputOptions = new System.Windows.Forms.TabPage();
            this.exclusionListCB = new System.Windows.Forms.CheckBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.checkBoxDepth = new System.Windows.Forms.CheckBox();
            this.checkBoxExternal = new System.Windows.Forms.CheckBox();
            this.checkBoxInternal = new System.Windows.Forms.CheckBox();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.outputOptions.SuspendLayout();
            this.redirectCodeGroupBox.SuspendLayout();
            this.inputOptions.SuspendLayout();
            this.tabOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMainURL
            // 
            this.textBoxMainURL.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxMainURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMainURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMainURL.Location = new System.Drawing.Point(140, 217);
            this.textBoxMainURL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMainURL.Name = "textBoxMainURL";
            this.textBoxMainURL.Size = new System.Drawing.Size(818, 31);
            this.textBoxMainURL.TabIndex = 0;
            this.textBoxMainURL.Text = "http://www.mindstreaminteractive.com";
            this.textBoxMainURL.WordWrap = false;
            // 
            // labelMainURL
            // 
            this.labelMainURL.AutoSize = true;
            this.labelMainURL.Location = new System.Drawing.Point(134, 188);
            this.labelMainURL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMainURL.Name = "labelMainURL";
            this.labelMainURL.Size = new System.Drawing.Size(111, 25);
            this.labelMainURL.TabIndex = 1;
            this.labelMainURL.Text = "Enter URL";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(646, 102);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(190, 32);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Web Scraper";
            this.labelHeader.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonScrape
            // 
            this.buttonScrape.FlatAppearance.BorderSize = 0;
            this.buttonScrape.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonScrape.Location = new System.Drawing.Point(969, 214);
            this.buttonScrape.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonScrape.Name = "buttonScrape";
            this.buttonScrape.Size = new System.Drawing.Size(120, 41);
            this.buttonScrape.TabIndex = 1;
            this.buttonScrape.Text = "Scrape";
            this.buttonScrape.UseVisualStyleBackColor = true;
            this.buttonScrape.Click += new System.EventHandler(this.buttonScrape_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1209, 42);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.testToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(235, 44);
            this.closeToolStripMenuItem.Text = "Settings";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(235, 44);
            this.closeToolStripMenuItem1.Text = "Exit";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // outputOptions
            // 
            this.outputOptions.Controls.Add(this.responseCodeCB);
            this.outputOptions.Controls.Add(this.redirectCodeGroupBox);
            this.outputOptions.Controls.Add(this.redirectedCB);
            this.outputOptions.Controls.Add(this.hierarchyCB);
            this.outputOptions.Controls.Add(this.htmlCB);
            this.outputOptions.Location = new System.Drawing.Point(8, 39);
            this.outputOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.outputOptions.Name = "outputOptions";
            this.outputOptions.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.outputOptions.Size = new System.Drawing.Size(940, 239);
            this.outputOptions.TabIndex = 1;
            this.outputOptions.Text = "Output Options";
            this.outputOptions.UseVisualStyleBackColor = true;
            this.outputOptions.Click += new System.EventHandler(this.outputOptions_Click);
            // 
            // responseCodeCB
            // 
            this.responseCodeCB.AutoSize = true;
            this.responseCodeCB.Location = new System.Drawing.Point(30, 133);
            this.responseCodeCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.responseCodeCB.Name = "responseCodeCB";
            this.responseCodeCB.Size = new System.Drawing.Size(277, 29);
            this.responseCodeCB.TabIndex = 4;
            this.responseCodeCB.Text = "Export Response Codes";
            this.responseCodeCB.UseVisualStyleBackColor = true;
            // 
            // redirectCodeGroupBox
            // 
            this.redirectCodeGroupBox.Controls.Add(this.redirectCB308);
            this.redirectCodeGroupBox.Controls.Add(this.redirectCB307);
            this.redirectCodeGroupBox.Controls.Add(this.redirectCB303);
            this.redirectCodeGroupBox.Controls.Add(this.redirectCB302);
            this.redirectCodeGroupBox.Controls.Add(this.redirectCB301);
            this.redirectCodeGroupBox.Location = new System.Drawing.Point(339, 42);
            this.redirectCodeGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redirectCodeGroupBox.Name = "redirectCodeGroupBox";
            this.redirectCodeGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redirectCodeGroupBox.Size = new System.Drawing.Size(303, 156);
            this.redirectCodeGroupBox.TabIndex = 3;
            this.redirectCodeGroupBox.TabStop = false;
            this.redirectCodeGroupBox.Text = "Allow Redirect Codes";
            // 
            // redirectCB308
            // 
            this.redirectCB308.AutoSize = true;
            this.redirectCB308.Checked = true;
            this.redirectCB308.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redirectCB308.Location = new System.Drawing.Point(168, 75);
            this.redirectCB308.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redirectCB308.Name = "redirectCB308";
            this.redirectCB308.Size = new System.Drawing.Size(80, 29);
            this.redirectCB308.TabIndex = 4;
            this.redirectCB308.Text = "308";
            this.redirectCB308.UseVisualStyleBackColor = true;
            this.redirectCB308.CheckedChanged += new System.EventHandler(this.redirectCB308_CheckedChanged);
            // 
            // redirectCB307
            // 
            this.redirectCB307.AutoSize = true;
            this.redirectCB307.Checked = true;
            this.redirectCB307.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redirectCB307.Location = new System.Drawing.Point(168, 33);
            this.redirectCB307.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redirectCB307.Name = "redirectCB307";
            this.redirectCB307.Size = new System.Drawing.Size(80, 29);
            this.redirectCB307.TabIndex = 3;
            this.redirectCB307.Text = "307";
            this.redirectCB307.UseVisualStyleBackColor = true;
            this.redirectCB307.CheckedChanged += new System.EventHandler(this.redirectCB307_CheckedChanged);
            // 
            // redirectCB303
            // 
            this.redirectCB303.AutoSize = true;
            this.redirectCB303.Checked = true;
            this.redirectCB303.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redirectCB303.Location = new System.Drawing.Point(22, 114);
            this.redirectCB303.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redirectCB303.Name = "redirectCB303";
            this.redirectCB303.Size = new System.Drawing.Size(80, 29);
            this.redirectCB303.TabIndex = 2;
            this.redirectCB303.Text = "303";
            this.redirectCB303.UseVisualStyleBackColor = true;
            this.redirectCB303.CheckedChanged += new System.EventHandler(this.redirectCB303_CheckedChanged);
            // 
            // redirectCB302
            // 
            this.redirectCB302.AutoSize = true;
            this.redirectCB302.Checked = true;
            this.redirectCB302.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redirectCB302.Location = new System.Drawing.Point(22, 75);
            this.redirectCB302.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redirectCB302.Name = "redirectCB302";
            this.redirectCB302.Size = new System.Drawing.Size(80, 29);
            this.redirectCB302.TabIndex = 1;
            this.redirectCB302.Text = "302";
            this.redirectCB302.UseVisualStyleBackColor = true;
            this.redirectCB302.CheckedChanged += new System.EventHandler(this.redirectCB302_CheckedChanged);
            // 
            // redirectCB301
            // 
            this.redirectCB301.AutoSize = true;
            this.redirectCB301.Checked = true;
            this.redirectCB301.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redirectCB301.Location = new System.Drawing.Point(22, 33);
            this.redirectCB301.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redirectCB301.Name = "redirectCB301";
            this.redirectCB301.Size = new System.Drawing.Size(80, 29);
            this.redirectCB301.TabIndex = 0;
            this.redirectCB301.Text = "301";
            this.redirectCB301.UseVisualStyleBackColor = true;
            this.redirectCB301.CheckedChanged += new System.EventHandler(this.redirectCB301_CheckedChanged);
            // 
            // redirectedCB
            // 
            this.redirectedCB.AutoSize = true;
            this.redirectedCB.Checked = true;
            this.redirectedCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redirectedCB.Location = new System.Drawing.Point(30, 178);
            this.redirectedCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.redirectedCB.Name = "redirectedCB";
            this.redirectedCB.Size = new System.Drawing.Size(219, 29);
            this.redirectedCB.TabIndex = 2;
            this.redirectedCB.Text = "Manage Redirects";
            this.redirectedCB.UseVisualStyleBackColor = true;
            this.redirectedCB.CheckedChanged += new System.EventHandler(this.redirectedCB_CheckedChanged);
            // 
            // hierarchyCB
            // 
            this.hierarchyCB.AutoSize = true;
            this.hierarchyCB.Checked = true;
            this.hierarchyCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hierarchyCB.Location = new System.Drawing.Point(30, 88);
            this.hierarchyCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hierarchyCB.Name = "hierarchyCB";
            this.hierarchyCB.Size = new System.Drawing.Size(250, 29);
            this.hierarchyCB.TabIndex = 1;
            this.hierarchyCB.Text = "Export Link Hierarchy";
            this.hierarchyCB.UseVisualStyleBackColor = true;
            // 
            // htmlCB
            // 
            this.htmlCB.AutoSize = true;
            this.htmlCB.Location = new System.Drawing.Point(30, 42);
            this.htmlCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.htmlCB.Name = "htmlCB";
            this.htmlCB.Size = new System.Drawing.Size(221, 29);
            this.htmlCB.TabIndex = 0;
            this.htmlCB.Text = "Export HTML Data";
            this.htmlCB.UseVisualStyleBackColor = true;
            // 
            // inputOptions
            // 
            this.inputOptions.Controls.Add(this.exclusionListCB);
            this.inputOptions.Controls.Add(this.labelMax);
            this.inputOptions.Controls.Add(this.textBoxMax);
            this.inputOptions.Controls.Add(this.checkBoxDepth);
            this.inputOptions.Controls.Add(this.checkBoxExternal);
            this.inputOptions.Controls.Add(this.checkBoxInternal);
            this.inputOptions.Location = new System.Drawing.Point(8, 39);
            this.inputOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputOptions.Name = "inputOptions";
            this.inputOptions.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputOptions.Size = new System.Drawing.Size(940, 239);
            this.inputOptions.TabIndex = 0;
            this.inputOptions.Text = "Input Options";
            this.inputOptions.UseVisualStyleBackColor = true;
            // 
            // exclusionListCB
            // 
            this.exclusionListCB.AutoSize = true;
            this.exclusionListCB.Location = new System.Drawing.Point(370, 47);
            this.exclusionListCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exclusionListCB.Name = "exclusionListCB";
            this.exclusionListCB.Size = new System.Drawing.Size(260, 29);
            this.exclusionListCB.TabIndex = 5;
            this.exclusionListCB.Text = "Activate Exclusion List";
            this.exclusionListCB.UseVisualStyleBackColor = true;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(69, 181);
            this.labelMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(122, 25);
            this.labelMax.TabIndex = 4;
            this.labelMax.Text = "Max Depth:";
            this.labelMax.Visible = false;
            // 
            // textBoxMax
            // 
            this.textBoxMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMax.Location = new System.Drawing.Point(200, 173);
            this.textBoxMax.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMax.MaxLength = 2;
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(48, 31);
            this.textBoxMax.TabIndex = 3;
            this.textBoxMax.Text = "10";
            this.textBoxMax.Visible = false;
            // 
            // checkBoxDepth
            // 
            this.checkBoxDepth.AutoSize = true;
            this.checkBoxDepth.Location = new System.Drawing.Point(30, 133);
            this.checkBoxDepth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxDepth.Name = "checkBoxDepth";
            this.checkBoxDepth.Size = new System.Drawing.Size(208, 29);
            this.checkBoxDepth.TabIndex = 2;
            this.checkBoxDepth.Text = "Show URL Depth";
            this.checkBoxDepth.UseVisualStyleBackColor = true;
            this.checkBoxDepth.CheckedChanged += new System.EventHandler(this.checkBoxDepth_CheckedChanged);
            // 
            // checkBoxExternal
            // 
            this.checkBoxExternal.AutoSize = true;
            this.checkBoxExternal.Location = new System.Drawing.Point(30, 89);
            this.checkBoxExternal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxExternal.Name = "checkBoxExternal";
            this.checkBoxExternal.Size = new System.Drawing.Size(254, 29);
            this.checkBoxExternal.TabIndex = 1;
            this.checkBoxExternal.Text = "Grab External A-Links";
            this.checkBoxExternal.UseVisualStyleBackColor = true;
            // 
            // checkBoxInternal
            // 
            this.checkBoxInternal.AutoSize = true;
            this.checkBoxInternal.Checked = true;
            this.checkBoxInternal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInternal.Location = new System.Drawing.Point(30, 44);
            this.checkBoxInternal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxInternal.Name = "checkBoxInternal";
            this.checkBoxInternal.Size = new System.Drawing.Size(246, 29);
            this.checkBoxInternal.TabIndex = 0;
            this.checkBoxInternal.Text = "Grab Internal A-Links";
            this.checkBoxInternal.UseVisualStyleBackColor = true;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.inputOptions);
            this.tabOptions.Controls.Add(this.outputOptions);
            this.tabOptions.Location = new System.Drawing.Point(140, 317);
            this.tabOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(956, 286);
            this.tabOptions.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MindstreamScraper.Properties.Resources.logo_alt;
            this.pictureBox1.Location = new System.Drawing.Point(386, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MindstreamScraper.Properties.Resources.Colorful_Background_HD;
            this.pictureBox2.Location = new System.Drawing.Point(0, 141);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1209, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Test";
            // 
            // ScraperMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1209, 703);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonScrape);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.tabOptions);
            this.Controls.Add(this.labelMainURL);
            this.Controls.Add(this.textBoxMainURL);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "ScraperMainForm";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Scraper Tool";
            this.Load += new System.EventHandler(this.ScraperMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.outputOptions.ResumeLayout(false);
            this.outputOptions.PerformLayout();
            this.redirectCodeGroupBox.ResumeLayout(false);
            this.redirectCodeGroupBox.PerformLayout();
            this.inputOptions.ResumeLayout(false);
            this.inputOptions.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMainURL;
        private System.Windows.Forms.Label labelMainURL;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonScrape;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage outputOptions;
        private System.Windows.Forms.TabPage inputOptions;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.CheckBox checkBoxDepth;
        private System.Windows.Forms.CheckBox checkBoxExternal;
        private System.Windows.Forms.CheckBox checkBoxInternal;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.CheckBox redirectedCB;
        private System.Windows.Forms.CheckBox hierarchyCB;
        private System.Windows.Forms.CheckBox htmlCB;
        private System.Windows.Forms.CheckBox exclusionListCB;
        private System.Windows.Forms.GroupBox redirectCodeGroupBox;
        private System.Windows.Forms.CheckBox redirectCB308;
        private System.Windows.Forms.CheckBox redirectCB307;
        private System.Windows.Forms.CheckBox redirectCB303;
        private System.Windows.Forms.CheckBox redirectCB302;
        private System.Windows.Forms.CheckBox redirectCB301;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox responseCodeCB;
    }
}

