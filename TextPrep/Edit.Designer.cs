namespace TextPrep
{
    partial class Edit
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
            this.newWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edited = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newWord
            // 
            this.newWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newWord.Location = new System.Drawing.Point(12, 41);
            this.newWord.Name = "newWord";
            this.newWord.Size = new System.Drawing.Size(506, 20);
            this.newWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Редактировать";
            // 
            // edited
            // 
            this.edited.Location = new System.Drawing.Point(439, 67);
            this.edited.Name = "edited";
            this.edited.Size = new System.Drawing.Size(79, 36);
            this.edited.TabIndex = 2;
            this.edited.Text = "Записать";
            this.edited.UseVisualStyleBackColor = true;
            this.edited.Click += new System.EventHandler(this.edited_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 115);
            this.Controls.Add(this.edited);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newWord);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edited;
    }
}