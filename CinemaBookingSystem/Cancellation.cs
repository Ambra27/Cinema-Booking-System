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
            //prin aceasta metoda se popoleaza data grid view-ul cu datele 
            //din tabela de interes ,modificate sau nu

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
            Application.Exit();
        }

        private void TicketIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fecthMovieName();
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de reset
            //valorile campurilor vor deveni goale
            CancelIdTb.Text = "";
            TicketIdCb.Text = "";
            MovieNameTb.Text = "";
            UserNameTb.Text = "";
            
        }

        private void deleteTicket()
        {
            //cu aceasta metoda vom putea anula rezervarea de bilete 
            //o data ce rezervarea este anulata , datele rezervarii biletului vor fi sterse din TicketTbl
            //si inserate in CancelTbl
            try
            {
                Connection.Open();
                string query = "delete from TicketTbl where TicketId=" + TicketIdCb.SelectedValue.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking Deleted Successfully");
                Connection.Close();
                Populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de cancel
            //se va adauga o anularea in tabela canceltbl a unei rezervari de bilete
            if (CancelIdTb.Text == "" || UserNameTb.Text == "")
            {
                MessageBox.Show("Missing information!Please complete the fields in order to cancel the booking.");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "insert into CancelTbl values(" + CancelIdTb.Text + ",'" + TicketIdCb.SelectedValue.ToString() + "','" + MovieNameTb.Text + "','" + UserNameTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Cancelled Successfully");
                    Connection.Close();
                    Populate();
                    deleteTicket();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void Cancellation_Load(object sender, EventArgs e)
        {
            fillTicketId();
            Populate();
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
