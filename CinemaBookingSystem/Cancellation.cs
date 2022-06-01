/************************************************************************************************
 *                                                                                              *
 *  File:        Cancellation.cs                                                                *
 *  Copyright:   (c) 2021-2022 Furcoi Tase - Isidor, Marmureanu Elena - Adeline                 *
 *               Petrescu Ambra - Costina, Pintilie Vasile - Emilian                            *
 *  E-mail:      tase-isidor.furcoi@student.tuiasi.ro                                           *
 *               elena-adeline.marmureanu@student.tuiasi.ro                                     *
 *               ambra-costina.petrescu@student.tuiasi.ro                                       *
 *               vasile-emilian.pintilie@student.tuiasi.ro                                      *
 *  Description: Implementing the Cancellation.cs interface                                     *
 *               Where we can delete a ticket booking in the database.                          *
 *               Cancellation (Software Engineering Project IP)                                 *
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
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
        }

        // realizam o noua conexiune la baza de date sql creata CinemaDb
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\CinemaDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void Populate()
        {
            //prin aceasta metoda se popoleaza data grid view-ul cu datele din tabela de interes CancelTbl, modificate sau nu

            Connection.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            CancelDGV.DataSource = dataset.Tables[0];
            Connection.Close();


        }

        private void fillTicketId()
        {
            //aceasta metoda permite umplerea automata a id-urilor biletelor din baza de date

            Connection.Open();
            SqlCommand cmd = new SqlCommand("select TicketId from TicketTbl", Connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TicketId,typeof(string)");
            dt.Load(reader);
            TicketIdCb.ValueMember = "TicketId";
            TicketIdCb.DataSource = dt;
            Connection.Close();


        }

       
        private void fecthMovieName()
        {
            //aceasta metoda permite umplerea automata a titlurilor de filme din baza de date ce coincid cu id-ul biletului rezervat

            Connection.Open();
            string query = "select * from TicketTbl where TicketId=" + TicketIdCb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                MovieNameTb.Text = dr["MovieName"].ToString();

            }
            Connection.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca X-ul din dreapta de sus a interfetei sa poata 
            //iesi din program prin efectuarea unui click asupra acestuia
            Application.Exit();
        }

        private void TicketIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //atunci cand are loc o schimbare/modificare a informatiei din campul id-ului biletului
            //se va apela functia fetchMovieName ce va returna titlul filmului care corespunde id-ului ticketului
            fecthMovieName();
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de reset valorile campurilor vor deveni goale
            CancelIdTb.Text = "";
            TicketIdCb.Text = "";
            MovieNameTb.Text = "";
            UserNameTb.Text = "";
            
        }

        private void deleteTicket()
        {
            //cu aceasta metoda vom putea anula rezervarea de bilete 
            //o data ce rezervarea este anulata , datele rezervarii biletului vor fi sterse din tabela TicketTbl 
            //si inserate in tabela CancelTbl din baza de date

            //error handling
            try
            {
                //la apelul acestei functii se va incerca a se crea o connexiune la baza de date
                //ce ne va permite sa inseram in tabela CancelTbl date noi prin comanda ce o vom stoca in variabila cmd
                //ca mai apoi sa fie executata prin apelul functiei ExecuteNonQuery
                Connection.Open();
                string query = "delete from TicketTbl where TicketId=" + TicketIdCb.SelectedValue.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.ExecuteNonQuery();

                //dupa inserarea noilor date in tabel urmatorul mesaj va aparea intr-un MessageBox
                //ca mai apoi conexiunea cu baze de date sa fie inchisa prin apelarea functiei Close
                MessageBox.Show("Booking Deleted Successfully");
                Connection.Close();
                Populate();
            }
            catch (Exception Ex)
            {
                //in cazul in care va afea loc o exceptie va aparea un mesaj de eroare generat de Ex.Message ce explica motivul acesteia
                MessageBox.Show(Ex.Message);
            }

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de cancel
            //se va adauga o anularea in tabela CancelTbl a unei rezervari de bilete 

            //in prim pas verificam daca avem campuri de informatii goale
            if (CancelIdTb.Text == "" || UserNameTb.Text == "")
            {
                //in cazul in care avem campuri de informatii goale/necompletat va aparea urmatorul mesaj ca avertizare catre utilizator
                MessageBox.Show("Missing information!Please complete the fields in order to cancel the booking.");
            }
            else
            {
                //error handling
                try
                {
                    //daca am completat informatiile corect in campurile interfetei se va crea o connexiune la baza de date
                    //ce ne va permite sa inseram in tabela CancelTbl date noi prin comanda ce o vom stoca in variabila cmd
                    //ca mai apoi sa fie executata prin apelul functiei ExecuteNonQuery
                    Connection.Open();
                    string query = "insert into CancelTbl values(" + CancelIdTb.Text + ",'" + TicketIdCb.SelectedValue.ToString() + "','" + MovieNameTb.Text + "','" + UserNameTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();


                    //dupa inserarea noilor date in tabel urmatorul mesaj va aparea intr-un MessageBox
                    //ca mai apoi conexiunea cu baze de date sa fie inchisa prin apelarea functiei Close
                    MessageBox.Show("Booking Cancelled Successfully");
                    Connection.Close();
                    Populate();
                    deleteTicket();
                }
                catch (Exception Ex)
                {
                    //in cazul in care va afea loc o exceptie va aparea un mesaj de eroare generat de Ex.Message ce explica motivul acesteia
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void Cancellation_Load(object sender, EventArgs e)
        {
            //la accesarea formului Cancellation functia fillTicketId va umple optiunile din combobox-ul 
            //al campului TicketId cu id-urile biletelor existente in baza de date iar apoi se va popula un tabel 
            //cu datele din tabela CanceTbl in datagridview-ul interfetei Cancellation.cs
            fillTicketId();
            Populate();
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
    }
}
