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
    public partial class ViewMovies : Form
    {
        public ViewMovies()
        {
            InitializeComponent();
        }

        // realizam o noua conexiune la baza de date sql creata CinemaDb
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\CinemaDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            //prin aceasta metoda se popoleaza data grid view-ul cu datele 
            //din tabela de interes ,modificate sau nu

            Connection.Open();
            string query = "select * from MovieTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            MovieDGV.DataSource = dataset.Tables[0];
            Connection.Close();


        }


        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ViewMovies_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite prin apasarea butonului Back
            //sa avem acses la formul AddMovies
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void MovieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //in aceasta metoda dorim ca atunci cand selectam un cell de pe un anumit row
            //detaliile din tabel sa apara in campurile ce coincid cu acele informatii
            /*
            MovieIdTb.Text = MovieDGV.SelectedRows[0].Cells[0].Value.ToString();
            MovieNameTb.Text = MovieDGV.SelectedRows[0].Cells[0].Value.ToString();
            GenreCb.Text = MovieDGV.SelectedRows[0].Cells[0].Value.ToString();
            TimeOfShowingTb.Text = MovieDGV.SelectedRows[0].Cells[0].Value.ToString();
            DateOfShowingPck.Text = MovieDGV.SelectedRows[0].Cells[0].Value.ToString();
            SeatsTb.Text = MovieDGV.SelectedRows[0].Cells[0].Value.ToString();
            */
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite prin apasarea butonului delete sa stergem informatiile unui 
            //user din tabel introducand id-ul userului in campul id
            if (MovieIdTb.Text == "")
            {
                MessageBox.Show("Enter The Movie to Delete");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "delete from MovieTbl where MovieId=" + MovieIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie Deleted Successfully");
                    Connection.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite cand apasam butonul de update sa modificam datele
            //unui film existent
            if (MovieIdTb.Text == "" || MovieNameTb.Text == "" || GenreCb.SelectedItem.ToString() == "" || TimeOfShowingCb.SelectedItem.ToString() == "" || DateOfShowingPck.Text == "" || SeatsTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "update MovieTbl set MovieName='" + MovieNameTb.Text + "',Genre='" + GenreCb.Text + "',TimeOfShowing='" + TimeOfShowingCb.SelectedItem.ToString() + "',DateOfShowing='" + DateOfShowingPck.Text + "',Seats='"+ SeatsTb.Text +"' where MovieId=" + MovieIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie Updated Successfully");
                    Connection.Close();
                    Populate();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                    //MessageBox.Show("Missing Information");
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de reset
            //valorile campurilor vor deveni goale
            MovieIdTb.Text = "";
            MovieNameTb.Text = "";
            //GenreCb.SelectedItem = "";
            //TimeOfShowingCb.SelectedItem = "";
            SeatsTb.Text = "";

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            //afisarea extensiei help la apasarea butonului cu acelasi nume
            //MessageBox.Show("Help");
            Help.ShowHelp(this, "C:/Users/User/Desktop/2022/An3/SemII/IP/Proiect/Rezervare online pentru bilete la cinema/Beta version/CinemaBookingSystem/Help-Rezervare online pentru biletele la cinema.chm");

        }
    }
}
