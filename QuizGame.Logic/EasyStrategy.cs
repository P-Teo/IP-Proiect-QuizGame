using QuizGame.AccessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Logic.Strategies
{
    //// <summary>
    /// Strategia pentru dificultatea Usor.
    /// Filtreaza doar intrebarile usoare si acorda 1 punct per raspuns corect.
    /// </summary>
    public class EasyStrategy : IQuizStrategy
    {
        /// <summary>
        /// Calculeaza noul scor dupa un raspuns corect la dificultatea Usor.
        /// Acorda 1 punct per raspuns corect.
        /// </summary>
        /// <param name="currentScore">Scorul curent al utilizatorului</param>
        /// <returns>Scorul actualizat cu 1 punct in plus</returns>
        public int CalculateScore(int currentScore)
        {
            return currentScore + 1;
        }

        /// <summary>
        /// Filtreaza lista de intrebari, returnand doar cele de nivel Usor.
        /// </summary>
        /// <param name="questions">Lista completa de intrebari din baza de date</param>
        /// <returns>Lista de intrebari filtrate cu DifficultyLevel egal cu "Usor"</returns>
        public List<Question> FilterQuestions(List<Question> questions)
        {
            return questions
                .Where(q => q.DifficultyLevel == "Usor")
                .ToList();
        }
    }
}