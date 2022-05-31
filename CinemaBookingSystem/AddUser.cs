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

        // realizam o noua conexiune la baza de date sql creata CinemaDb
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\CinemaDb.mdf;Integrated Security=True;Connect Timeout=30"); 

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite prin apasare butonului record
            //sa adaugam un nou user in baza de date si informatii legate despre acesta
            if( UserIdTb.Text == "" || UserNameTb.Text == "" || UserEmailTb.Text == "" || UserAddressTb.Text == "" || UserPhoneTb.Text == ""  )
            {
                MessageBox.Show("Missing information!Please complete the fields.");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "insert into UserTbl values("+UserIdTb.Text+",'"+UserNameTb.Text+"','"+UserEmailTb.Text+"','"+UserAddressTb.Text+"','"+UserPhoneTb.Text+"')";
                    SqlCommand cmd = new SqlCommand(query,Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Recorded Successfully");
                    Connection.Close();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite prin apasarea butonului View Users
            //sa avem acses la formul ViewUsers unde putem vedea informatii ale useri-lor din baza de date
            ViewUsers viewuser = new ViewUsers();
            viewuser.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de reset
            //valorile campurilor vor deveni goale
            UserIdTb.Text = "";
            UserNameTb.Text = "";
            UserEmailTb.Text = "";
            UserAddressTb.Text = "";
            UserPhoneTb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
