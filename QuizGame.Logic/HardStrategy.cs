/**************************************************************************
 *                                                                        *
 *  File:        HardStrategy.cs                                          *
 *  Copyright:   (c) 2026, Maria-Ecaterina Condurache                     *
 *  E-mail:      maria-ecaterina.condurache@student.tuiasi.ro             *
 *  Website:     https://github.com/P-Teo/IP-Proiect-QuizGame             *
 *  Description: Strategia pentru dificultatea Greu.                      *
 *               Filtreaza intrebarile grele si acorda 3 puncte           *
 *               per raspuns corect.                                      *
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
    /// Strategia pentru dificultatea Greu.
    /// Filtreaza doar intrebarile grele si acorda 3 puncte per raspuns corect.
    /// </summary>
    public class HardStrategy : IQuizStrategy
    {
        /// <summary>
        /// Calculeaza noul scor dupa un raspuns corect la dificultatea Greu.
        /// Acorda 3 puncte per raspuns corect.
        /// </summary>
        /// <param name="currentScore">Scorul curent al utilizatorului</param>
        /// <returns>Scorul actualizat cu 3 puncte in plus</returns>
        public int CalculateScore(int currentScore)
        {
            return currentScore + 3;
        }

        /// <summary>
        /// Filtreaza lista de intrebari, returnand doar cele de nivel Greu.
        /// </summary>
        /// <param name="questions">Lista completa de intrebari din baza de date</param>
        /// <returns>Lista de intrebari filtrate cu DifficultyLevel egal cu "Greu"</returns>
        public List<Question> FilterQuestions(List<Question> questions)
        {
            return questions
                .Where(q => q.DifficultyLevel == "Greu")
                .ToList();
        }
    }
}