using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMoviesTable
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(WindowsMoviesTable.Properties.Settings.Default.con);
        SqlDataReader dr = null;
        SqlCommand cmd = null;
        DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmoviename.Visible = false;
            lblShowMovieName.Visible = false;
            lblActor.Visible = false;
            ShowactorName.Visible = false;
            lblticketSold.Visible = false;
            ShowTicketsSold.Visible = false;
            ShowData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMovie_Click(object sender, EventArgs e)
        {
            lblmoviename.Visible = true;
            lblShowMovieName.Visible = true;
            lblActor.Visible = true;
            ShowactorName.Visible = true;
            lblticketSold.Visible = true;
            ShowTicketsSold.Visible = true;
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_ShowMovieDetails", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MovieId", SqlDbType.Int).Value= txtmovieId.Text;
                    cn.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (dr.HasRows && dr.Read())
                    {
                        lblShowMovieName.Text = dr["MovieName"].ToString();
                        ShowactorName.Text = dr["ActorName"].ToString();
                        ShowTicketsSold.Text = dr["TicketCollection"].ToString();
                    }
                    else
                    {
                        lblmoviename.Visible = false;
                        lblShowMovieName.Visible = false;
                        lblActor.Visible = false;
                        ShowactorName.Visible = false;
                        lblticketSold.Visible = false;
                        ShowTicketsSold.Visible = false;
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ShowData()
        {
            using (cmd = new SqlCommand("Select * from Movie", cn))
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
                cn.Close();
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("[sp_UpdateMovie1]", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MovieId", SqlDbType.Int).Value = txtUpdateMovieId.Text;
                    cmd.Parameters.Add("@MovieName", SqlDbType.VarChar, 40).Value = txtUpdateMovieName.Text;
                    cmd.Parameters.Add("@ActorName", SqlDbType.VarChar, 20).Value = txtUdapeActorName.Text;
                    cmd.Parameters.Add("@TicketCollection", SqlDbType.Int).Value = txtUpdateTickets.Text;

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cn.Close();
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btninsertmovie_Click(object sender, EventArgs e)
        {      

        }

        private void btnInsertMov_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("[sp_InsertMovie]", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MovieId", SqlDbType.Int).Value = txtUpdateMovieId.Text;
                    cmd.Parameters.Add("@MovieName", SqlDbType.VarChar, 40).Value = txtUpdateMovieName.Text;
                    cmd.Parameters.Add("@ActorName", SqlDbType.VarChar, 20).Value = txtUdapeActorName.Text;
                    cmd.Parameters.Add("@TicketCollection", SqlDbType.Int).Value = txtUpdateTickets.Text;

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cn.Close();
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
