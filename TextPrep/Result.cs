using System;
using System.Windows.Forms;
using System.IO;

namespace TextPrep
{
    public partial class Result : Form
    {
        public Result(string f)
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
                MessageBox.Show("Загружено на Google Drive", "Загружено", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Не могу соединиться с сервисами Google Drive", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save lesson";
            saveFileDialog1.Filter = "Text file | *.txt";
            saveFileDialog1.FileName = "Lesson " + name.Text;

            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName + ".txt";
                File.WriteAllText(path, FinalText.Text);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

                System.Diagnostics.Process.Start("http://translate.yandex.com/");
        }
    }
}
