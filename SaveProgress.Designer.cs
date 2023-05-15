namespace MindstreamScraper
{
    partial class SaveProgress
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
            this.savingProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // savingProgressBar
            // 
            this.savingProgressBar.Location = new System.Drawing.Point(12, 26);
            this.savingProgressBar.Name = "savingProgressBar";
            this.savingProgressBar.Size = new System.Drawing.Size(367, 19);
            this.savingProgressBar.Step = 1;
            this.savingProgressBar.TabIndex = 0;
            this.savingProgressBar.Value = 5;
            // 
            // SaveProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(391, 71);
            this.Controls.Add(this.savingProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SaveProgress";
            this.Text = "Please Wait...Saving Data";
           // this.Load += new System.EventHandler(this.SaveProgress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar savingProgressBar;
    }
}