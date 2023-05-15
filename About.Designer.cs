namespace MindstreamScraper
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.aboutTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.AutoSize = true;
            this.aboutLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel1.Location = new System.Drawing.Point(51, 32);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(152, 20);
            this.aboutLabel1.TabIndex = 0;
            this.aboutLabel1.Text = "WebScraper v1.0";
            // 
            // aboutTextBox1
            // 
            this.aboutTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox1.Font = new System.Drawing.Font("Microsoft Himalaya", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox1.Location = new System.Drawing.Point(55, 88);
            this.aboutTextBox1.Name = "aboutTextBox1";
            this.aboutTextBox1.Size = new System.Drawing.Size(171, 118);
            this.aboutTextBox1.TabIndex = 1;
            this.aboutTextBox1.Text = "";
            this.aboutTextBox1.TextChanged += new System.EventHandler(this.aboutTextBox1_TextChanged);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(274, 280);
            this.Controls.Add(this.aboutTextBox1);
            this.Controls.Add(this.aboutLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel1;
        private System.Windows.Forms.RichTextBox aboutTextBox1;
    }
}