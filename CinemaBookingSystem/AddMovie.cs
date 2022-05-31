using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace CinemaBookingSystem
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        // realizam o noua conexiune la baza de date sql creata CinemaDb
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\CinemaDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite prin apasarea butonului record
            //sa inregistram un nou film si informatii de spre acesta in baza de date
            if ( MovieIdTb.Text == "" || MovieNameTb.Text == "" || GenreCb.SelectedItem.ToString() == "" || TimeOfShowingCb.SelectedItem.ToString() == "" || DateOfShowingPck.Text == "" || SeatsTb.Text == "")
            {
                MessageBox.Show("Missing information!Please complete the fields.");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "insert into MovieTbl values(" + MovieIdTb.Text + ",'" + MovieNameTb.Text + "','" + GenreCb.SelectedItem.ToString() + "','" + TimeOfShowingCb.SelectedItem.ToString() + "','" + DateOfShowingPck.Value.ToString() + "','" + SeatsTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie Recorded Successfully");
                    Connection.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de reset
            //valorile campurilor vor deveni goale
            MovieIdTb.Text = "";
            MovieNameTb.Text = "";
            GenreCb.Text = "";
            TimeOfShowingCb.Text = "";
            SeatsTb.Text = "";
        }


        private void buttonViewMovies_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite prin apasarea butonului View Movies
            //sa avem acces la formul ViewMovies si sa vedem informatiile despre filmele din baza de date
            ViewMovies viewmovie = new ViewMovies();
            viewmovie.Show();
            this.Hide();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            //afisarea extensiei help la apasarea butonului cu acelasi nume
            //MessageBox.Show("Help");
            Help.ShowHelp(this, "C:/Users/User/Desktop/2022/An3/SemII/IP/Proiect/Rezervare online pentru bilete la cinema/Beta version/CinemaBookingSystem/Help-Rezervare online pentru biletele la cinema.chm");

        }
    }
}
