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

        private bool ValidInput()
        {
            //Create the ValidInput() function.
            //Here you will take the input validation code from your AddButton_Click event handler method
            if (string.IsNullOrEmpty(titleText.Text))
            {
                // Title is blank
               MessageBox.Show("The song title cannot be blank!");
               return false;
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                // **** is blank
                MessageBox.Show("the artist cannot be blank!");
                return false;
            }
            else if (string.IsNullOrEmpty(genreText.Text))
            {
                // **** is blank
                MessageBox.Show("the genre cannot be blank!");
                return false;
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                // **** is blank
                MessageBox.Show("the year cannot be blank!");
                return false;
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                // **** is blank
                MessageBox.Show("the url cannot be blank!");
                return false;
            }
            else
            //and use it to make an independent method that returns true
            //if all of the fields are non-empty and false if at least one is empty.
            //As a side effect, it pops up a MessageBox indicating the first empty field that it finds.
            return true;
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
