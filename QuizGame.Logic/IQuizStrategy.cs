/**************************************************************************
 *                                                                        *
 *  File:        IQuizStrategy.cs                                         *
 *  Copyright:   (c) 2026, Maria-Ecaterina Condurache                     *
 *  E-mail:      maria-ecaterina.condurache@student.tuiasi.ro             *
 *  Website:     https://github.com/P-Teo/IP-Proiect-QuizGame             *
 *  Description: Interfata care defineste contractul pentru strategiile   *
 *               de dificultate ale quiz-ului. Fiecare strategie          *
 *               implementeaza calculul scorului si filtrarea             *
 *               intrebarilor.                                            *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/


using QuizGame.AccessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Logic.Strategies
{
    /// <summary>
    /// Interfata care defineste contractul pentru strategiile de dificultate ale quiz-ului.
    /// Fiecare strategie trebuie sa implementeze calculul scorului si filtrarea intrebarilor.
    /// </summary>
    public interface IQuizStrategy
    {
        /// <summary>
        /// Calculeaza noul scor dupa un raspuns corect, in functie de dificultatea strategiei.
        /// </summary>
        /// <param name="currentScore">Scorul curent al utilizatorului</param>
        /// <returns>Scorul actualizat conform regulilor strategiei</returns>
        int CalculateScore(int currentScore);

        /// <summary>
        /// Filtreaza lista completa de intrebari, returnand doar cele specifice dificultatii strategiei.
        /// </summary>
        /// <param name="questions">Lista completa de intrebari din baza de date</param>
        /// <returns>Lista de intrebari corespunzatoare dificultatii strategiei curente</returns>
        List<Question> FilterQuestions(List<Question> questions);
    }
}