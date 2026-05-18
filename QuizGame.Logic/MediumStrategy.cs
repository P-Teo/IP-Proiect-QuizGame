using QuizGame.AccessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Logic.Strategies
{
    /// <summary>
    /// Strategia pentru dificultatea Mediu.
    /// Filtreaza doar intrebarile de dificultate medie si acorda 2 puncte per raspuns corect.
    /// </summary>
    public class MediumStrategy : IQuizStrategy
    {
        /// <summary>
        /// Calculeaza noul scor dupa un raspuns corect la dificultatea Mediu.
        /// Acorda 2 puncte per raspuns corect.
        /// </summary>
        /// <param name="currentScore">Scorul curent al utilizatorului</param>
        /// <returns>Scorul actualizat cu 2 puncte in plus</returns>
        public int CalculateScore(int currentScore)
        {
            return currentScore + 2;
        }

        /// <summary>
        /// Filtreaza lista de intrebari, returnand doar cele de nivel Mediu.
        /// </summary>
        /// <param name="questions">Lista completa de intrebari din baza de date</param>
        /// <returns>Lista de intrebari filtrate cu DifficultyLevel egal cu "Mediu"</returns>
        public List<Question> FilterQuestions(List<Question> questions)
        {
            return questions
                .Where(q => q.DifficultyLevel == "Mediu")
                .ToList();
        }
    }
}
