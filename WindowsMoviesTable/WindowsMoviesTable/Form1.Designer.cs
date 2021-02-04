
namespace WindowsMoviesTable
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.txtmovieId = new System.Windows.Forms.TextBox();
            this.lblmoviename = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblticketSold = new System.Windows.Forms.Label();
            this.btnShowMovie = new System.Windows.Forms.Button();
            this.lblShowMovieName = new System.Windows.Forms.Label();
            this.ShowactorName = new System.Windows.Forms.Label();
            this.ShowTicketsSold = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateMovieId = new System.Windows.Forms.TextBox();
            this.txtUpdateMovieName = new System.Windows.Forms.TextBox();
            this.txtUdapeActorName = new System.Windows.Forms.TextBox();
            this.txtUpdateTickets = new System.Windows.Forms.TextBox();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btninsertmovie = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btninsertmovie);
            this.tabPage1.Controls.Add(this.ShowTicketsSold);
            this.tabPage1.Controls.Add(this.ShowactorName);
            this.tabPage1.Controls.Add(this.lblShowMovieName);
            this.tabPage1.Controls.Add(this.btnShowMovie);
            this.tabPage1.Controls.Add(this.lblticketSold);
            this.tabPage1.Controls.Add(this.lblActor);
            this.tabPage1.Controls.Add(this.lblmoviename);
            this.tabPage1.Controls.Add(this.txtmovieId);
            this.tabPage1.Controls.Add(this.lblMovieId);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movie Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Show Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUpdateMovie);
            this.tabPage3.Controls.Add(this.txtUpdateTickets);
            this.tabPage3.Controls.Add(this.txtUdapeActorName);
            this.tabPage3.Controls.Add(this.txtUpdateMovieName);
            this.tabPage3.Controls.Add(this.txtUpdateMovieId);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(709, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Movies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(82, 39);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(97, 17);
            this.lblMovieId.TabIndex = 0;
            this.lblMovieId.Text = "enter movie Id";
            // 
            // txtmovieId
            // 
            this.txtmovieId.Location = new System.Drawing.Point(217, 39);
            this.txtmovieId.Name = "txtmovieId";
            this.txtmovieId.Size = new System.Drawing.Size(100, 22);
            this.txtmovieId.TabIndex = 1;
            // 
            // lblmoviename
            // 
            this.lblmoviename.AutoSize = true;
            this.lblmoviename.Location = new System.Drawing.Point(102, 126);
            this.lblmoviename.Name = "lblmoviename";
            this.lblmoviename.Size = new System.Drawing.Size(82, 17);
            this.lblmoviename.TabIndex = 2;
            this.lblmoviename.Text = "MovieName";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(102, 173);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(41, 17);
            this.lblActor.TabIndex = 3;
            this.lblActor.Text = "Actor";
            // 
            // lblticketSold
            // 
            this.lblticketSold.AutoSize = true;
            this.lblticketSold.Location = new System.Drawing.Point(102, 225);
            this.lblticketSold.Name = "lblticketSold";
            this.lblticketSold.Size = new System.Drawing.Size(81, 17);
            this.lblticketSold.TabIndex = 4;
            this.lblticketSold.Text = "TicketsSold";
            // 
            // btnShowMovie
            // 
            this.btnShowMovie.Location = new System.Drawing.Point(229, 300);
            this.btnShowMovie.Name = "btnShowMovie";
            this.btnShowMovie.Size = new System.Drawing.Size(168, 23);
            this.btnShowMovie.TabIndex = 5;
            this.btnShowMovie.Text = "Show Movie";
            this.btnShowMovie.UseVisualStyleBackColor = true;
            this.btnShowMovie.Click += new System.EventHandler(this.btnShowMovie_Click);
            // 
            // lblShowMovieName
            // 
            this.lblShowMovieName.AutoSize = true;
            this.lblShowMovieName.Location = new System.Drawing.Point(277, 126);
            this.lblShowMovieName.Name = "lblShowMovieName";
            this.lblShowMovieName.Size = new System.Drawing.Size(46, 17);
            this.lblShowMovieName.TabIndex = 6;
            this.lblShowMovieName.Text = "label1";
            // 
            // ShowactorName
            // 
            this.ShowactorName.AutoSize = true;
            this.ShowactorName.Location = new System.Drawing.Point(277, 172);
            this.ShowactorName.Name = "ShowactorName";
            this.ShowactorName.Size = new System.Drawing.Size(46, 17);
            this.ShowactorName.TabIndex = 7;
            this.ShowactorName.Text = "label2";
            this.ShowactorName.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShowTicketsSold
            // 
            this.ShowTicketsSold.AutoSize = true;
            this.ShowTicketsSold.Location = new System.Drawing.Point(277, 225);
            this.ShowTicketsSold.Name = "ShowTicketsSold";
            this.ShowTicketsSold.Size = new System.Drawing.Size(46, 17);
            this.ShowTicketsSold.TabIndex = 8;
            this.ShowTicketsSold.Text = "label3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(352, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MovieId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MovieName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ActorName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "TicketsSold";
            // 
            // txtUpdateMovieId
            // 
            this.txtUpdateMovieId.Location = new System.Drawing.Point(337, 54);
            this.txtUpdateMovieId.Name = "txtUpdateMovieId";
            this.txtUpdateMovieId.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateMovieId.TabIndex = 4;
            // 
            // txtUpdateMovieName
            // 
            this.txtUpdateMovieName.Location = new System.Drawing.Point(337, 108);
            this.txtUpdateMovieName.Name = "txtUpdateMovieName";
            this.txtUpdateMovieName.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateMovieName.TabIndex = 5;
            // 
            // txtUdapeActorName
            // 
            this.txtUdapeActorName.Location = new System.Drawing.Point(337, 161);
            this.txtUdapeActorName.Name = "txtUdapeActorName";
            this.txtUdapeActorName.Size = new System.Drawing.Size(100, 22);
            this.txtUdapeActorName.TabIndex = 6;
            // 
            // txtUpdateTickets
            // 
            this.txtUpdateTickets.Location = new System.Drawing.Point(337, 214);
            this.txtUpdateTickets.Name = "txtUpdateTickets";
            this.txtUpdateTickets.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateTickets.TabIndex = 7;
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(278, 284);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(128, 23);
            this.btnUpdateMovie.TabIndex = 8;
            this.btnUpdateMovie.Text = "UpdateMovie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btninsertmovie
            // 
            this.btninsertmovie.Location = new System.Drawing.Point(467, 300);
            this.btninsertmovie.Name = "btninsertmovie";
            this.btninsertmovie.Size = new System.Drawing.Size(141, 23);
            this.btninsertmovie.TabIndex = 9;
            this.btninsertmovie.Text = "InsertMovie";
            this.btninsertmovie.UseVisualStyleBackColor = true;
            this.btninsertmovie.Click += new System.EventHandler(this.btninsertmovie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label ShowTicketsSold;
        private System.Windows.Forms.Label ShowactorName;
        private System.Windows.Forms.Label lblShowMovieName;
        private System.Windows.Forms.Button btnShowMovie;
        private System.Windows.Forms.Label lblticketSold;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblmoviename;
        private System.Windows.Forms.TextBox txtmovieId;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.TextBox txtUpdateTickets;
        private System.Windows.Forms.TextBox txtUdapeActorName;
        private System.Windows.Forms.TextBox txtUpdateMovieName;
        private System.Windows.Forms.TextBox txtUpdateMovieId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninsertmovie;
    }
}

