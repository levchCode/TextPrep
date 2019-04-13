namespace TextPrep
{
    partial class Result
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
            this.FinalText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Googledriveupload = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinalText
            // 
            this.FinalText.Location = new System.Drawing.Point(12, 49);
            this.FinalText.Name = "FinalText";
            this.FinalText.Size = new System.Drawing.Size(924, 541);
            this.FinalText.TabIndex = 0;
            this.FinalText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check everything before uploading";
            // 
            // Googledriveupload
            // 
            this.Googledriveupload.Location = new System.Drawing.Point(788, 601);
            this.Googledriveupload.Name = "Googledriveupload";
            this.Googledriveupload.Size = new System.Drawing.Size(148, 23);
            this.Googledriveupload.TabIndex = 2;
            this.Googledriveupload.Text = "Upload to Google Drive";
            this.Googledriveupload.UseVisualStyleBackColor = true;
            this.Googledriveupload.Click += new System.EventHandler(this.Googledriveupload_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(874, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 20);
            this.name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "#";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Googledriveupload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinalText);
            this.Name = "Result";
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FinalText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Googledriveupload;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
    }
}