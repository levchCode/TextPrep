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
            FinalText.Rtf = f;
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
    }
}
