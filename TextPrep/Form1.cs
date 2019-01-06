using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextPrep
{
    public partial class Main : Form
    {

        ListViewItem item;

        public Main()
        {
            InitializeComponent();
        }

        private void compose_Click(object sender, EventArgs e)
        {
            String Final = text.Text;

            int i = 1;

            Final += "\n\n";
            Final += "Задание 1. Найдите следующие слова в тексте. Переведите на русский \n\n";
            foreach (ListViewItem s in task1.Items)
            {
                Final +=  i + ". (" + s.Text + ") " + Requests.sendYandex(s.Text) + "\n";
                i++;
            }

            Final += "\n";
            Final += "Задание 2. Переведите слова на английский. \n\n";
            foreach (ListViewItem s in task2.Items)
            {
                Final += i + ". " + s.Text + " (" + Requests.sendYandex(s.Text) + ") \n";
                i++;
            }

            Final += "\n";
            Final += "Задание 3. Сопоставьте слова c их синонимами \n\n";
            foreach (ListViewItem s in task3.Items)
            {
                Final += i + ". " + s.Text + "\n";
                i++;
            }

            Final += "\n";
            Final += "Задание 4. Сопоставьте слова c их антонимами \n\n";
            foreach (ListViewItem s in task4.Items)
            {
                Final += i + ". " + s.Text + "\n";
                i++;
            }

            Result r = new Result(Final);
            r.Show();
        }

       
        private void addtoex1_Click(object sender, EventArgs e)
        {
            item = task1.Items.Add(text.SelectedText);

            item.BeginEdit();
        }

        private void addtoex2_Click(object sender, EventArgs e)
        {
            item = task2.Items.Add(text.SelectedText);

            item.BeginEdit();
        }

        private void addtoex3synonyms_Click(object sender, EventArgs e)
        {
            item = task3.Items.Add(text.SelectedText);

            item.BeginEdit();
        }

        private void addtoex3antonyms_Click(object sender, EventArgs e)
        {
            item = task4.Items.Add(text.SelectedText);

            item.BeginEdit();
        }
    }
}
