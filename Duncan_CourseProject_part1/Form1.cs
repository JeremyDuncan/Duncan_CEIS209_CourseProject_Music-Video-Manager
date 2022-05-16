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

        private bool SongInList(string songTitle)
        {
            bool flag = false;
            foreach (var item in songList.Items)
            {
                String currentSong = item as string;
                if (songTitle == currentSong)
                {
                    flag = true;
                }
            }
            return flag;
        }



        private bool ValidInput()
        {
            bool isValid = true;
            bool notValid = false;

            if (string.IsNullOrEmpty(titleText.Text))
            {
               MessageBox.Show("The Song Title cannot be blank!");
               return notValid;
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                MessageBox.Show("the Artist cannot be blank!");
                return notValid;
            }
            else if (string.IsNullOrEmpty(genreComboBox.Text))
            {
                MessageBox.Show("the Genre cannot be blank!");
                return notValid;
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                MessageBox.Show("the Year cannot be blank!");
                return notValid;
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                MessageBox.Show("the URL cannot be blank!");
                return notValid;
            }
            else
            {
                return isValid;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            outputText.Text = "";

            StringBuilder sb = new StringBuilder(outputText.Text);
            string n1 = "\r\n";

            if (ValidInput()) // If all text boxes have input 
            {
                // No blank inputs,
                // Build output text
                sb.Append(titleText.Text);
                sb.Append(n1);
                sb.Append(artistText.Text);
                sb.Append(n1);
                sb.Append(genreComboBox.Text);
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

        private void FindButton_Click(object sender, EventArgs e)
        {
            if(SongInList(titleText.Text))
            {
                MessageBox.Show("Song Found");
            }
            else
            {
                MessageBox.Show("Song not in List!");
            }

        }

        private void ClearSong_Click(object sender, EventArgs e)
        {
            titleText.Text = "";
            artistText.Text = "";
            genreComboBox.Text = "";
            yearText.Text = "";
            urlText.Text = "";
        }
    }
}
