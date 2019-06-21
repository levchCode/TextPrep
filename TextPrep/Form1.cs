using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;

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
            string ex1_text = "";
            string ex2_text = "";

            using (XmlReader reader = XmlReader.Create(@"settings.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                             case "ex1":
                                 ex1_text = reader.ReadString();
                             break;
                             case "ex2":
                                 ex2_text = reader.ReadString();
                             break;
                        }
                    }
                }
            }
            

            string Final = text.Text;

            int i = 1;

            Final += "\n\n";
            Final += ex1_text + " \n\n";
            foreach (string s1 in task1.Items)
            {
                Final +=  i + ". (" + s1 + ") " + Requests.sendYandex(s1, false) + "\n";
                i++;
            }

            Final += "\n";
            Final += ex2_text + " \n\n";
            foreach (string s2 in task2.Items)
            {
                Final += i + ". " + s2 + " (" + Requests.sendYandex(s2, true) + ") \n";
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
            ed.FormClosed += Ed_Task2;
            ed.Show();

            void Ed_Task2(object s, FormClosedEventArgs eq)
            {
                task2.Items.Add(ed.w);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists("settings.xml"))
            {
                Settings set = new Settings();
                set.Show();
            }
        }
    }
}
