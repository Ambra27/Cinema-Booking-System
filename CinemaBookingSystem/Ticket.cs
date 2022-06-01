/************************************************************************************************
 *                                                                                              *
 *  File:        Ticket.cs                                                                      *
 *  Copyright:   (c) 2021-2022 Furcoi Tase - Isidor, Marmureanu Elena - Adeline                 *
 *               Petrescu Ambra - Costina, Pintilie Vasile - Emilian                            *
 *  E-mail:      tase-isidor.furcoi@student.tuiasi.ro                                           *
 *               elena-adeline.marmureanu@student.tuiasi.ro                                     *
 *               ambra-costina.petrescu@student.tuiasi.ro                                       *
 *               vasile-emilian.pintilie@student.tuiasi.ro                                      *
 *  Description: Implementing the Ticket.cs interface                                           *
 *               Where we can add a new ticket booking entry into the database.                 *
 *               Ticket (Software Engineering Project IP)                                       *
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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        // realizam o noua conexiune la baza de date sql creata CinemaDb
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\CinemaDb.mdf;Integrated Security=True;Connect Timeout=30");



        private void Populate()
        {
            //prin aceasta metoda se popoleaza data grid view-ul cu datele din tabela de interes TicketTbl,modificate sau nu

            Connection.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            TicketDGV.DataSource = dataset.Tables[0];
            Connection.Close();
        }

        private void fillUserId()
        {
            //aceasta metoda permite umplerea automata a id-urilor user-ilor din baza de date
            Connection.Open();
            SqlCommand cmd = new SqlCommand("select UserId from UserTbl",Connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UserId,typeof(int)");
            dt.Load(reader);
            UserIdCb.ValueMember = "UserId";
            UserIdCb.DataSource = dt;
            Connection.Close();

        }

        private void fillMovieName()
        {
            //aceasta metoda permite umplerea automata a titlurilor de filme din baza de date
            
            Connection.Open();
            SqlCommand cmd = new SqlCommand("select MovieName from MovieTbl", Connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MovieName");
            dt.Load(reader);
            MovieNameCb.ValueMember = "MovieName";
            MovieNameCb.DataSource = dt;
            Connection.Close();


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca X-ul din dreapta de sus a interfetei sa poata 
            //iesi din program prin efectuarea unui click asupra acestuia
            Application.Exit();

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            //la accesarea formului Ticket functia fillUserId va umple optiunile din combobox-ul 
            //al campului UserId cu id-urile userilor existenti in baza de date
            //(in mod asemanator se intampla si cu apelul functiei fillMovieName)
            //iar apoi se va popula un tabel cu datele din tabela CanceTbl in datagridview-ul interfetei Ticket.cs

            fillUserId();
            fillMovieName();
            Populate();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de reset valorile campurilor vor deveni goale
            TicketIdTb.Text = "";
            MovieNameCb.Text = "";
            UserIdCb.Text = "";
            UserNameTb.Text = "";
            UserPhoneTb.Text = "";
            AmontTb.Text = "";
        }


        private void buttonBook_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de Book se va adauga o rezervare in tabela TicketTbl 

            //in prim pas verificam daca avem campuri de informatii goale
            if (TicketIdTb.Text == "" || AmontTb.Text == "" )
            {
                //in cazul in care avem campuri de informatii goale/necompletat va aparea urmatorul mesaj ca avertizare catre utilizator
                MessageBox.Show("Missing information!Please complete the fields in order to book the tickets.");
            }
            else
            {
                //error handling
                try
                {
                    //daca am completat informatiile in campurile interfetei se va crea o connexiune la baza de date
                    //ce ne va permite sa inseram in tabela TicketTbl date noi prin comanda ce o vom stoca in variabila cmd
                    //ca mai apoi sa fie executata prin apelul functiei ExecuteNonQuery
                    Connection.Open();
                    string query = "insert into TicketTbl values(" + TicketIdTb.Text + ",'" + MovieNameCb.SelectedValue.ToString() + "','" + UserIdCb.SelectedValue.ToString() + "','" + UserNameTb.Text + "','" + UserPhoneTb.Text + "','" + AmontTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();

                    //dupa inserarea noilor date in tabel urmatorul mesaj va aparea intr-un MessageBox
                    //ca mai apoi conexiunea cu baze de date sa fie inchisa prin apelarea functiei Close
                    MessageBox.Show("Ticket Booked Successfully");
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


        string UserName, UserPhone;
        private void fecthUserInfo()
        {
            //prin aceasta metoda atunci cand se va completa campul UserId cu un anumi id
            //restul campurilor vor fi automat completate cu datele ce au acel UserId
            Connection.Open();
            string query = "select * from UserTbl where UserId=" + UserIdCb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            foreach(DataRow dr in dt.Rows )
            {
                UserName = dr["UserName"].ToString();
                UserPhone = dr["UserPhone"].ToString();
                UserNameTb.Text = UserName;
                UserPhoneTb.Text = UserPhone;
                 
            }
            Connection.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite prin apasarea butonului Back sa revenim in Home Menu ( formul HomeAdmin )
            HomeAdmin home = new HomeAdmin();
            home.Show();
            this.Hide();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            //afisarea extensiei help la apasarea butonului cu acelasi nume
            //MessageBox.Show("Help");
            Help.ShowHelp(this, "C:/Users/User/Desktop/2022/An3/SemII/IP/Proiect/Rezervare online pentru bilete la cinema/Beta version/CinemaBookingSystem/Help-Rezervare online pentru biletele la cinema.chm");

        }

        private void UserIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //la accesarea formului si completarea UserId-ului functia fecthUserInfo va aduce completari in restul campurilor
            fecthUserInfo();
        }
    }
}
