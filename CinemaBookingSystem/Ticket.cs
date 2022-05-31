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
            //prin aceasta metoda se popoleaza data grid view-ul cu datele 
            //din tabela de interes ,modificate sau nu

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
            Application.Exit();

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            fillUserId();
            fillMovieName();
            Populate();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de reset
            //valorile campurilor vor deveni goale
            TicketIdTb.Text = "";
            MovieNameCb.Text = "";
            UserIdCb.Text = "";
            UserNameTb.Text = "";
            UserPhoneTb.Text = "";
            AmontTb.Text = "";
        }


        private void buttonBook_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite cand apasam butonul de book sa facem o rezervare de bilete
            if (TicketIdTb.Text == "" || AmontTb.Text == "" )
            {
                MessageBox.Show("Missing information!Please complete the fields in order to book the tickets.");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "insert into TicketTbl values(" + TicketIdTb.Text + ",'" + MovieNameCb.SelectedValue.ToString() + "','" + UserIdCb.SelectedValue.ToString() + "','" + UserNameTb.Text + "','" + UserPhoneTb.Text + "','" + AmontTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    
                    Connection.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }


        string UserName, UserPhone;
        private void fecthUserInfo()
        {
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

        private void UserIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fecthUserInfo();
        }
    }
}
