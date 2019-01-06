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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.compose = new System.Windows.Forms.Button();
            this.task1 = new System.Windows.Forms.ListView();
            this.task2 = new System.Windows.Forms.ListView();
            this.task3 = new System.Windows.Forms.ListView();
            this.task4 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.ContextMenuStrip = this.contextMenuStrip1;
            this.text.Location = new System.Drawing.Point(12, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(625, 703);
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
            this.addtoex3synonyms.Click += new System.EventHandler(this.addtoex3synonyms_Click);
            // 
            // addtoex3antonyms
            // 
            this.addtoex3antonyms.Name = "addtoex3antonyms";
            this.addtoex3antonyms.Size = new System.Drawing.Size(135, 22);
            this.addtoex3antonyms.Text = "Антонимы";
            this.addtoex3antonyms.Click += new System.EventHandler(this.addtoex3antonyms_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задание 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Задание 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(925, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Синонимы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(926, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Антонимы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(926, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Задание 3";
            // 
            // compose
            // 
            this.compose.Location = new System.Drawing.Point(644, 686);
            this.compose.Name = "compose";
            this.compose.Size = new System.Drawing.Size(372, 29);
            this.compose.TabIndex = 10;
            this.compose.Text = "Сформировать";
            this.compose.UseVisualStyleBackColor = true;
            this.compose.Click += new System.EventHandler(this.compose_Click);
            // 
            // task1
            // 
            this.task1.LabelEdit = true;
            this.task1.Location = new System.Drawing.Point(642, 38);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(121, 641);
            this.task1.TabIndex = 11;
            this.task1.UseCompatibleStateImageBehavior = false;
            // 
            // task2
            // 
            this.task2.LabelEdit = true;
            this.task2.Location = new System.Drawing.Point(768, 38);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(121, 641);
            this.task2.TabIndex = 12;
            this.task2.UseCompatibleStateImageBehavior = false;
            // 
            // task3
            // 
            this.task3.LabelEdit = true;
            this.task3.Location = new System.Drawing.Point(894, 63);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(121, 285);
            this.task3.TabIndex = 13;
            this.task3.UseCompatibleStateImageBehavior = false;
            // 
            // task4
            // 
            this.task4.LabelEdit = true;
            this.task4.Location = new System.Drawing.Point(895, 387);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(121, 292);
            this.task4.TabIndex = 14;
            this.task4.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 719);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.compose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Name = "Main";
            this.Text = "Подготовка текстов";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button compose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addtoex1;
        private System.Windows.Forms.ToolStripMenuItem addtoex2;
        private System.Windows.Forms.ToolStripMenuItem добавитьВЗадание3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addtoex3synonyms;
        private System.Windows.Forms.ToolStripMenuItem addtoex3antonyms;
        private System.Windows.Forms.ListView task1;
        private System.Windows.Forms.ListView task2;
        private System.Windows.Forms.ListView task3;
        private System.Windows.Forms.ListView task4;
    }
}

