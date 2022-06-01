/************************************************************************************************
 *                                                                                              *
 *  File:        Login.cs                                                                       *
 *  Copyright:   (c) 2021-2022 Furcoi Tase - Isidor, Marmureanu Elena - Adeline                 *
 *               Petrescu Ambra - Costina, Pintilie Vasile - Emilian                            *
 *  E-mail:      tase-isidor.furcoi@student.tuiasi.ro                                           *
 *               elena-adeline.marmureanu@student.tuiasi.ro                                     *
 *               ambra-costina.petrescu@student.tuiasi.ro                                       *
 *               vasile-emilian.pintilie@student.tuiasi.ro                                      *
 *  Description: Implementing the Login.cs interface.                                           *
 *               Log into the admin or user.                                                    *
 *               Login (Software Engineering Project IP)                                        *
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///prin aceasta metoda implementam ca X-ul din dreapta de sus a interfetei sa poata 
            ///iesi din program prin efectuarea unui click asupra acestuia
            /// <summary>
            Application.Exit();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {

            /// <summary>
            ///in aceasta metoda ni se permite prin apasare butonului Login
            ///sa accesam Home Menu(formul HomeAdmin.cs) cu user-ul si parola de admin
            /// <summary>

            /// <summary>
            ///in prim pas verificam daca avem campuri de informatii goale
            /// <summary>
            if ( textBoxUid.Text == "" || textBoxPassword.Text == ""  )
            {
                /// <summary>
                ///in cazul in care avem campuri de informatii goale/necompletat va aparea urmatorul mesaj ca avertizare catre utilizator
                /// <summary>
                MessageBox.Show("Enter The User Id and Password");
            }else if(textBoxUid.Text == "admin" && textBoxPassword.Text == "admin" )
            {
                /// <summary>
                ///in cazul in care datele introduse in campuri sunt ambele admin se va permite accesul la Home Menu(formul HomeAdmin.cs) 
                /// <summary>
                HomeAdmin home = new HomeAdmin();
                home.Show();
                this.Hide();
            }
            else
            {
                /// <summary>
                ///in cazul in care va afea loc o exceptie va aparea un mesaj de eroare generat de Ex.Message ce explica motivul acesteia
                /// <summary>
                MessageBox.Show("Wrong User Name or Password!");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///in aceasta metoda atunci cand se va apasa butonul de reset valorile campurilor vor deveni goale
            /// <summary>
            textBoxUid.Text = "";
            textBoxPassword.Text = "";

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///afisarea extensiei help la apasarea butonului cu acelasi nume
            /// <summary>
            Help.ShowHelp(this, "C:/Users/User/Desktop/2022/An3/SemII/IP/Proiect/Rezervare online pentru bilete la cinema/Beta version/CinemaBookingSystem/Help-Rezervare online pentru biletele la cinema.chm");

        }

    }

}
