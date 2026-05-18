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
