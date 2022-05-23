using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace Duncan_CourseProject_CEIS209
{
    public partial class VideoManagerForm : Form
    {
        //Declare arrays of titles, artists, genres, years, and URLs.
        string[] titleArray = new string[5];
        string[] artistArray = new string[5];
        string[] genreArray = new string[5];
        string[] urlArray = new string[5];
        int[] yearArray = new int[5];
        int songCount = 0;
        int songIndex;
        string[] songSaveArray = new string[5];

        public VideoManagerForm()
        {
            InitializeComponent();
        }

        private int GetSongIndex(string songTitle)
        {
            int index = songList.Items.IndexOf(songTitle);
            return index;
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
            else if (int.TryParse(yearText.Text, out int value ) == false)
                {
                MessageBox.Show("the Year must contain only numbers!");
                return notValid;
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                MessageBox.Show("the URL cannot be blank!");
                return notValid;
            }
            else if (songCount > 4)
            { 
                MessageBox.Show("5-song limit has been reached");
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
                // Adds title, artists, genre, year, and url to arrays
                songList.Items.Add(titleText.Text);
                titleArray[songCount] = titleText.Text;
                artistArray[songCount] = artistText.Text;
                genreArray[songCount] = genreComboBox.SelectedItem.ToString();
                urlArray[songCount] = urlText.Text;
                yearArray[songCount] = int.Parse(yearText.Text);

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
                songSaveArray[songCount] = sb.ToString();
                MessageBox.Show(titleText.Text + " successfully added!");

                // Increments song counter after every song added
                songCount = songCount + 1;
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
            StringBuilder sb = new StringBuilder(string.Empty);
            string n1 = "\r\n";

            if (SongInList(titleText.Text))
            {
                songIndex = GetSongIndex(titleText.Text);
                sb.Append(titleArray[songIndex]);
                sb.Append(n1);
                sb.Append(artistArray[songIndex]);
                sb.Append(n1);
                sb.Append(genreArray[songIndex]);
                sb.Append(n1);
                sb.Append(yearArray[songIndex].ToString());
                sb.Append(n1);
                sb.Append(urlArray[songIndex]);
                sb.Append(n1);

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

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string n1 = "\r\n";

            songIndex = songList.SelectedIndex;

            sb.Append(titleArray[songIndex]);
            sb.Append(n1);
            sb.Append(artistArray[songIndex]);
            sb.Append(n1);
            sb.Append(genreArray[songIndex]);
            sb.Append(n1);
            sb.Append(yearArray[songIndex].ToString());
            sb.Append(n1);
            sb.Append(urlArray[songIndex]);
            sb.Append(n1);

            outputText.Text = sb.ToString();           
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            songIndex=songList.SelectedIndex;

            if (songIndex != -1)
            {
                String url = urlArray[songIndex];
                webViewDisplay.CoreWebView2.Navigate("https://" + url);
            }
           
        }


        // Save File Section ==================================================
        private void Data()
        {
            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // This will create a file named CEIS209_Song-List.txt
            // at the specified location 
            StreamWriter sw = new StreamWriter(Path.Combine(docPath, "CEIS209_Song-List.txt"));

            // To write a line in buffer
            foreach (var item in songSaveArray)
            {
                sw.WriteLine(item);
            }

            // To write in output stream
            sw.Flush();

            // To close the stream
            sw.Close();

            // Shows user where the files saved
            MessageBox.Show("File saved at: " + docPath);
        }

        private void saveSongList_Click(object sender, EventArgs e)
        {
            // When save button is clicked,
            // Calls data() to save file
            Data();
        }
    }
}