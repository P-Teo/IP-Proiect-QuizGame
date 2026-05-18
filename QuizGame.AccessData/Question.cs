/**************************************************************************
 *                                                                        *
 *  File:        Question.cs                                              *
 *  Copyright:   (c) 2026, Roxana-Ionela Barbaliu, Teodora Papă           *
 *  E-mail:      roxana-ionela.barbaliu@student.tuiasi.ro                 * 
 *               teodora.papa@student.tuiasi.ro                           *
 *  Website:     https://github.com/P-Teo/IP-Proiect-QuizGame             *
 *  Description: Modelul de date pentru o intrebare din quiz.             *
 *               Stocheaza textul intrebarii, cele 4 variante de          *
 *               raspuns, varianta corecta si dificultatea.               *
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

namespace QuizGame.AccessData
{
    //// <summary>
    /// Modelul de date pentru o intrebare din quiz.
    /// Stocheaza textul intrebarii, cele 4 variante de raspuns, varianta corecta si dificultatea.
    /// </summary>
    public class Question
    {
        // Identificatorul unic al intrebarii in baza de date
        public int Id { get; set; }

        // Textul complet al intrebarii afisate utilizatorului
        public string QuestionText { get; set; }

        // Cele patru variante de raspuns posibile
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }

        // Varianta corecta, folosita pentru verificarea raspunsului utilizatorului
        public string CorrectOption { get; set; }

        // Nivelul de dificultate, folosit de strategii pentru filtrarea intrebarilor
        public string DifficultyLevel { get; set; }

    }
}
