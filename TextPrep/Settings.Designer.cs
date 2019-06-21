namespace TextPrep
{
    partial class Settings
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
            this.mainLang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.yandexKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.learnLang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ex1_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ex2_text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pair_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mainLang
            // 
            this.mainLang.Location = new System.Drawing.Point(173, 100);
            this.mainLang.Name = "mainLang";
            this.mainLang.Size = new System.Drawing.Size(76, 20);
            this.mainLang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language pair";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yandexKey
            // 
            this.yandexKey.Location = new System.Drawing.Point(12, 31);
            this.yandexKey.Name = "yandexKey";
            this.yandexKey.Size = new System.Drawing.Size(276, 20);
            this.yandexKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yandex.Translate API key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Main";
            // 
            // learnLang
            // 
            this.learnLang.Location = new System.Drawing.Point(255, 100);
            this.learnLang.Name = "learnLang";
            this.learnLang.Size = new System.Drawing.Size(76, 20);
            this.learnLang.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Learn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ex. 1 (main -> learn)";
            // 
            // ex1_text
            // 
            this.ex1_text.Location = new System.Drawing.Point(12, 154);
            this.ex1_text.Name = "ex1_text";
            this.ex1_text.Size = new System.Drawing.Size(483, 20);
            this.ex1_text.TabIndex = 10;
            this.ex1_text.Text = "Задание 1. Найдите следующие слова в тексте. Переведите на русский.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ex. 2 (learn -> main)";
            // 
            // ex2_text
            // 
            this.ex2_text.Location = new System.Drawing.Point(12, 203);
            this.ex2_text.Name = "ex2_text";
            this.ex2_text.Size = new System.Drawing.Size(483, 20);
            this.ex2_text.TabIndex = 12;
            this.ex2_text.Text = "Задание 2. Переведите слова на английский.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Check avaliable language pairs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pair_list
            // 
            this.pair_list.FormattingEnabled = true;
            this.pair_list.Location = new System.Drawing.Point(510, 12);
            this.pair_list.Name = "pair_list";
            this.pair_list.Size = new System.Drawing.Size(120, 212);
            this.pair_list.TabIndex = 14;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 259);
            this.Controls.Add(this.pair_list);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ex2_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ex1_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.learnLang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yandexKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainLang);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox yandexKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox learnLang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ex1_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ex2_text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox pair_list;
    }
}