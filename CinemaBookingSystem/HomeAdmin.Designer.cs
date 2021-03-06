
namespace CinemaBookingSystem
{
    partial class HomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Label();
            this.buttonAddMovies = new System.Windows.Forms.Button();
            this.buttonAddUsers = new System.Windows.Forms.Button();
            this.buttonTickets = new System.Windows.Forms.Button();
            this.buttonCancellation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonViewMovies = new System.Windows.Forms.Button();
            this.buttonViewUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(315, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cinema Booking System";
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.BackColor = System.Drawing.Color.Maroon;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonExit.Location = new System.Drawing.Point(877, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(28, 27);
            this.buttonExit.TabIndex = 40;
            this.buttonExit.Text = "X";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 36);
            this.panel1.TabIndex = 41;
            // 
            // buttonHelp
            // 
            this.buttonHelp.AutoSize = true;
            this.buttonHelp.BackColor = System.Drawing.Color.Maroon;
            this.buttonHelp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonHelp.Location = new System.Drawing.Point(3, 8);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(64, 27);
            this.buttonHelp.TabIndex = 50;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonAddMovies
            // 
            this.buttonAddMovies.BackColor = System.Drawing.Color.Maroon;
            this.buttonAddMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddMovies.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMovies.ForeColor = System.Drawing.Color.White;
            this.buttonAddMovies.Location = new System.Drawing.Point(61, 281);
            this.buttonAddMovies.Name = "buttonAddMovies";
            this.buttonAddMovies.Size = new System.Drawing.Size(186, 45);
            this.buttonAddMovies.TabIndex = 42;
            this.buttonAddMovies.Text = "Add Movies";
            this.buttonAddMovies.UseVisualStyleBackColor = false;
            this.buttonAddMovies.Click += new System.EventHandler(this.buttonAddMovies_Click);
            // 
            // buttonAddUsers
            // 
            this.buttonAddUsers.BackColor = System.Drawing.Color.Maroon;
            this.buttonAddUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUsers.ForeColor = System.Drawing.Color.White;
            this.buttonAddUsers.Location = new System.Drawing.Point(681, 281);
            this.buttonAddUsers.Name = "buttonAddUsers";
            this.buttonAddUsers.Size = new System.Drawing.Size(186, 45);
            this.buttonAddUsers.TabIndex = 43;
            this.buttonAddUsers.Text = "Add Users";
            this.buttonAddUsers.UseVisualStyleBackColor = false;
            this.buttonAddUsers.Click += new System.EventHandler(this.buttonAddUsers_Click);
            // 
            // buttonTickets
            // 
            this.buttonTickets.BackColor = System.Drawing.Color.Maroon;
            this.buttonTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTickets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTickets.ForeColor = System.Drawing.Color.White;
            this.buttonTickets.Location = new System.Drawing.Point(61, 382);
            this.buttonTickets.Name = "buttonTickets";
            this.buttonTickets.Size = new System.Drawing.Size(186, 45);
            this.buttonTickets.TabIndex = 44;
            this.buttonTickets.Text = "Tickets";
            this.buttonTickets.UseVisualStyleBackColor = false;
            this.buttonTickets.Click += new System.EventHandler(this.buttonTickets_Click);
            // 
            // buttonCancellation
            // 
            this.buttonCancellation.BackColor = System.Drawing.Color.Maroon;
            this.buttonCancellation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancellation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancellation.ForeColor = System.Drawing.Color.White;
            this.buttonCancellation.Location = new System.Drawing.Point(681, 382);
            this.buttonCancellation.Name = "buttonCancellation";
            this.buttonCancellation.Size = new System.Drawing.Size(186, 45);
            this.buttonCancellation.TabIndex = 45;
            this.buttonCancellation.Text = "Cancellation";
            this.buttonCancellation.UseVisualStyleBackColor = false;
            this.buttonCancellation.Click += new System.EventHandler(this.buttonCancellation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(417, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Home Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // buttonViewMovies
            // 
            this.buttonViewMovies.BackColor = System.Drawing.Color.Maroon;
            this.buttonViewMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonViewMovies.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewMovies.ForeColor = System.Drawing.Color.White;
            this.buttonViewMovies.Location = new System.Drawing.Point(61, 188);
            this.buttonViewMovies.Name = "buttonViewMovies";
            this.buttonViewMovies.Size = new System.Drawing.Size(186, 45);
            this.buttonViewMovies.TabIndex = 48;
            this.buttonViewMovies.Text = "View Movies";
            this.buttonViewMovies.UseVisualStyleBackColor = false;
            this.buttonViewMovies.Click += new System.EventHandler(this.buttonViewMovies_Click);
            // 
            // buttonViewUsers
            // 
            this.buttonViewUsers.BackColor = System.Drawing.Color.Maroon;
            this.buttonViewUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonViewUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewUsers.ForeColor = System.Drawing.Color.White;
            this.buttonViewUsers.Location = new System.Drawing.Point(681, 188);
            this.buttonViewUsers.Name = "buttonViewUsers";
            this.buttonViewUsers.Size = new System.Drawing.Size(186, 45);
            this.buttonViewUsers.TabIndex = 49;
            this.buttonViewUsers.Text = "View Users";
            this.buttonViewUsers.UseVisualStyleBackColor = false;
            this.buttonViewUsers.Click += new System.EventHandler(this.buttonViewUsers_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(907, 496);
            this.Controls.Add(this.buttonViewUsers);
            this.Controls.Add(this.buttonViewMovies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancellation);
            this.Controls.Add(this.buttonTickets);
            this.Controls.Add(this.buttonAddUsers);
            this.Controls.Add(this.buttonAddMovies);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddMovies;
        private System.Windows.Forms.Button buttonAddUsers;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.Button buttonCancellation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonViewMovies;
        private System.Windows.Forms.Button buttonViewUsers;
        private System.Windows.Forms.Label buttonHelp;
    }
}