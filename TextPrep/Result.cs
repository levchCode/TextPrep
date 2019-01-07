using System;
using System.Windows.Forms;
using System.IO;

namespace TextPrep
{
    public partial class Result : Form
    {
        public Result(String f)
        {
            InitializeComponent();
            FinalText.Text = f;
        }

        private void Googledriveupload_Click(object sender, EventArgs e)
        {
            string path = name.Text + ".txt";
            File.WriteAllText(path, FinalText.Text);
            if (Requests.googleupload(path, "Text" + name.Text, "Lesson " + name.Text) == "OK")
            {
                MessageBox.Show("Загружено!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
