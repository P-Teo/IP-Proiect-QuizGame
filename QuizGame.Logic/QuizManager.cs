using QuizGame.AccessData;
using QuizGame.Logic.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Logic
{
    public class QuizManager
    {
        private IQuizStrategy _strategy;
        private int _score;
        private int _currentQuestionIndex;
        private List<Question> _question;
        private DataBaseInitializer _dbInit = new DataBaseInitializer();

        public int Score => _score;
        public QuizManager(IQuizStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetupGame()
        {
            //Interfata cere logicii initializarea, logica cere AccessData
            _dbInit.InitializeDatabase();
            //extragem intrebarile
            _question = _strategy.FilterQuestions(_dbInit.GetAllQuestions());

            //daca lista este goala, adaugam intrebarile
            if (_question.Count == 0)
            {
                // ===== UȘOR =====
                _dbInit.InsertQuestion(new Question { QuestionText = "Care este cel mai mare ocean din lume?", OptionA = "Oceanul Atlantic", OptionB = "Oceanul Indian", OptionC = "Oceanul Pacific", OptionD = "Oceanul Arctic", CorrectOption = "Oceanul Pacific", DifficultyLevel = "Usor" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Câte culori are curcubeul?", OptionA = "5", OptionB = "6", OptionC = "7", OptionD = "8", CorrectOption = "7", DifficultyLevel = "Usor" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este capitala Franței?", OptionA = "Roma", OptionB = "Madrid", OptionC = "Berlin", OptionD = "Paris", CorrectOption = "Paris", DifficultyLevel = "Usor" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Câte continente are Pământul?", OptionA = "5", OptionB = "6", OptionC = "7", OptionD = "8", CorrectOption = "7", DifficultyLevel = "Usor" });

                // ===== MEDIU =====
                _dbInit.InsertQuestion(new Question { QuestionText = "Cine a pictat Mona Lisa?", OptionA = "Michelangelo", OptionB = "Rafael", OptionC = "Leonardo da Vinci", OptionD = "Botticelli", CorrectOption = "Leonardo da Vinci", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este elementul chimic cu simbolul Au?", OptionA = "Argint", OptionB = "Aluminiu", OptionC = "Aur", OptionD = "Arsenic", CorrectOption = "Aur", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este cel mai lung râu din lume?", OptionA = "Amazon", OptionB = "Nil", OptionC = "Yangtze", OptionD = "Mississippi", CorrectOption = "Nil", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Cine a scris Romeo și Julieta?", OptionA = "Charles Dickens", OptionB = "William Shakespeare", OptionC = "Victor Hugo", OptionD = "Jane Austen", CorrectOption = "William Shakespeare", DifficultyLevel = "Mediu" });

                // ===== GREU =====
                _dbInit.InsertQuestion(new Question { QuestionText = "Care este cel mai dens element din tabelul periodic?", OptionA = "Plumb", OptionB = "Uraniu", OptionC = "Osmiu", OptionD = "Iridiu", CorrectOption = "Osmiu", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este cel mai mic os din corpul uman?", OptionA = "Ciocanul", OptionB = "Nicovala", OptionC = "Scărița", OptionD = "Rotula", CorrectOption = "Scărița", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este viteza luminii în vid (aproximativ)?", OptionA = "200.000 km/s", OptionB = "250.000 km/s", OptionC = "300.000 km/s", OptionD = "350.000 km/s", CorrectOption = "300.000 km/s", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Câte elemente conține tabelul periodic actual?", OptionA = "108", OptionB = "112", OptionC = "118", OptionD = "124", CorrectOption = "118", DifficultyLevel = "Greu" });
                _question = _dbInit.GetAllQuestions();
            }
            _score = 0;
            _currentQuestionIndex = 0;
        }
        public bool CheckAnswer(string selectedOption, string correctOption)
        {
            if (selectedOption == correctOption)
            {
                _score = _strategy.CalculateScore(_score);
                return true;
            }

            return false;
        }

        public Question GetCurrentQuestion()
        {
            if (_question != null && _currentQuestionIndex < _question.Count)
            {
                return _question[_currentQuestionIndex];
            }
            return null; // Nu mai sunt întrebari
        }

        public void NextQuestion()
        {
            _currentQuestionIndex++;
        }
    }
}
