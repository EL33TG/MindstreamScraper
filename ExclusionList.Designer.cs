namespace MindstreamScraper
{
    partial class ExclusionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExclusionList));
            this.exclusionLabel1 = new System.Windows.Forms.Label();
            this.exclusionTextBox1 = new System.Windows.Forms.TextBox();
            this.exclusionButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exclusionListBox1 = new System.Windows.Forms.ListBox();
            this.removeButton1 = new System.Windows.Forms.Button();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exclusionLabel1
            // 
            this.exclusionLabel1.AutoSize = true;
            this.exclusionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exclusionLabel1.Location = new System.Drawing.Point(287, 14);
            this.exclusionLabel1.Name = "exclusionLabel1";
            this.exclusionLabel1.Size = new System.Drawing.Size(145, 25);
            this.exclusionLabel1.TabIndex = 1;
            this.exclusionLabel1.Text = "Exclusion List";
            // 
            // exclusionTextBox1
            // 
            this.exclusionTextBox1.Location = new System.Drawing.Point(71, 99);
            this.exclusionTextBox1.Name = "exclusionTextBox1";
            this.exclusionTextBox1.Size = new System.Drawing.Size(516, 22);
            this.exclusionTextBox1.TabIndex = 2;
            this.exclusionTextBox1.Text = "http://";
            // 
            // exclusionButton1
            // 
            this.exclusionButton1.Location = new System.Drawing.Point(593, 95);
            this.exclusionButton1.Name = "exclusionButton1";
            this.exclusionButton1.Size = new System.Drawing.Size(75, 31);
            this.exclusionButton1.TabIndex = 3;
            this.exclusionButton1.Text = "Add";
            this.exclusionButton1.UseVisualStyleBackColor = true;
            this.exclusionButton1.Click += new System.EventHandler(this.exclusionButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter URL to Exclude";
            // 
            // exclusionListBox1
            // 
            this.exclusionListBox1.FormattingEnabled = true;
            this.exclusionListBox1.ItemHeight = 16;
            this.exclusionListBox1.Location = new System.Drawing.Point(71, 182);
            this.exclusionListBox1.Name = "exclusionListBox1";
            this.exclusionListBox1.Size = new System.Drawing.Size(649, 228);
            this.exclusionListBox1.TabIndex = 5;
            // 
            // removeButton1
            // 
            this.removeButton1.Location = new System.Drawing.Point(74, 431);
            this.removeButton1.Name = "removeButton1";
            this.removeButton1.Size = new System.Drawing.Size(140, 31);
            this.removeButton1.TabIndex = 6;
            this.removeButton1.Text = "Remove Selected";
            this.removeButton1.UseVisualStyleBackColor = true;
            this.removeButton1.Click += new System.EventHandler(this.removeButton1_Click);
            // 
            // errorLabel1
            // 
            this.errorLabel1.AutoSize = true;
            this.errorLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.errorLabel1.ForeColor = System.Drawing.Color.Red;
            this.errorLabel1.Location = new System.Drawing.Point(71, 484);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(0, 17);
            this.errorLabel1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.linkLabel1.Location = new System.Drawing.Point(71, 504);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 8;
            // 
            // ExclusionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.removeButton1);
            this.Controls.Add(this.exclusionListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exclusionButton1);
            this.Controls.Add(this.exclusionTextBox1);
            this.Controls.Add(this.exclusionLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExclusionList";
            this.Text = "ExclusionList";
            this.Load += new System.EventHandler(this.ExclusionList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exclusionLabel1;
        private System.Windows.Forms.TextBox exclusionTextBox1;
        private System.Windows.Forms.Button exclusionButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox exclusionListBox1;
        private System.Windows.Forms.Button removeButton1;
        private System.Windows.Forms.Label errorLabel1;
        private System.Windows.Forms.Label linkLabel1;
    }
}