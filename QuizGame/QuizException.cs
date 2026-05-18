/**************************************************************************
 *                                                                        *
 *  File:        QuizException.cs                                               *
 *  Copyright:   (c) 2026, Maria-Ecaterina Condurache                     *
 *  E-mail:      maria-ecaterina.condurache@student.tuiasi.ro             *
 *  Website:     https://github.com/P-Teo/IP-Proiect-QuizGame             *
 *  Description: Exceptie personalizata pentru erorile specifice          *
 *               aplicatiei de quiz. Semnaleaza situatii invalide         *
 *               in timpul desfasurarii jocului.                          *
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
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    /// <summary>
    /// Exceptie personalizata pentru erorile specifice aplicatiei de quiz.
    /// Folosita pentru a semnala situatii invalide in timpul desfasurarii jocului,
    /// cum ar fi lipsa unui raspuns selectat. 
    /// </summary>
    public class QuizException : Exception
    {
        /// <summary>
        /// Constructorul exceptiei de quiz.
        /// Transmite mesajul de eroare catre clasa de baza Exception.
        /// </summary>
        /// <param name="message">Mesajul descriptiv al erorii aparute</param>
        public QuizException(string message) : base(message) { }
    }
}
