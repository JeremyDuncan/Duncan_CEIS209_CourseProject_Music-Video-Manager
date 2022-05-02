namespace Duncan_CourseProject_part1
{
    partial class videoManagerForm
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
            this.genreText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(174, 66);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(447, 38);
            this.titleText.TabIndex = 0;
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(174, 145);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(447, 38);
            this.artistText.TabIndex = 1;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(174, 225);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(447, 38);
            this.genreText.TabIndex = 2;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(174, 323);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(447, 38);
            this.yearText.TabIndex = 3;
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(174, 408);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(447, 38);
            this.urlText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "URL";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(232, 511);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(322, 95);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(715, 48);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(734, 645);
            this.outputText.TabIndex = 11;
            // 
            // videoManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 818);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.titleText);
            this.MinimumSize = new System.Drawing.Size(400, 0);
            this.Name = "videoManagerForm";
            this.Text = "Video Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox outputText;
    }
}

