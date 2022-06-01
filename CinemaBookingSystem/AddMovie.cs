/************************************************************************************************
 *                                                                                              *
 *  File:        AddMovie.cs                                                                    *
 *  Copyright:   (c) 2021-2022 Furcoi Tase - Isidor, Marmureanu Elena - Adeline                 *
 *               Petrescu Ambra - Costina, Pintilie Vasile - Emilian                            *
 *  E-mail:      tase-isidor.furcoi@student.tuiasi.ro                                           *
 *               elena-adeline.marmureanu@student.tuiasi.ro                                     *
 *               ambra-costina.petrescu@student.tuiasi.ro                                       *
 *               vasile-emilian.pintilie@student.tuiasi.ro                                      *
 *  Description: Implementing the AddMovie.cs interface                                         *
 *               Where we can add a new movie in the database.                                  *
 *               Add Movie (Software Engineering Project IP)                                    *
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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        /// <summary>
        /// realizam o noua conexiune la baza de date sql creata CinemaDb
        /// <summary>
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\CinemaDb.mdf;Integrated Security=True;Connect Timeout=30");

       
        private void buttonExit_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///prin aceasta metoda implementam ca X-ul din dreapta de sus a interfetei sa poata 
            ///iesi din program prin efectuarea unui click asupra acestuia
            /// <summary>
            Application.Exit();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///in aceasta metoda ni se permite prin apasarea butonului record
            ///sa inregistram un nou film si informatii despre acesta in baza de date
            /// <summary>

            /// <summary>
            ///in prim pas verificam daca avem campuri de informatii goale
            /// <summary>
            if ( MovieIdTb.Text == "" || MovieNameTb.Text == "" || GenreCb.SelectedItem.ToString() == "" || TimeOfShowingCb.SelectedItem.ToString() == "" || DateOfShowingPck.Text == "" || SeatsTb.Text == "")
            {
                /// <summary>
                ///in cazul in care avem campuri de informatii goale/necompletate va aparea urmatorul mesaj ca avertizare catre utilizator 
                /// <summary>
                MessageBox.Show("Missing information!Please complete the fields.");
            }
            else
            {
                /// <summary>
                ///error handling
                /// <summary>
                try
                {
                    /// <summary>
                    ///daca am completat informatiile corect in campurile interfetei se va crea o connexiune la baza de date
                    ///ce ne va permite sa inseram in tabela MovieTbl date noi prin comanda ce o vom stoca in variabila cmd
                    ///ca mai apoi sa fie executata prin apelul functiei ExecuteNonQuery
                    /// <summary>
                    Connection.Open();
                    string query = "insert into MovieTbl values(" + MovieIdTb.Text + ",'" + MovieNameTb.Text + "','" + GenreCb.SelectedItem.ToString() + "','" + TimeOfShowingCb.SelectedItem.ToString() + "','" + DateOfShowingPck.Value.ToString() + "','" + SeatsTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();

                    /// <summary>
                    ///dupa inserarea noilor date in tabel urmatorul mesaj va aparea intr-un MessageBox
                    ///ca mai apoi conexiunea cu baze de date sa fie inchisa prin apelarea functiei Close
                    /// <summary>
                    MessageBox.Show("Movie Recorded Successfully");
                    Connection.Close();
                }
                catch (Exception Ex)
                {
                    /// <summary>
                    ///in cazul in care va afea loc o exceptie va aparea un mesaj de eroare generat de Ex.Message ce explica motivul acesteia
                    /// <summary>
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///in aceasta metoda atunci cand se va apasa pe butonul de reset valorile campurilor vor deveni goale
            /// <summary>
            MovieIdTb.Text = "";
            MovieNameTb.Text = "";
            GenreCb.Text = "";
            TimeOfShowingCb.Text = "";
            SeatsTb.Text = "";
        }


        private void buttonViewMovies_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///in aceasta metoda ni se permite prin apasarea butonului View Movies
            ///sa avem acces la formul ViewMovies si sa vedem informatiile despre filmele din baza de date
            /// <summary>
            ViewMovies viewmovie = new ViewMovies();
            viewmovie.Show();
            this.Hide();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///in aceasta metoda ni se permite prin apasarea butonului Back sa revenim in Home Menu ( formul HomeAdmin )
            /// <summary>
            HomeAdmin home = new HomeAdmin();
            home.Show();
            this.Hide();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///afisarea extensiei help la apasarea butonului cu acelasi nume
            /// <summary>
            Help.ShowHelp(this, "C:/Users/User/Desktop/2022/An3/SemII/IP/Proiect/Rezervare online pentru bilete la cinema/Beta version/CinemaBookingSystem/Help-Rezervare online pentru biletele la cinema.chm");

        }
    }
}
