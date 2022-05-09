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
        private void addButton_Click(object sender, EventArgs e)
        {
            outputText.Text = "";

            StringBuilder sb = new StringBuilder(outputText.Text);
            string n1 = "\r\n";

            if (string.IsNullOrEmpty(titleText.Text))
            {
                // Title is blank
                MessageBox.Show("The song title cannot be blank!");
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                // Artist is blank
                MessageBox.Show("The artist cannot be blank!");
            }
            else 
            {
                // No blank inputs,
                // Build output text
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
                songList.Items.Add(titleText.Text);
                MessageBox.Show(titleText.Text + " successfully added!");
            }
        }

        private void AllSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string n1 = "\r\n";

            // Build output text
            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(n1);

                // Puts output text to output textbox
                outputText.Text = sb.ToString();
            }
        }
    }
}
