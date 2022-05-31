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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            AddMovie movie = new AddMovie();
            movie.Show();
            this.Hide();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            AddUser user = new AddUser();
            user.Show();
            this.Hide();
        }

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Show();
            this.Hide();
        }

        private void buttonCancellation_Click(object sender, EventArgs e)
        {
            Cancellation cancel = new Cancellation();
            cancel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewMovies vm = new ViewMovies();
            vm.Show();
            this.Hide();
        }

        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            ViewUsers vu = new ViewUsers();
            vu.Show();
            this.Hide();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            //afisarea extensiei help la apasarea butonului cu acelasi nume
            //MessageBox.Show("Help");
            Help.ShowHelp(this, "C:/Users/User/Desktop/2022/An3/SemII/IP/Proiect/Rezervare online pentru bilete la cinema/Beta version/CinemaBookingSystem/Help-Rezervare online pentru biletele la cinema.chm");

        }
    }
}
