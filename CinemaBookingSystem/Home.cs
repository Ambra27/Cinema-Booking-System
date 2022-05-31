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
    }
}
