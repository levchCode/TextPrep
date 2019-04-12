using System;
using System.Windows.Forms;

namespace TextPrep
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void compose_Click(object sender, EventArgs e)
        {
            string Final = text.Rtf;

            int i = 1;

            Final += "\n\n";
            Final += "Задание 1. Найдите следующие слова в тексте. Переведите на русский \n\n";
            foreach (string s1 in task1.Items)
            {
                Final +=  i + ". (" + s1 + ") " + Requests.sendYandex(s1, "ru-en") + "\n";
                i++;
            }

            Final += "\n";
            Final += "Задание 2. Переведите слова на английский. \n\n";
            foreach (string s2 in task2.Items)
            {
                Final += i + ". " + s2 + " (" + Requests.sendYandex(s2, "en") + ") \n";
                i++;
            }

            Result r = new Result(Final);
            r.Show();
        }

       
        private void addtoex1_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit(text.SelectedText);
            ed.FormClosed += Ed_Task1;
            ed.Show();

            void Ed_Task1(object s, FormClosedEventArgs eq)
            {
                task1.Items.Add(ed.w);
            }

        }

        

        private void addtoex2_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit(text.SelectedText);
            ed.Show();
            task2.Items.Add(text.SelectedText);
        }

    }
}
