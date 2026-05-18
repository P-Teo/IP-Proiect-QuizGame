using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizGame.AccessData;
using QuizGame.Logic;
using QuizGame.Logic.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizGame.Tests
{
    /// <summary>
    /// Clasa de teste unitare pentru logica aplicatiei QuizGame.
    /// Acopera comportamentul metodelor CheckAnswer, GetCurrentQuestion, NextQuestion,
    /// al strategiilor de dificultate si al modelului Question.
    /// </summary>
    [TestClass]
    public class QuizGameTests
    {
        // ===== CheckAnswer - Comportament de baza =====

        /// <summary>
        /// Verifica ca un raspuns corect returneaza true.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_RaspunsCorect_ReturneazaTrue()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsTrue(manager.CheckAnswer("Paris", "Paris"));
        }

        /// <summary>
        /// Verifica ca un raspuns gresit returneaza false.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_RaspunsGresit_ReturneazaFalse()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsFalse(manager.CheckAnswer("Roma", "Paris"));
        }

        /// <summary>
        /// Verifica ca un string gol ca raspuns selectat returneaza false.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_StringGol_ReturneazaFalse()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsFalse(manager.CheckAnswer("", "Paris"));
        }

        /// <summary>
        /// Verifica ca doua stringuri goale sunt considerate egale si returneaza true.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_AmbeleGoale_ReturneazaTrue()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsTrue(manager.CheckAnswer("", ""));
        }

        /// <summary>
        /// Verifica ca verificarea raspunsului este case-sensitive.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_CaseSensitive_ReturneazaFalse()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsFalse(manager.CheckAnswer("paris", "Paris"));
        }

        /// <summary>
        /// Verifica ca un spatiu suplimentar face raspunsul sa fie considerat gresit.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_SpatiuExtra_ReturneazaFalse()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsFalse(manager.CheckAnswer("Paris ", "Paris"));
        }

        /// <summary>
        /// Verifica ca un numar reprezentat ca string este comparat corect.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_NumarCaString_Corect_ReturneazaTrue()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsTrue(manager.CheckAnswer("7", "7"));
        }

        // ===== CheckAnswer - Scor cu EasyStrategy (+1) =====

        /// <summary>
        /// Verifica ca un raspuns corect cu EasyStrategy creste scorul cu 1.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_Corect_EasyStrategy_ScorCreste1()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Paris", "Paris");
            Assert.AreEqual(1, manager.Score);
        }

        /// <summary>
        /// Verifica ca un raspuns gresit cu EasyStrategy nu modifica scorul.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_Gresit_EasyStrategy_ScorRamane0()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Roma", "Paris");
            Assert.AreEqual(0, manager.Score);
        }

        /// <summary>
        /// Verifica ca trei raspunsuri corecte cu EasyStrategy produc scorul 3.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_TreiCorecte_EasyStrategy_ScorEste3()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Paris", "Paris");
            manager.CheckAnswer("7", "7");
            manager.CheckAnswer("Oxigen", "Oxigen");
            Assert.AreEqual(3, manager.Score);
        }

        /// <summary>
        /// Verifica ca un raspuns corect si unul gresit cu EasyStrategy produc scorul 1.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_UnCorectUnGresit_EasyStrategy_ScorEste1()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Paris", "Paris");
            manager.CheckAnswer("Roma", "Paris");
            Assert.AreEqual(1, manager.Score);
        }

        // ===== CheckAnswer - Scor cu MediumStrategy (+2) =====

        /// <summary>
        /// Verifica ca un raspuns corect cu MediumStrategy creste scorul cu 2.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_Corect_MediumStrategy_ScorCreste2()
        {
            var manager = new QuizManager(new MediumStrategy());
            manager.CheckAnswer("Aur", "Aur");
            Assert.AreEqual(2, manager.Score);
        }

        /// <summary>
        /// Verifica ca trei raspunsuri corecte cu MediumStrategy produc scorul 6.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_TreiCorecte_MediumStrategy_ScorEste6()
        {
            var manager = new QuizManager(new MediumStrategy());
            manager.CheckAnswer("Aur", "Aur");
            manager.CheckAnswer("Ottawa", "Ottawa");
            manager.CheckAnswer("Italia", "Italia");
            Assert.AreEqual(6, manager.Score);
        }

        // ===== CheckAnswer - Scor cu HardStrategy (+3) =====

        /// <summary>
        /// Verifica ca un raspuns corect cu HardStrategy creste scorul cu 3.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_Corect_HardStrategy_ScorCreste3()
        {
            var manager = new QuizManager(new HardStrategy());
            manager.CheckAnswer("Osmiu", "Osmiu");
            Assert.AreEqual(3, manager.Score);
        }

        /// <summary>
        /// Verifica ca un raspuns gresit cu HardStrategy nu modifica scorul.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_Gresit_HardStrategy_ScorRamane0()
        {
            var manager = new QuizManager(new HardStrategy());
            manager.CheckAnswer("Plumb", "Osmiu");
            Assert.AreEqual(0, manager.Score);
        }

        /// <summary>
        /// Verifica ca doua raspunsuri corecte cu HardStrategy produc scorul 6.
        /// </summary>
        [TestMethod]
        public void CheckAnswer_DoiCorecti_HardStrategy_ScorEste6()
        {
            var manager = new QuizManager(new HardStrategy());
            manager.CheckAnswer("Osmiu", "Osmiu");
            manager.CheckAnswer("Electron", "Electron");
            Assert.AreEqual(6, manager.Score);
        }

        // ===== Score =====

        /// <summary>
        /// Verifica ca scorul initial al unui manager nou este 0.
        /// </summary>
        [TestMethod]
        public void Score_Initial_EsteZero()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.AreEqual(0, manager.Score);
        }

        /// <summary>
        /// Verifica ca scorul dupa initializarea cu lista de intrebari este 0.
        /// </summary>
        [TestMethod]
        public void Score_DupaSetupGame_EsteZero()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            Assert.AreEqual(0, manager.Score);
        }

        /// <summary>
        /// Verifica ca un manager nou are scorul resetat la 0, indiferent de sesiunea anterioara.
        /// </summary>
        [TestMethod]
        public void Score_DupaSetupGameDinNou_SeReseteaza()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            manager.CheckAnswer("Paris", "Paris");
            var manager2 = new QuizManager(new EasyStrategy(), SampleQuestions());
            Assert.AreEqual(0, manager2.Score);
        }

        // ===== GetCurrentQuestion =====

        /// <summary>
        /// Verifica ca prima intrebare nu este null dupa initializare cu lista de intrebari.
        /// </summary>
        [TestMethod]
        public void GetCurrentQuestion_DupaSetupGame_NuEsteNull()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            Assert.IsNotNull(manager.GetCurrentQuestion());
        }

        /// <summary>
        /// Verifica ca fara initializarea listei de intrebari, intrebarea curenta este null.
        /// </summary>
        [TestMethod]
        public void GetCurrentQuestion_FaraSetupGame_EsteNull()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsNull(manager.GetCurrentQuestion());
        }

        /// <summary>
        /// Verifica ca intrebarea curenta are toate cele 4 variante de raspuns completate.
        /// </summary>
        [TestMethod]
        public void GetCurrentQuestion_Are4VarianteNenule()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            var q = manager.GetCurrentQuestion();
            Assert.IsFalse(string.IsNullOrEmpty(q.OptionA));
            Assert.IsFalse(string.IsNullOrEmpty(q.OptionB));
            Assert.IsFalse(string.IsNullOrEmpty(q.OptionC));
            Assert.IsFalse(string.IsNullOrEmpty(q.OptionD));
        }

        /// <summary>
        /// Verifica ca raspunsul corect al intrebarii curente este una dintre cele 4 variante.
        /// </summary>
        [TestMethod]
        public void GetCurrentQuestion_RaspunsCorectEsteUnadinVariante()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            var q = manager.GetCurrentQuestion();
            bool eInVariante = q.CorrectOption == q.OptionA
                            || q.CorrectOption == q.OptionB
                            || q.CorrectOption == q.OptionC
                            || q.CorrectOption == q.OptionD;
            Assert.IsTrue(eInVariante);
        }

        /// <summary>
        /// Verifica ca EasyStrategy returneaza doar intrebari cu dificultatea Usor.
        /// </summary>
        [TestMethod]
        public void GetCurrentQuestion_EasyStrategy_ReturneazaDoarUsor()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            Assert.AreEqual("Usor", manager.GetCurrentQuestion().DifficultyLevel);
        }

        /// <summary>
        /// Verifica ca MediumStrategy returneaza doar intrebari cu dificultatea Mediu.
        /// </summary>
        [TestMethod]
        public void GetCurrentQuestion_MediumStrategy_ReturneazaDoarMediu()
        {
            var manager = new QuizManager(new MediumStrategy(), SampleQuestions());
            Assert.AreEqual("Mediu", manager.GetCurrentQuestion().DifficultyLevel);
        }

        /// <summary>
        /// Verifica ca HardStrategy returneaza doar intrebari cu dificultatea Greu.
        /// </summary>
        [TestMethod]
        public void GetCurrentQuestion_HardStrategy_ReturneazaDoarGreu()
        {
            var manager = new QuizManager(new HardStrategy(), SampleQuestions());
            Assert.AreEqual("Greu", manager.GetCurrentQuestion().DifficultyLevel);
        }

        // ===== NextQuestion =====

        /// <summary>
        /// Verifica ca NextQuestion schimba efectiv intrebarea curenta.
        /// </summary>
        [TestMethod]
        public void NextQuestion_SchimbaIntrebareaCurenta()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            var prima = manager.GetCurrentQuestion();
            manager.NextQuestion();
            var adoua = manager.GetCurrentQuestion();
            Assert.AreNotEqual(prima.Id, adoua.Id);
        }

        /// <summary>
        /// Verifica ca dupa parcurgerea tuturor intrebarilor, GetCurrentQuestion returneaza null.
        /// </summary>
        [TestMethod]
        public void NextQuestion_DupaToate_ReturneazaNull()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            while (manager.GetCurrentQuestion() != null)
                manager.NextQuestion();
            Assert.IsNull(manager.GetCurrentQuestion());
        }

        /// <summary>
        /// Verifica ca toate intrebarile parcurse cu EasyStrategy au dificultatea Usor.
        /// </summary>
        [TestMethod]
        public void NextQuestion_EasyStrategy_ToateIntrebarile_SuntUsor()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            while (manager.GetCurrentQuestion() != null)
            {
                Assert.AreEqual("Usor", manager.GetCurrentQuestion().DifficultyLevel);
                manager.NextQuestion();
            }
        }

        /// <summary>
        /// Verifica ca toate intrebarile parcurse cu HardStrategy au dificultatea Greu.
        /// </summary>
        [TestMethod]
        public void NextQuestion_HardStrategy_ToateIntrebarile_SuntGreu()
        {
            var manager = new QuizManager(new HardStrategy(), SampleQuestions());
            while (manager.GetCurrentQuestion() != null)
            {
                Assert.AreEqual("Greu", manager.GetCurrentQuestion().DifficultyLevel);
                manager.NextQuestion();
            }
        }

        // ===== Strategii - FilterQuestions =====

        /// <summary>
        /// Verifica ca EasyStrategy filtreaza corect si returneaza doar intrebari Usor.
        /// </summary>
        [TestMethod]
        public void EasyStrategy_FilterQuestions_ReturneazaDoarUsor()
        {
            var strategy = new EasyStrategy();
            var result = strategy.FilterQuestions(SampleQuestions());
            Assert.IsTrue(result.All(q => q.DifficultyLevel == "Usor"));
        }

        /// <summary>
        /// Verifica ca MediumStrategy filtreaza corect si returneaza doar intrebari Mediu.
        /// </summary>
        [TestMethod]
        public void MediumStrategy_FilterQuestions_ReturneazaDoarMediu()
        {
            var strategy = new MediumStrategy();
            var result = strategy.FilterQuestions(SampleQuestions());
            Assert.IsTrue(result.All(q => q.DifficultyLevel == "Mediu"));
        }

        /// <summary>
        /// Verifica ca HardStrategy filtreaza corect si returneaza doar intrebari Greu.
        /// </summary>
        [TestMethod]
        public void HardStrategy_FilterQuestions_ReturneazaDoarGreu()
        {
            var strategy = new HardStrategy();
            var result = strategy.FilterQuestions(SampleQuestions());
            Assert.IsTrue(result.All(q => q.DifficultyLevel == "Greu"));
        }

        /// <summary>
        /// Verifica ca filtrarea unei liste goale returneaza o lista goala.
        /// </summary>
        [TestMethod]
        public void EasyStrategy_FilterQuestions_ListaGoala_ReturneazaGol()
        {
            var strategy = new EasyStrategy();
            var result = strategy.FilterQuestions(new List<Question>());
            Assert.AreEqual(0, result.Count);
        }

        /// <summary>
        /// Verifica ca numarul de intrebari Usor filtrate din SampleQuestions este exact 2.
        /// </summary>
        [TestMethod]
        public void FilterQuestions_NumarCorect_Usor()
        {
            var strategy = new EasyStrategy();
            var result = strategy.FilterQuestions(SampleQuestions());
            Assert.AreEqual(2, result.Count);
        }

        // ===== Strategii - CalculateScore =====

        /// <summary>
        /// Verifica ca EasyStrategy calculeaza corect scorul pornind de la 0.
        /// </summary>
        [TestMethod]
        public void EasyStrategy_CalculateScore_DeLa0_Returneaza1()
        {
            Assert.AreEqual(1, new EasyStrategy().CalculateScore(0));
        }

        /// <summary>
        /// Verifica ca MediumStrategy calculeaza corect scorul pornind de la 0.
        /// </summary>
        [TestMethod]
        public void MediumStrategy_CalculateScore_DeLa0_Returneaza2()
        {
            Assert.AreEqual(2, new MediumStrategy().CalculateScore(0));
        }

        /// <summary>
        /// Verifica ca HardStrategy calculeaza corect scorul pornind de la 0.
        /// </summary>
        [TestMethod]
        public void HardStrategy_CalculateScore_DeLa0_Returneaza3()
        {
            Assert.AreEqual(3, new HardStrategy().CalculateScore(0));
        }

        /// <summary>
        /// Verifica ca HardStrategy adauga corect 3 puncte la un scor existent.
        /// </summary>
        [TestMethod]
        public void HardStrategy_CalculateScore_DeLa9_Returneaza12()
        {
            Assert.AreEqual(12, new HardStrategy().CalculateScore(9));
        }

        // ===== Question model =====

        /// <summary>
        /// Verifica ca proprietatile unui obiect Question sunt stocate si returnate corect.
        /// </summary>
        [TestMethod]
        public void Question_ProprietatiSetate_SeStocheazaCorect()
        {
            var q = new Question
            {
                Id = 42,
                QuestionText = "Test?",
                OptionA = "A",
                OptionB = "B",
                OptionC = "C",
                OptionD = "D",
                CorrectOption = "A",
                DifficultyLevel = "Greu"
            };
            Assert.AreEqual(42, q.Id);
            Assert.AreEqual("Test?", q.QuestionText);
            Assert.AreEqual("A", q.CorrectOption);
            Assert.AreEqual("Greu", q.DifficultyLevel);
        }

        // ===== Teste cu exceptii =====

        /// <summary>
        /// Verifica ca o exceptie ArgumentNullException este aruncata cand raspunsul selectat este null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckAnswer_SelectedOptionNull_AruncaExceptie()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer(null, "Paris");
        }

        /// <summary>
        /// Verifica ca o exceptie ArgumentNullException este aruncata cand raspunsul corect este null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckAnswer_CorrectOptionNull_AruncaExceptie()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Paris", null);
        }

        /// <summary>
        /// Verifica ca o exceptie ArgumentNullException este aruncata cand strategia este null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuizManager_StrategyNull_AruncaExceptie()
        {
            var manager = new QuizManager(null);
        }

        /// <summary>
        /// Verifica ca o exceptie ArgumentNullException este aruncata cand strategia este null si se furnizeaza o lista.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuizManager_StrategyNullCuLista_AruncaExceptie()
        {
            var manager = new QuizManager(null, SampleQuestions());
        }

        /// <summary>
        /// Verifica ca o exceptie ArgumentNullException este aruncata cand lista de intrebari este null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuizManager_ListaNull_AruncaExceptie()
        {
            var manager = new QuizManager(new EasyStrategy(), null);
        }

        // ===== Helper =====

        /// <summary>
        /// Returneaza o lista de intrebari de test folosita in testele unitare.
        /// Contine cate o intrebare pentru fiecare nivel de dificultate, plus una extra pentru Usor.
        /// </summary>
        /// <returns>Lista de obiecte Question predefinite pentru testare</returns>
        private List<Question> SampleQuestions() => new List<Question>
        {
            new Question { Id=1, QuestionText="Q1", OptionA="A", OptionB="B", OptionC="C", OptionD="D", CorrectOption="A", DifficultyLevel="Usor" },
            new Question { Id=2, QuestionText="Q2", OptionA="A", OptionB="B", OptionC="C", OptionD="D", CorrectOption="B", DifficultyLevel="Usor" },
            new Question { Id=3, QuestionText="Q3", OptionA="A", OptionB="B", OptionC="C", OptionD="D", CorrectOption="C", DifficultyLevel="Mediu" },
            new Question { Id=4, QuestionText="Q4", OptionA="A", OptionB="B", OptionC="C", OptionD="D", CorrectOption="D", DifficultyLevel="Greu" },
        };
    }
}