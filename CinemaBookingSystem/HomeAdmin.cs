/************************************************************************************************
 *                                                                                              *
 *  File:        HomeAdmin.cs                                                                   *
 *  Copyright:   (c) 2021-2022 Furcoi Tase - Isidor, Marmureanu Elena - Adeline                 *
 *               Petrescu Ambra - Costina, Pintilie Vasile - Emilian                            *
 *  E-mail:      tase-isidor.furcoi@student.tuiasi.ro                                           *
 *               elena-adeline.marmureanu@student.tuiasi.ro                                     *
 *               ambra-costina.petrescu@student.tuiasi.ro                                       *
 *               vasile-emilian.pintilie@student.tuiasi.ro                                      *
 *  Description: Implementing the HomeAdmin.cs interface                                        *
 *               Where we can navigate between different forms.                                 *
 *               Home Admin (Software Engineering Project IP)                                   *
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

namespace CinemaBookingSystem
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca X-ul din dreapta de sus a interfetei sa poata
            //iesi din program prin efectuarea unui click asupra acestuia
            Application.Exit();
        }

        private void buttonAddMovies_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca butonul Add Movies a interfetei sa poata
            //accesa formul AddMovie prin efectuarea unui click asupra acestuia

            AddMovie movie = new AddMovie();
            movie.Show();
            this.Hide();
        }

        private void buttonAddUsers_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca butonul Add Users a interfetei sa poata
            //accesa formul AddUser prin efectuarea unui click asupra acestuia

            AddUser user = new AddUser();
            user.Show();
            this.Hide();
        }

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca butonul Tickets a interfetei sa poata
            //accesa formul Tiket prin efectuarea unui click asupra acestuia

            Ticket ticket = new Ticket();
            ticket.Show();
            this.Hide();
        }

        private void buttonCancellation_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca butonul Cancellation a interfetei sa poata
            //accesa formul Cancellation prin efectuarea unui click asupra acestuia

            Cancellation cancel = new Cancellation();
            cancel.Show();
            this.Hide();
        }

        private void buttonViewMovies_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca butonul View Movies a interfetei sa poata
            //accesa formul ViewMovies prin efectuarea unui click asupra acestuia

            ViewMovies vm = new ViewMovies();
            vm.Show();
            this.Hide();

        }

        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            //prin aceasta metoda implementam ca butonul View Users a interfetei sa poata
            //accesa formul ViewUsers prin efectuarea unui click asupra acestuia

            ViewUsers vu = new ViewUsers();
            vu.Show();
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
