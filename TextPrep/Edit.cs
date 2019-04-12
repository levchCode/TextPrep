using System;
using System.Windows.Forms;

namespace TextPrep
{
    public partial class Edit : Form
    {
        public string w;
        public Edit(string word)
        {
            w = word;
            InitializeComponent();
            newWord.Text = w;
        }

        private void edited_Click(object sender, EventArgs e)
        {
            w = newWord.Text;
            Close();
        }
    }
}
