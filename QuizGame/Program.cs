/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  Copyright:   (c) 2026,                                                *
 *               Roxana-Ionela Barbaliu,                                  *
 *               Cosmina-Alexandra Ciobanu,                               *
 *               Maria-Ecaterina Condurache,                              *
 *               Teodora Papă                                             *
 *  E-mail:      roxana-ionela.barbaliu@student.tuiasi.ro                 *
 *               cosmina-alexandra.ciobanu@student.tuiasi.ro              *
 *               maria-ecaterina.condurache@student.tuiasi.ro             *
 *               teodora.papa@student.tuiasi.ro                           *
 *  Website:     https://github.com/P-Teo/IP-Proiect-QuizGame             *
 *  Description: Punctul de intrare in aplicatia QuizGame.                *
 *               Configureaza stilurile vizuale si lanseaza               *
 *               bucla principala a interfetei grafice.                   *
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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    /// <summary>
    /// Clasa de intrare in aplicatie.
    /// Porneste aplicatia Windows Forms incepand cu formularul principal (HomeForm).
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Configureaza stilurile vizuale si lanseaza bucla principala a interfetei grafice.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}
