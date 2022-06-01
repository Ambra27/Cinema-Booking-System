/************************************************************************************************
 *                                                                                              *
 *  File:        ViewMovies.cs                                                                  *
 *  Copyright:   (c) 2021-2022 Furcoi Tase - Isidor, Marmureanu Elena - Adeline                 *
 *               Petrescu Ambra - Costina, Pintilie Vasile - Emilian                            *
 *  E-mail:      tase-isidor.furcoi@student.tuiasi.ro                                           *
 *               elena-adeline.marmureanu@student.tuiasi.ro                                     *
 *               ambra-costina.petrescu@student.tuiasi.ro                                       *
 *               vasile-emilian.pintilie@student.tuiasi.ro                                      *
 *  Description: Implementing the  ViewMovies.cs interface                                      *
 *               Where we can view and update different movie information.                      *
 *               View Movies (Software Engineering Project IP)                                  *
 *                                                                                              *
 *  This code and information is provided "as is" without warranty of                           *
 *  any kind, either expressed or implied, including but not limited                            *
 *  to the implied warranties of merchantability or fitness for a                               *
 *  particular purpose. You are free to use this source code in your                            *
 *  applications as long as the original copyright notice is included.                          *
 *                                                                                              *
 ***********************************************************************************************/

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
            //prin aceasta metoda se popoleaza data grid view-ul cu datele din tabela de interes MovieTbl , modificate sau nu

            Connection.Open();
            string query = "select * from MovieTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            MovieDGV.DataSource = dataset.Tables[0];
            Connection.Close();


        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca X-ul din dreapta de sus a interfetei sa poata
            //iesi din program prin efectuarea unui click asupra acestuia
            Application.Exit();

        }

        private void ViewMovies_Load(object sender, EventArgs e)
        {
            //la accesarea formului ViewMovies se va incarca in datagridview un tabel ce va fi populat cu date din tabela MovieTbl
            Populate();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite prin apasarea butonului Back sa avem acces la Home Menu(formul HomeAdmin.cs)
            HomeAdmin home = new HomeAdmin();
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
            //in aceasta metoda ni se permite prin apasarea butonului Delete sa stergem informatiile unui 
            //film din tabel introducand id-ul filmului in campul MovieId

            //in prim pas verificam daca avem campuri de informatii goale
            if (MovieIdTb.Text == "")
            {
                //in cazul in care avem campuri de informatii goale/necompletat va aparea urmatorul mesaj ca avertizare catre utilizator
                MessageBox.Show("Enter The Movie to Delete");
            }
            else
            {
                //error handling
                try
                {
                    //daca am completat corect informatiile in campurile interfetei se va crea o connexiune la baza de date
                    //ce ne va permite sa inseram in tabela MovieTbl date noi prin comanda ce o vom stoca in variabila cmd
                    //ca mai apoi sa fie executata prin apelul functiei ExecuteNonQuery
                    Connection.Open();
                    string query = "delete from MovieTbl where MovieId=" + MovieIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();

                    //dupa inserarea noilor date in tabel urmatorul mesaj va aparea intr-un MessageBox
                    //ca mai apoi conexiunea cu baze de date sa fie inchisa prin apelarea functiei Close
                    MessageBox.Show("Movie Deleted Successfully");
                    Connection.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    //in cazul in care va afea loc o exceptie va aparea un mesaj de eroare generat de Ex.Message ce explica motivul acesteia
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite cand apasam butonul de update sa modificam datele unui film existent


            //in prim pas verificam daca avem campuri de informatii goale
            if (MovieIdTb.Text == "" || MovieNameTb.Text == "" || GenreCb.SelectedItem.ToString() == "" || TimeOfShowingCb.SelectedItem.ToString() == "" || DateOfShowingPck.Text == "" || SeatsTb.Text == "")
            {
                //in cazul in care avem campuri de informatii goale/necompletat va aparea urmatorul mesaj ca avertizare catre utilizator
                MessageBox.Show("Missing Information");
            }
            else
            {
                //error handling
                try
                {
                    //daca am completat corect informatiile in campurile interfetei se va crea o connexiune la baza de date
                    //ce ne va permite sa inseram in tabela MovieTbl date noi prin comanda ce o vom stoca in variabila cmd
                    //ca mai apoi sa fie executata prin apelul functiei ExecuteNonQuery
                    Connection.Open();
                    string query = "update MovieTbl set MovieName='" + MovieNameTb.Text + "',Genre='" + GenreCb.Text + "',TimeOfShowing='" + TimeOfShowingCb.SelectedItem.ToString() + "',DateOfShowing='" + DateOfShowingPck.Text + "',Seats='"+ SeatsTb.Text +"' where MovieId=" + MovieIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();

                    //dupa inserarea noilor date in tabel urmatorul mesaj va aparea intr-un MessageBox
                    //ca mai apoi conexiunea cu baze de date sa fie inchisa prin apelarea functiei Close
                    MessageBox.Show("Movie Updated Successfully");
                    Connection.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    //in cazul in care va afea loc o exceptie va aparea un mesaj de eroare generat de Ex.Message ce explica motivul acesteia
                    MessageBox.Show(Ex.Message);
                    //MessageBox.Show("Missing Information");
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de reset valorile campurilor vor deveni goale
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
