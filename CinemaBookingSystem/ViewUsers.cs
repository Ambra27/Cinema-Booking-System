using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;//utilizam baza de date sql

namespace CinemaBookingSystem
{
    public partial class ViewUsers : Form
    {
        public ViewUsers()
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
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            UserDGV.DataSource = dataset.Tables[0];
            Connection.Close();


        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //in aceasta metoda ni se permite prin apasarea butonului delete sa stergem informatiile unui 
            //user din tabel introducand id-ul userului in campul id
            if( IdTb.Text == "")
            {
                MessageBox.Show("Enter The User to Delete");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "delete from UserTbl where UserId=" + IdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query,Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Connection.Close();
                    Populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //in aceasta metoda dorim ca atunci cand selectam un cell de pe un anumit row
            //detaliile din tabel sa apara in campurile ce coincid cu acele informatii
            /*
            IdTb.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmailTb.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddressTb.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //in aceasta metoda atunci cand se va apasa butonul de reset
            //valorile campurilor vor deveni goale
            IdTb.Text = "";
            NameTb.Text = "";
            EmailTb.Text = "";
            AddressTb.Text = "";
            PhoneTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //in aceasta metoda ni se permite cand apasam butonul de update sa modificam datele
            //unui user existent
            if ( IdTb.Text == "" || NameTb.Text == "" || EmailTb.Text == "" || AddressTb.Text == "" || PhoneTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string query = "update UserTbl set UserName='"+NameTb.Text+"',UserEmail='"+EmailTb.Text+"',UserAddress='"+AddressTb.Text+"',UserPhone='"+PhoneTb.Text+"' where UserId=" +IdTb.Text+";";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
                    Connection.Close();
                    Populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }
    }
}
