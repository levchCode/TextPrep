using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
