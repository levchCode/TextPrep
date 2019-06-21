using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace TextPrep
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            if (File.Exists("settings.xml"))
            {
                using (XmlReader reader = XmlReader.Create(@"settings.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            switch (reader.Name.ToString())
                            {
                                case "yandexKey":
                                    yandexKey.Text = reader.ReadString();
                                    break;
                                case "mainLang":
                                    mainLang.Text = reader.ReadString();
                                    break;
                                case "learnLang":
                                    learnLang.Text = reader.ReadString();
                                    break;
                                case "ex1":
                                    ex1_text.Text = reader.ReadString();
                                    break;
                                case "ex2":
                                    ex2_text.Text = reader.ReadString();
                                    break;
                            }
                        }
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            using (XmlWriter writer = XmlWriter.Create("settings.xml"))
            {
                writer.WriteStartElement("main");
                writer.WriteElementString("mainLang", mainLang.Text);
                writer.WriteElementString("learnLang", learnLang.Text);
                writer.WriteElementString("yandexKey", yandexKey.Text);
                writer.WriteElementString("ex1", ex1_text.Text);
                writer.WriteElementString("ex2", ex2_text.Text);
                writer.WriteEndElement();
                writer.Flush();
            }

            Close();

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pair_list.DataSource = Requests.get_pairs();
        }
    }
}
