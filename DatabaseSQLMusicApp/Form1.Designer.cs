﻿namespace DatabaseSQLMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            button3 = new Button();
            txt_description = new TextBox();
            txt_imageURL = new TextBox();
            txt_year = new TextBox();
            txt_artist = new TextBox();
            txt_albumName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            button5 = new Button();
            txt_trackLyrics = new TextBox();
            txt_trackVideoURL = new TextBox();
            txt_trackNumber = new TextBox();
            txt_trackTitle = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(385, 20);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(386, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(739, 310);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(794, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(1031, 22);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1131, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_imageURL);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(txt_artist);
            groupBox1.Controls.Add(txt_albumName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 296);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 239);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(54, 24);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Edit";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(129, 239);
            button3.Name = "button3";
            button3.Size = new Size(157, 29);
            button3.TabIndex = 10;
            button3.Text = "Add / Modify";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(128, 193);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(158, 27);
            txt_description.TabIndex = 9;
            // 
            // txt_imageURL
            // 
            txt_imageURL.Location = new Point(128, 152);
            txt_imageURL.Name = "txt_imageURL";
            txt_imageURL.Size = new Size(158, 27);
            txt_imageURL.TabIndex = 8;
            // 
            // txt_year
            // 
            txt_year.Location = new Point(128, 111);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(158, 27);
            txt_year.TabIndex = 7;
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(128, 70);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(158, 27);
            txt_artist.TabIndex = 6;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(128, 29);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(158, 27);
            txt_albumName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 155);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Image URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(386, 394);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            label6.Click += label6_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(386, 426);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(622, 188);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // button4
            // 
            button4.Location = new Point(386, 634);
            button4.Name = "button4";
            button4.Size = new Size(180, 29);
            button4.TabIndex = 8;
            button4.Text = "Delete Selected Track";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(txt_trackLyrics);
            groupBox2.Controls.Add(txt_trackVideoURL);
            groupBox2.Controls.Add(txt_trackNumber);
            groupBox2.Controls.Add(txt_trackTitle);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI Light", 9F);
            groupBox2.Location = new Point(24, 394);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 236);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Track";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(10, 194);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Edit";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button5
            // 
            button5.Location = new Point(127, 191);
            button5.Name = "button5";
            button5.Size = new Size(155, 29);
            button5.TabIndex = 8;
            button5.Text = "Add / Modify";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txt_trackLyrics
            // 
            txt_trackLyrics.Location = new Point(127, 145);
            txt_trackLyrics.Name = "txt_trackLyrics";
            txt_trackLyrics.Size = new Size(158, 27);
            txt_trackLyrics.TabIndex = 7;
            // 
            // txt_trackVideoURL
            // 
            txt_trackVideoURL.Location = new Point(127, 105);
            txt_trackVideoURL.Name = "txt_trackVideoURL";
            txt_trackVideoURL.Size = new Size(157, 27);
            txt_trackVideoURL.TabIndex = 6;
            // 
            // txt_trackNumber
            // 
            txt_trackNumber.Location = new Point(127, 65);
            txt_trackNumber.Name = "txt_trackNumber";
            txt_trackNumber.Size = new Size(155, 27);
            txt_trackNumber.TabIndex = 5;
            // 
            // txt_trackTitle
            // 
            txt_trackTitle.Location = new Point(127, 25);
            txt_trackTitle.Name = "txt_trackTitle";
            txt_trackTitle.Size = new Size(156, 27);
            txt_trackTitle.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 142);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 3;
            label10.Text = "Lyrics";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 104);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 2;
            label9.Text = "Video URL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 66);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 1;
            label8.Text = "Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 28);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 0;
            label7.Text = "Track Title";
            label7.Click += label7_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(1038, 428);
            webView21.Name = "webView21";
            webView21.Size = new Size(403, 184);
            webView21.Source = new Uri("https://www.youtube.com/watch?v=dQw4w9WgXcQ", UriKind.Absolute);
            webView21.TabIndex = 10;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 672);
            Controls.Add(webView21);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_description;
        private TextBox txt_imageURL;
        private TextBox txt_year;
        private TextBox txt_artist;
        private TextBox txt_albumName;
        private Button button3;
        private Label label6;
        private DataGridView dataGridView2;
        private Button button4;
        private GroupBox groupBox2;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button5;
        private TextBox txt_trackLyrics;
        private TextBox txt_trackVideoURL;
        private TextBox txt_trackNumber;
        private TextBox txt_trackTitle;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
