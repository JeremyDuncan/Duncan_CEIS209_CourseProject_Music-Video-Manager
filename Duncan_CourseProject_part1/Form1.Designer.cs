namespace Duncan_CourseProject_CEIS209
{
    partial class VideoManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.AllSongsButton = new System.Windows.Forms.Button();
            this.songList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.clearSong = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.playButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(65, 28);
            this.titleText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(170, 20);
            this.titleText.TabIndex = 0;
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(65, 61);
            this.artistText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(170, 20);
            this.artistText.TabIndex = 1;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(65, 135);
            this.yearText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(170, 20);
            this.yearText.TabIndex = 3;
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(65, 171);
            this.urlText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(170, 20);
            this.urlText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "URL";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(250, 28);
            this.addButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 40);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(10, 491);
            this.outputText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(284, 158);
            this.outputText.TabIndex = 10;
            // 
            // AllSongsButton
            // 
            this.AllSongsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllSongsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllSongsButton.Location = new System.Drawing.Point(250, 109);
            this.AllSongsButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AllSongsButton.Name = "AllSongsButton";
            this.AllSongsButton.Size = new System.Drawing.Size(121, 40);
            this.AllSongsButton.TabIndex = 6;
            this.AllSongsButton.Text = "Show All Songs";
            this.AllSongsButton.UseVisualStyleBackColor = false;
            this.AllSongsButton.Click += new System.EventHandler(this.AllSongsButton_Click);
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.Location = new System.Drawing.Point(10, 282);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(284, 160);
            this.songList.TabIndex = 9;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Song List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 462);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Details";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(250, 67);
            this.findButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(121, 40);
            this.findButton.TabIndex = 7;
            this.findButton.Text = "Find Song";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // clearSong
            // 
            this.clearSong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSong.Location = new System.Drawing.Point(250, 150);
            this.clearSong.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.clearSong.Name = "clearSong";
            this.clearSong.Size = new System.Drawing.Size(121, 40);
            this.clearSong.TabIndex = 8;
            this.clearSong.Text = "Clear Song";
            this.clearSong.UseVisualStyleBackColor = false;
            this.clearSong.Click += new System.EventHandler(this.ClearSong_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Rock",
            "Classical",
            "Rap",
            "Industrial",
            "Hip-Hop",
            "Country"});
            this.genreComboBox.Location = new System.Drawing.Point(65, 94);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(170, 21);
            this.genreComboBox.TabIndex = 2;
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDisplay.Location = new System.Drawing.Point(387, 12);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(482, 565);
            this.webViewDisplay.Source = new System.Uri("https://github.com/JeremyDuncan", System.UriKind.Absolute);
            this.webViewDisplay.TabIndex = 16;
            this.webViewDisplay.ZoomFactor = 1D;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(570, 609);
            this.playButton.Margin = new System.Windows.Forms.Padding(1);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(121, 40);
            this.playButton.TabIndex = 17;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // VideoManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 659);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.clearSong);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.AllSongsButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.titleText);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MinimumSize = new System.Drawing.Size(163, 60);
            this.Name = "VideoManagerForm";
            this.Text = "Video Manager";
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button AllSongsButton;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button clearSong;
        private System.Windows.Forms.ComboBox genreComboBox;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button playButton;
    }
}

