/************************************************************************************************
 *                                                                                              *
 *  File:        Intro.cs                                                                       *
 *  Copyright:   (c) 2021-2022 Furcoi Tase - Isidor, Marmureanu Elena - Adeline                 *
 *               Petrescu Ambra - Costina, Pintilie Vasile - Emilian                            *
 *  E-mail:      tase-isidor.furcoi@student.tuiasi.ro                                           *
 *               elena-adeline.marmureanu@student.tuiasi.ro                                     *
 *               ambra-costina.petrescu@student.tuiasi.ro                                       *
 *               vasile-emilian.pintilie@student.tuiasi.ro                                      *
 *  Description: Implementing the Intro.cs interface.                                           *
 *               Intro (Software Engineering Project IP)                                        *
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
    public partial class Intro : Form
    {
        public Intro()
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


        int startpoint = 0;
        private void timerProgress_Tick(object sender, EventArgs e)
        {
            /// <summary>
            ///prin aceasta metoda dorim sa programam ProgressBar-ul din interfata
            ///bara verde se va incarca treptat de la stanga la dreapta 
            ///pana ce valoarea startpoint preluata de Myprogress 
            ///va ajunge la valoarea 100
            ///din rulari repetate am observat timpul scurs pentru a se executa aceasta functie este undeva la ~10 secunde
            /// <summary>
            startpoint += 1;
            Myprogress.Value = startpoint;
            if(Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timerProgress.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
          
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            /// <summary>
            ///cand se acceseaza formul Intro este apelata functia timeProgress
            /// <summary>
            timerProgress.Start();
        }
    }
}
