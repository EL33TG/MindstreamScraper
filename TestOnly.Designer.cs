namespace MindstreamScraper
{
    partial class TestOnly
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
            this.testButton1 = new System.Windows.Forms.Button();
            this.addValueButton1 = new System.Windows.Forms.Button();
            this.createButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton1
            // 
            this.testButton1.Location = new System.Drawing.Point(144, 86);
            this.testButton1.Name = "testButton1";
            this.testButton1.Size = new System.Drawing.Size(120, 44);
            this.testButton1.TabIndex = 0;
            this.testButton1.Text = "RunTest";
            this.testButton1.UseVisualStyleBackColor = true;
            this.testButton1.Click += new System.EventHandler(this.testButton1_Click);
            // 
            // addValueButton1
            // 
            this.addValueButton1.Location = new System.Drawing.Point(129, 34);
            this.addValueButton1.Name = "addValueButton1";
            this.addValueButton1.Size = new System.Drawing.Size(151, 24);
            this.addValueButton1.TabIndex = 1;
            this.addValueButton1.Text = "Add Value";
            this.addValueButton1.UseVisualStyleBackColor = true;
            this.addValueButton1.Click += new System.EventHandler(this.addValueButton1_Click);
            // 
            // createButton1
            // 
            this.createButton1.Location = new System.Drawing.Point(144, 178);
            this.createButton1.Name = "createButton1";
            this.createButton1.Size = new System.Drawing.Size(120, 23);
            this.createButton1.TabIndex = 2;
            this.createButton1.Text = "Create FIle";
            this.createButton1.UseVisualStyleBackColor = true;
            this.createButton1.Click += new System.EventHandler(this.createButton1_Click);
            // 
            // TestOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 256);
            this.Controls.Add(this.createButton1);
            this.Controls.Add(this.addValueButton1);
            this.Controls.Add(this.testButton1);
            this.Name = "TestOnly";
            this.Text = "TestOnly";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton1;
        private System.Windows.Forms.Button addValueButton1;
        private System.Windows.Forms.Button createButton1;
    }
}