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
            if (strategy == null) throw new ArgumentNullException(nameof(strategy));
            _strategy = strategy;
        }

        public QuizManager(IQuizStrategy strategy, List<Question> questions)
        {
            if (strategy == null) throw new ArgumentNullException(nameof(strategy));
            if (questions == null) throw new ArgumentNullException(nameof(questions));
            _strategy = strategy;
            _question = strategy.FilterQuestions(questions);
            _score = 0;
            _currentQuestionIndex = 0;
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

                _dbInit.InsertQuestion(new Question { QuestionText = "Care planetă este cunoscută drept Planeta Roșie?", OptionA = "Venus", OptionB = "Marte", OptionC = "Jupiter", OptionD = "Saturn", CorrectOption = "Marte", DifficultyLevel = "Usor" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este rezultatul lui 5 + 7?", OptionA = "10", OptionB = "11", OptionC = "12", OptionD = "13", CorrectOption = "12", DifficultyLevel = "Usor" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Ce animal este cunoscut drept regele junglei?", OptionA = "Tigru", OptionB = "Elefant", OptionC = "Leu", OptionD = "Panteră", CorrectOption = "Leu", DifficultyLevel = "Usor" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este limba oficială în Brazilia?", OptionA = "Spaniolă", OptionB = "Portugheză", OptionC = "Franceză", OptionD = "Engleză", CorrectOption = "Portugheză", DifficultyLevel = "Usor" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Câte zile are o săptămână?", OptionA = "5", OptionB = "6", OptionC = "7", OptionD = "8", CorrectOption = "7", DifficultyLevel = "Usor" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Ce gaz respiră oamenii pentru a supraviețui?", OptionA = "Hidrogen", OptionB = "Azot", OptionC = "Oxigen", OptionD = "Heliu", CorrectOption = "Oxigen", DifficultyLevel = "Usor" });


                // ===== MEDIU =====
                _dbInit.InsertQuestion(new Question { QuestionText = "Cine a pictat Mona Lisa?", OptionA = "Michelangelo", OptionB = "Rafael", OptionC = "Leonardo da Vinci", OptionD = "Botticelli", CorrectOption = "Leonardo da Vinci", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este elementul chimic cu simbolul Au?", OptionA = "Argint", OptionB = "Aluminiu", OptionC = "Aur", OptionD = "Arsenic", CorrectOption = "Aur", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este cel mai lung râu din lume?", OptionA = "Amazon", OptionB = "Nil", OptionC = "Yangtze", OptionD = "Mississippi", CorrectOption = "Nil", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Cine a scris Romeo și Julieta?", OptionA = "Charles Dickens", OptionB = "William Shakespeare", OptionC = "Victor Hugo", OptionD = "Jane Austen", CorrectOption = "William Shakespeare", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "În ce an a început Al Doilea Război Mondial?", OptionA = "1914", OptionB = "1939", OptionC = "1945", OptionD = "1963", CorrectOption = "1939", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este capitala Canadei?", OptionA = "Toronto", OptionB = "Vancouver", OptionC = "Ottawa", OptionD = "Montreal", CorrectOption = "Ottawa", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Ce planetă are cele mai multe luni cunoscute?", OptionA = "Marte", OptionB = "Jupiter", OptionC = "Saturn", OptionD = "Neptun", CorrectOption = "Saturn", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Cine a descoperit penicilina?", OptionA = "Isaac Newton", OptionB = "Albert Einstein", OptionC = "Alexander Fleming", OptionD = "Louis Pasteur", CorrectOption = "Alexander Fleming", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Ce țară are forma unei cizme?", OptionA = "Spania", OptionB = "Italia", OptionC = "Grecia", OptionD = "Portugalia", CorrectOption = "Italia", DifficultyLevel = "Mediu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este cel mai mare mamifer din lume?", OptionA = "Elefantul african", OptionB = "Balena albastră", OptionC = "Rechinul balenă", OptionD = "Girafa", CorrectOption = "Balena albastră", DifficultyLevel = "Mediu" });


                // ===== GREU =====
                _dbInit.InsertQuestion(new Question { QuestionText = "Care este cel mai dens element din tabelul periodic?", OptionA = "Plumb", OptionB = "Uraniu", OptionC = "Osmiu", OptionD = "Iridiu", CorrectOption = "Osmiu", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este cel mai mic os din corpul uman?", OptionA = "Ciocanul", OptionB = "Nicovala", OptionC = "Scărița", OptionD = "Rotula", CorrectOption = "Scărița", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este viteza luminii în vid (aproximativ)?", OptionA = "200.000 km/s", OptionB = "250.000 km/s", OptionC = "300.000 km/s", OptionD = "350.000 km/s", CorrectOption = "300.000 km/s", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Câte elemente conține tabelul periodic actual?", OptionA = "108", OptionB = "112", OptionC = "118", OptionD = "124", CorrectOption = "118", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Cine a formulat teoria relativității generale?", OptionA = "Newton", OptionB = "Tesla", OptionC = "Einstein", OptionD = "Bohr", CorrectOption = "Einstein", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este capitala Mongoliei?", OptionA = "Astana", OptionB = "Ulaanbaatar", OptionC = "Tashkent", OptionD = "Bishkek", CorrectOption = "Ulaanbaatar", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Ce matematician a dezvoltat logaritmii?", OptionA = "Pascal", OptionB = "Napier", OptionC = "Euler", OptionD = "Gauss", CorrectOption = "Napier", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Care este cea mai adâncă fosă oceanică?", OptionA = "Fosa Java", OptionB = "Fosa Marianelor", OptionC = "Fosa Tonga", OptionD = "Fosa Puerto Rico", CorrectOption = "Fosa Marianelor", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "În ce an a căzut Imperiul Roman de Apus?", OptionA = "476", OptionB = "410", OptionC = "1453", OptionD = "800", CorrectOption = "476", DifficultyLevel = "Greu" });

                _dbInit.InsertQuestion(new Question { QuestionText = "Ce particulă are sarcină electrică negativă?", OptionA = "Proton", OptionB = "Neutron", OptionC = "Electron", OptionD = "Pozitron", CorrectOption = "Electron", DifficultyLevel = "Greu" });

                _question = _dbInit.GetAllQuestions();
            }
            _score = 0;
            _currentQuestionIndex = 0;
        }

        public bool CheckAnswer(string selectedOption, string correctOption)
        {
            if (selectedOption == null) throw new ArgumentNullException(nameof(selectedOption));
            if (correctOption == null) throw new ArgumentNullException(nameof(correctOption));

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
