/**************************************************************************
 *                                                                        *
 *  File:        EndForm.cs                                               *
 *  Copyright:   (c) 2026, Roxana-Ionela Barbaliu                         *
 *  E-mail:      roxana-ionela.barbaliu@student.tuiasi.ro                 *
 *  Website:     https://github.com/P-Teo/IP-Proiect-QuizGame             *
 *  Description: Formularul de final al quiz-ului.                        *
 *               Afiseaza scorul final obtinut de utilizator si           *
 *               ofera optiunea de iesire din aplicatie.                  *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    /// <summary>
    /// Formularul de final al quiz-ului.
    /// Afiseaza scorul final obtinut de utilizator si ofera optiunea de iesire din aplicatie.
    /// </summary>
    public partial class EndForm : Form
    {
        /// <summary>
        /// Constructorul formularului de final.
        /// Afiseaza scorul final obtinut de utilizator la terminarea quiz-ului.
        /// </summary>
        /// <param name="scorFinal">Scorul acumulat de utilizator pe parcursul quiz-ului</param>
        public EndForm(int scorFinal)
        {
            InitializeComponent();

            labelScor.Text = $"Felicitări! Ai terminat quiz-ul.\nScorul tău final este: {scorFinal}";

        }

        /// <summary>
        /// Gestioneaza apasarea butonului de iesire.
        /// Inchide intreaga aplicatie.
        /// </summary>
        /// <param name="sender">Sursa evenimentului</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        /// <summary>
        /// Suprascrie comportamentul implicit la inchiderea ferestrei.
        /// Asigura inchiderea completa a aplicatiei indiferent de modul in care este inchis formularul.
        /// </summary>
        /// <param name="e">Argumentele evenimentului de inchidere a ferestrei</param>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}
