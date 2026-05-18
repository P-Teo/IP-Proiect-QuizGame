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
