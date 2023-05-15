namespace MindstreamScraper
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.iLinkTextBox1 = new System.Windows.Forms.RichTextBox();
            this.resultLabel1 = new System.Windows.Forms.Label();
            this.resultButtonStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.internalTabPage1 = new System.Windows.Forms.TabPage();
            this.externalTabPage2 = new System.Windows.Forms.TabPage();
            this.eLinkTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.internalTabPage1.SuspendLayout();
            this.externalTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iLinkTextBox1
            // 
            this.iLinkTextBox1.BackColor = System.Drawing.Color.White;
            this.iLinkTextBox1.Location = new System.Drawing.Point(3, 18);
            this.iLinkTextBox1.Name = "iLinkTextBox1";
            this.iLinkTextBox1.Size = new System.Drawing.Size(711, 450);
            this.iLinkTextBox1.TabIndex = 0;
            this.iLinkTextBox1.Text = "";
            this.iLinkTextBox1.WordWrap = false;
            // 
            // resultLabel1
            // 
            this.resultLabel1.AutoSize = true;
            this.resultLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel1.Location = new System.Drawing.Point(328, 9);
            this.resultLabel1.Name = "resultLabel1";
            this.resultLabel1.Size = new System.Drawing.Size(198, 29);
            this.resultLabel1.TabIndex = 1;
            this.resultLabel1.Text = "Links Identified";
            // 
            // resultButtonStop
            // 
            this.resultButtonStop.Location = new System.Drawing.Point(673, 558);
            this.resultButtonStop.Name = "resultButtonStop";
            this.resultButtonStop.Size = new System.Drawing.Size(98, 31);
            this.resultButtonStop.TabIndex = 2;
            this.resultButtonStop.Text = "Stop";
            this.resultButtonStop.UseVisualStyleBackColor = true;
            this.resultButtonStop.Click += new System.EventHandler(this.resultButtonClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.internalTabPage1);
            this.tabControl1.Controls.Add(this.externalTabPage2);
            this.tabControl1.Location = new System.Drawing.Point(46, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 500);
            this.tabControl1.TabIndex = 3;
            // 
            // internalTabPage1
            // 
            this.internalTabPage1.Controls.Add(this.iLinkTextBox1);
            this.internalTabPage1.Location = new System.Drawing.Point(4, 25);
            this.internalTabPage1.Name = "internalTabPage1";
            this.internalTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.internalTabPage1.Size = new System.Drawing.Size(717, 471);
            this.internalTabPage1.TabIndex = 0;
            this.internalTabPage1.Text = "Internal Links";
            this.internalTabPage1.UseVisualStyleBackColor = true;
            // 
            // externalTabPage2
            // 
            this.externalTabPage2.Controls.Add(this.eLinkTextBox1);
            this.externalTabPage2.Location = new System.Drawing.Point(4, 25);
            this.externalTabPage2.Name = "externalTabPage2";
            this.externalTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.externalTabPage2.Size = new System.Drawing.Size(717, 471);
            this.externalTabPage2.TabIndex = 1;
            this.externalTabPage2.Text = "External Links";
            this.externalTabPage2.UseVisualStyleBackColor = true;
            // 
            // eLinkTextBox1
            // 
            this.eLinkTextBox1.Location = new System.Drawing.Point(6, 20);
            this.eLinkTextBox1.Name = "eLinkTextBox1";
            this.eLinkTextBox1.Size = new System.Drawing.Size(703, 462);
            this.eLinkTextBox1.TabIndex = 0;
            this.eLinkTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 542);
            this.progressBar1.MarqueeAnimationSpeed = 70;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(719, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 15;
            // 
            // errorLabel1
            // 
            this.errorLabel1.AutoSize = true;
            this.errorLabel1.ForeColor = System.Drawing.Color.Crimson;
            this.errorLabel1.Location = new System.Drawing.Point(200, 572);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(105, 17);
            this.errorLabel1.TabIndex = 6;
            this.errorLabel1.Text = "Error Message:";
            this.errorLabel1.Visible = false;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(846, 601);
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.resultButtonStop);
            this.Controls.Add(this.resultLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Results";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Anchor Tag Results";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Results_Load);
            this.tabControl1.ResumeLayout(false);
            this.internalTabPage1.ResumeLayout(false);
            this.externalTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label resultLabel1;
        private System.Windows.Forms.Button resultButtonStop;
        private System.Windows.Forms.TabPage internalTabPage1;
        private System.Windows.Forms.TabPage externalTabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label errorLabel1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.RichTextBox iLinkTextBox1;
        public System.Windows.Forms.RichTextBox eLinkTextBox1;
    }
}