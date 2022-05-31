
namespace CinemaBookingSystem
{
    partial class ViewMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMovies));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOfShowingPck = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeOfShowingCb = new System.Windows.Forms.ComboBox();
            this.SeatsTb = new System.Windows.Forms.TextBox();
            this.GenreCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MovieNameTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.MovieIdTb = new System.Windows.Forms.TextBox();
            this.MovieDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(329, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "View Scheduled Movies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(298, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cinema Booking System";
            // 
            // DateOfShowingPck
            // 
            this.DateOfShowingPck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfShowingPck.Location = new System.Drawing.Point(206, 297);
            this.DateOfShowingPck.Name = "DateOfShowingPck";
            this.DateOfShowingPck.Size = new System.Drawing.Size(241, 32);
            this.DateOfShowingPck.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(462, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "TimeOfShowing";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TimeOfShowingCb
            // 
            this.TimeOfShowingCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOfShowingCb.FormattingEnabled = true;
            this.TimeOfShowingCb.Items.AddRange(new object[] {
            "10 am",
            "12pm",
            "14pm",
            "16pm",
            "18pm",
            "19pm"});
            this.TimeOfShowingCb.Location = new System.Drawing.Point(671, 246);
            this.TimeOfShowingCb.Name = "TimeOfShowingCb";
            this.TimeOfShowingCb.Size = new System.Drawing.Size(218, 31);
            this.TimeOfShowingCb.TabIndex = 28;
            // 
            // SeatsTb
            // 
            this.SeatsTb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SeatsTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsTb.ForeColor = System.Drawing.Color.DarkOrange;
            this.SeatsTb.Location = new System.Drawing.Point(671, 301);
            this.SeatsTb.Name = "SeatsTb";
            this.SeatsTb.Size = new System.Drawing.Size(215, 32);
            this.SeatsTb.TabIndex = 27;
            this.SeatsTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenreCb
            // 
            this.GenreCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreCb.FormattingEnabled = true;
            this.GenreCb.Items.AddRange(new object[] {
            "Comedy",
            "Romance",
            "Thriller",
            "Drama",
            "Historical",
            "Horror",
            "Kids",
            "Documentary",
            "Action",
            "Fantasy",
            "SciFi"});
            this.GenreCb.Location = new System.Drawing.Point(206, 249);
            this.GenreCb.Name = "GenreCb";
            this.GenreCb.Size = new System.Drawing.Size(241, 31);
            this.GenreCb.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(463, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(10, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "DateOfShowing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(10, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(463, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Movie Name";
            // 
            // MovieNameTb
            // 
            this.MovieNameTb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MovieNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieNameTb.ForeColor = System.Drawing.Color.DarkOrange;
            this.MovieNameTb.Location = new System.Drawing.Point(671, 195);
            this.MovieNameTb.Name = "MovieNameTb";
            this.MovieNameTb.Size = new System.Drawing.Size(218, 32);
            this.MovieNameTb.TabIndex = 21;
            this.MovieNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(508, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 33;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(159, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(334, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 42);
            this.button3.TabIndex = 34;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(678, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 42);
            this.button4.TabIndex = 35;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(881, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 28);
            this.label8.TabIndex = 36;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(678, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 28);
            this.panel1.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(12, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 28);
            this.label9.TabIndex = 41;
            this.label9.Text = "Movie Id";
            // 
            // MovieIdTb
            // 
            this.MovieIdTb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MovieIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieIdTb.ForeColor = System.Drawing.Color.DarkOrange;
            this.MovieIdTb.Location = new System.Drawing.Point(206, 199);
            this.MovieIdTb.Name = "MovieIdTb";
            this.MovieIdTb.Size = new System.Drawing.Size(241, 32);
            this.MovieIdTb.TabIndex = 40;
            this.MovieIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MovieDGV
            // 
            this.MovieDGV.BackgroundColor = System.Drawing.Color.White;
            this.MovieDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDGV.Location = new System.Drawing.Point(17, 403);
            this.MovieDGV.Name = "MovieDGV";
            this.MovieDGV.RowHeadersWidth = 70;
            this.MovieDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.MovieDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.MovieDGV.RowTemplate.Height = 25;
            this.MovieDGV.Size = new System.Drawing.Size(862, 334);
            this.MovieDGV.TabIndex = 46;
            this.MovieDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieDGV_CellContentClick);
            // 
            // ViewMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(905, 749);
            this.Controls.Add(this.MovieDGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MovieIdTb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateOfShowingPck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimeOfShowingCb);
            this.Controls.Add(this.SeatsTb);
            this.Controls.Add(this.GenreCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MovieNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMovies";
            this.Load += new System.EventHandler(this.ViewMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateOfShowingPck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TimeOfShowingCb;
        private System.Windows.Forms.TextBox SeatsTb;
        private System.Windows.Forms.ComboBox GenreCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MovieNameTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MovieIdTb;
        private System.Windows.Forms.DataGridView MovieDGV;
    }
}