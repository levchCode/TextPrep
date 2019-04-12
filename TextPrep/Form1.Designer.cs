namespace TextPrep
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.text = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addtoex1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addtoex2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВЗадание3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addtoex3synonyms = new System.Windows.Forms.ToolStripMenuItem();
            this.addtoex3antonyms = new System.Windows.Forms.ToolStripMenuItem();
            this.compose = new System.Windows.Forms.Button();
            this.task1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.task2 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.ContextMenuStrip = this.contextMenuStrip1;
            this.text.Location = new System.Drawing.Point(4, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(621, 703);
            this.text.TabIndex = 0;
            this.text.Text = "Мой дядя самых честных правил, когда не в шутку занемог он уважать себя заставил " +
    "и лучше выдумать немог";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addtoex1,
            this.addtoex2,
            this.добавитьВЗадание3ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 70);
            // 
            // addtoex1
            // 
            this.addtoex1.Name = "addtoex1";
            this.addtoex1.Size = new System.Drawing.Size(192, 22);
            this.addtoex1.Text = "Добавить в Задание 1";
            this.addtoex1.Click += new System.EventHandler(this.addtoex1_Click);
            // 
            // addtoex2
            // 
            this.addtoex2.Name = "addtoex2";
            this.addtoex2.Size = new System.Drawing.Size(192, 22);
            this.addtoex2.Text = "Добавить в Задание 2";
            this.addtoex2.Click += new System.EventHandler(this.addtoex2_Click);
            // 
            // добавитьВЗадание3ToolStripMenuItem
            // 
            this.добавитьВЗадание3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addtoex3synonyms,
            this.addtoex3antonyms});
            this.добавитьВЗадание3ToolStripMenuItem.Name = "добавитьВЗадание3ToolStripMenuItem";
            this.добавитьВЗадание3ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.добавитьВЗадание3ToolStripMenuItem.Text = "Добавить в Задание 3";
            // 
            // addtoex3synonyms
            // 
            this.addtoex3synonyms.Name = "addtoex3synonyms";
            this.addtoex3synonyms.Size = new System.Drawing.Size(135, 22);
            this.addtoex3synonyms.Text = "Синонимы";
            // 
            // addtoex3antonyms
            // 
            this.addtoex3antonyms.Name = "addtoex3antonyms";
            this.addtoex3antonyms.Size = new System.Drawing.Size(135, 22);
            this.addtoex3antonyms.Text = "Антонимы";
            // 
            // compose
            // 
            this.compose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.compose.Location = new System.Drawing.Point(631, 686);
            this.compose.Name = "compose";
            this.compose.Size = new System.Drawing.Size(418, 29);
            this.compose.TabIndex = 10;
            this.compose.Text = "Сформировать";
            this.compose.UseVisualStyleBackColor = true;
            this.compose.Click += new System.EventHandler(this.compose_Click);
            // 
            // task1
            // 
            this.task1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task1.FormattingEnabled = true;
            this.task1.Location = new System.Drawing.Point(3, 16);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(206, 659);
            this.task1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.task1);
            this.groupBox1.Location = new System.Drawing.Point(631, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(212, 678);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задание 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.task2);
            this.groupBox2.Location = new System.Drawing.Point(849, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 678);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задание 2";
            // 
            // task2
            // 
            this.task2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task2.FormattingEnabled = true;
            this.task2.Location = new System.Drawing.Point(3, 16);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(194, 659);
            this.task2.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 719);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.compose);
            this.Controls.Add(this.text);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Main";
            this.Text = "Подготовка текстов";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Button compose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addtoex1;
        private System.Windows.Forms.ToolStripMenuItem addtoex2;
        private System.Windows.Forms.ToolStripMenuItem добавитьВЗадание3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addtoex3synonyms;
        private System.Windows.Forms.ToolStripMenuItem addtoex3antonyms;
        private System.Windows.Forms.ListBox task1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox task2;
    }
}

