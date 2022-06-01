/************************************************************************************************
 *                                                                                              *
 *  File:        AddUser.cs                                                                     *
 *  Copyright:   (c) 2021-2022 Furcoi Tase - Isidor, Marmureanu Elena - Adeline                 *
 *               Petrescu Ambra - Costina, Pintilie Vasile - Emilian                            *
 *  E-mail:      tase-isidor.furcoi@student.tuiasi.ro                                           *
 *               elena-adeline.marmureanu@student.tuiasi.ro                                     *
 *               ambra-costina.petrescu@student.tuiasi.ro                                       *
 *               vasile-emilian.pintilie@student.tuiasi.ro                                      *
 *  Description: Implementing the AddUser.cs interface                                          *
 *               Where we can add a new user in the database.                                   *
 *               Add User (Software Engineering Project IP)                                     *
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
    public partial class AddUser : Form
    {
        public AddUser()
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
            ///in aceasta metoda ni se permite prin apasare butonului record
            ///sa adaugam un nou user si informatii despre acesta in baza de date
            /// <summary>

            /// <summary>
            ///in prim pas verificam daca avem campuri de informatii goale
            /// <summary>
            if ( UserIdTb.Text == "" || UserNameTb.Text == "" || UserEmailTb.Text == "" || UserAddressTb.Text == "" || UserPhoneTb.Text == ""  )
            {
                /// <summary>
                ///in cazul in care avem campuri de informatii goale/necompletat va aparea urmatorul mesaj ca avertizare catre utilizator
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
                    ///ce ne va permite sa inseram in tabela UserTbl date noi prin comanda ce o vom stoca in variabila cmd
                    ///ca mai apoi sa fie executata prin apelul functiei ExecuteNonQuery
                    /// <summary>
                    Connection.Open();
                    string query = "insert into UserTbl values("+UserIdTb.Text+",'"+UserNameTb.Text+"','"+UserEmailTb.Text+"','"+UserAddressTb.Text+"','"+UserPhoneTb.Text+"')";
                    SqlCommand cmd = new SqlCommand(query,Connection);
                    cmd.ExecuteNonQuery();

                    /// <summary>
                    ///dupa inserarea noilor date in tabel urmatorul mesaj va aparea intr-un MessageBox
                    ///ca mai apoi conexiunea cu baze de date sa fie inchisa prin apelarea functiei Close
                    /// <summary>
                    MessageBox.Show("User Recorded Successfully");
                    Connection.Close();
                }
                catch(Exception Ex)
                {
                    /// <summary>
                    ///in cazul in care va afea loc o exceptie va aparea un mesaj de eroare generat de Ex.Message ce explica motivul acesteia
                    /// <summary>
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///in aceasta metoda ni se permite accesul prin apasarea butonului View Users
            ///sa avem acses la formul ViewUsers unde putem vedea informatii ale useri-lor din baza de date
            /// <summary>
            ViewUsers viewuser = new ViewUsers();
            viewuser.Show();
            this.Hide();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///in aceasta metoda atunci cand se va apasa butonul de reset valorile campurilor vor deveni goale
            /// <summary>
            UserIdTb.Text = "";
            UserNameTb.Text = "";
            UserEmailTb.Text = "";
            UserAddressTb.Text = "";
            UserPhoneTb.Text = "";
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
