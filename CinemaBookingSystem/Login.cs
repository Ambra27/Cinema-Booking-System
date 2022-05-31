using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( UIdTb.Text == "" || PasswordTb.Text == ""  )
            {
                MessageBox.Show("Enter The User Id and Password");
            }else if(UIdTb.Text == "admin" && PasswordTb.Text == "admin" )
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UIdTb.Text = "";
            PasswordTb.Text = "";

        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            //afisarea extensiei help la apasarea butonului cu acelasi nume
            //MessageBox.Show("Help");
            Help.ShowHelp(this, "C:/Users/User/Desktop/2022/An3/SemII/IP/Proiect/Rezervare online pentru bilete la cinema/Beta version/CinemaBookingSystem/Help-Rezervare online pentru biletele la cinema.chm");

        }
    }

}
