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