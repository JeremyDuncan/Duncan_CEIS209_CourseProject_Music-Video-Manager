using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duncan_CourseProject_part1
{
    public partial class videoManagerForm : Form
    {
        public videoManagerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string n1 = "\r\n";
            sb.Append(titleText.Text);
            sb.Append(n1);
            sb.Append(artistText.Text);
            sb.Append(n1);
            sb.Append(genreText.Text);
            sb.Append(n1);
            sb.Append(yearText.Text);
            sb.Append(n1);
            sb.Append(urlText.Text);
            sb.Append(n1);
            outputText.Text = sb.ToString();
        }
    }
}
