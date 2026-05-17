using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizGame.AccessData;
using QuizGame.Logic;
using QuizGame.Logic.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizGame.Tests
{
    [TestClass]
    public class QuizGameTests
    {
        // ===== CheckAnswer - Comportament de bază =====

        [TestMethod]
        public void CheckAnswer_RaspunsCorect_ReturneazaTrue()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsTrue(manager.CheckAnswer("Paris", "Paris"));
        }

        [TestMethod]
        public void CheckAnswer_RaspunsGresit_ReturneazaFalse()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsFalse(manager.CheckAnswer("Roma", "Paris"));
        }

        [TestMethod]
        public void CheckAnswer_StringGol_ReturneazaFalse()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsFalse(manager.CheckAnswer("", "Paris"));
        }

        [TestMethod]
        public void CheckAnswer_AmbeleGoale_ReturneazaTrue()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsTrue(manager.CheckAnswer("", ""));
        }

        [TestMethod]
        public void CheckAnswer_CaseSensitive_ReturneazaFalse()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsFalse(manager.CheckAnswer("paris", "Paris"));
        }

        [TestMethod]
        public void CheckAnswer_SpatiuExtra_ReturneazaFalse()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsFalse(manager.CheckAnswer("Paris ", "Paris"));
        }

        [TestMethod]
        public void CheckAnswer_NumarCaString_Corect_ReturneazaTrue()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsTrue(manager.CheckAnswer("7", "7"));
        }

        // ===== CheckAnswer - Scor cu EasyStrategy (+1) =====

        [TestMethod]
        public void CheckAnswer_Corect_EasyStrategy_ScorCreste1()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Paris", "Paris");
            Assert.AreEqual(1, manager.Score);
        }

        [TestMethod]
        public void CheckAnswer_Gresit_EasyStrategy_ScorRamane0()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Roma", "Paris");
            Assert.AreEqual(0, manager.Score);
        }

        [TestMethod]
        public void CheckAnswer_TreiCorecte_EasyStrategy_ScorEste3()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Paris", "Paris");
            manager.CheckAnswer("7", "7");
            manager.CheckAnswer("Oxigen", "Oxigen");
            Assert.AreEqual(3, manager.Score);
        }

        [TestMethod]
        public void CheckAnswer_UnCorectUnGresit_EasyStrategy_ScorEste1()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Paris", "Paris");
            manager.CheckAnswer("Roma", "Paris");
            Assert.AreEqual(1, manager.Score);
        }

        // ===== CheckAnswer - Scor cu MediumStrategy (+2) =====

        [TestMethod]
        public void CheckAnswer_Corect_MediumStrategy_ScorCreste2()
        {
            var manager = new QuizManager(new MediumStrategy());
            manager.CheckAnswer("Aur", "Aur");
            Assert.AreEqual(2, manager.Score);
        }

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

        [TestMethod]
        public void CheckAnswer_Corect_HardStrategy_ScorCreste3()
        {
            var manager = new QuizManager(new HardStrategy());
            manager.CheckAnswer("Osmiu", "Osmiu");
            Assert.AreEqual(3, manager.Score);
        }

        [TestMethod]
        public void CheckAnswer_Gresit_HardStrategy_ScorRamane0()
        {
            var manager = new QuizManager(new HardStrategy());
            manager.CheckAnswer("Plumb", "Osmiu");
            Assert.AreEqual(0, manager.Score);
        }

        [TestMethod]
        public void CheckAnswer_DoiCorecti_HardStrategy_ScorEste6()
        {
            var manager = new QuizManager(new HardStrategy());
            manager.CheckAnswer("Osmiu", "Osmiu");
            manager.CheckAnswer("Electron", "Electron");
            Assert.AreEqual(6, manager.Score);
        }

        // ===== Score =====

        [TestMethod]
        public void Score_Initial_EsteZero()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.AreEqual(0, manager.Score);
        }

        [TestMethod]
        public void Score_DupaSetupGame_EsteZero()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            Assert.AreEqual(0, manager.Score);
        }

        [TestMethod]
        public void Score_DupaSetupGameDinNou_SeReseteaza()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            manager.CheckAnswer("Paris", "Paris");
            var manager2 = new QuizManager(new EasyStrategy(), SampleQuestions());
            Assert.AreEqual(0, manager2.Score);
        }

        // ===== GetCurrentQuestion =====

        [TestMethod]
        public void GetCurrentQuestion_DupaSetupGame_NuEsteNull()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            Assert.IsNotNull(manager.GetCurrentQuestion());
        }

        [TestMethod]
        public void GetCurrentQuestion_FaraSetupGame_EsteNull()
        {
            var manager = new QuizManager(new EasyStrategy());
            Assert.IsNull(manager.GetCurrentQuestion());
        }

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

        [TestMethod]
        public void GetCurrentQuestion_EasyStrategy_ReturneazaDoarUsor()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            Assert.AreEqual("Usor", manager.GetCurrentQuestion().DifficultyLevel);
        }

        [TestMethod]
        public void GetCurrentQuestion_MediumStrategy_ReturneazaDoarMediu()
        {
            var manager = new QuizManager(new MediumStrategy(), SampleQuestions());
            Assert.AreEqual("Mediu", manager.GetCurrentQuestion().DifficultyLevel);
        }

        [TestMethod]
        public void GetCurrentQuestion_HardStrategy_ReturneazaDoarGreu()
        {
            var manager = new QuizManager(new HardStrategy(), SampleQuestions());
            Assert.AreEqual("Greu", manager.GetCurrentQuestion().DifficultyLevel);
        }

        // ===== NextQuestion =====

        [TestMethod]
        public void NextQuestion_SchimbaIntrebareaCurenta()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            var prima = manager.GetCurrentQuestion();
            manager.NextQuestion();
            var adoua = manager.GetCurrentQuestion();
            Assert.AreNotEqual(prima.Id, adoua.Id);
        }

        [TestMethod]
        public void NextQuestion_DupaToate_ReturneazaNull()
        {
            var manager = new QuizManager(new EasyStrategy(), SampleQuestions());
            while (manager.GetCurrentQuestion() != null)
                manager.NextQuestion();
            Assert.IsNull(manager.GetCurrentQuestion());
        }

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

        [TestMethod]
        public void EasyStrategy_FilterQuestions_ReturneazaDoarUsor()
        {
            var strategy = new EasyStrategy();
            var result = strategy.FilterQuestions(SampleQuestions());
            Assert.IsTrue(result.All(q => q.DifficultyLevel == "Usor"));
        }

        [TestMethod]
        public void MediumStrategy_FilterQuestions_ReturneazaDoarMediu()
        {
            var strategy = new MediumStrategy();
            var result = strategy.FilterQuestions(SampleQuestions());
            Assert.IsTrue(result.All(q => q.DifficultyLevel == "Mediu"));
        }

        [TestMethod]
        public void HardStrategy_FilterQuestions_ReturneazaDoarGreu()
        {
            var strategy = new HardStrategy();
            var result = strategy.FilterQuestions(SampleQuestions());
            Assert.IsTrue(result.All(q => q.DifficultyLevel == "Greu"));
        }

        [TestMethod]
        public void EasyStrategy_FilterQuestions_ListaGoala_ReturneazaGol()
        {
            var strategy = new EasyStrategy();
            var result = strategy.FilterQuestions(new List<Question>());
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void FilterQuestions_NumarCorect_Usor()
        {
            var strategy = new EasyStrategy();
            var result = strategy.FilterQuestions(SampleQuestions());
            Assert.AreEqual(2, result.Count);
        }

        // ===== Strategii - CalculateScore =====

        [TestMethod]
        public void EasyStrategy_CalculateScore_DeLa0_Returneaza1()
        {
            Assert.AreEqual(1, new EasyStrategy().CalculateScore(0));
        }

        [TestMethod]
        public void MediumStrategy_CalculateScore_DeLa0_Returneaza2()
        {
            Assert.AreEqual(2, new MediumStrategy().CalculateScore(0));
        }

        [TestMethod]
        public void HardStrategy_CalculateScore_DeLa0_Returneaza3()
        {
            Assert.AreEqual(3, new HardStrategy().CalculateScore(0));
        }

        [TestMethod]
        public void HardStrategy_CalculateScore_DeLa9_Returneaza12()
        {
            Assert.AreEqual(12, new HardStrategy().CalculateScore(9));
        }

        // ===== Question model =====

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

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckAnswer_SelectedOptionNull_AruncaExceptie()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer(null, "Paris");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckAnswer_CorrectOptionNull_AruncaExceptie()
        {
            var manager = new QuizManager(new EasyStrategy());
            manager.CheckAnswer("Paris", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuizManager_StrategyNull_AruncaExceptie()
        {
            var manager = new QuizManager(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuizManager_StrategyNullCuLista_AruncaExceptie()
        {
            var manager = new QuizManager(null, SampleQuestions());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuizManager_ListaNull_AruncaExceptie()
        {
            var manager = new QuizManager(new EasyStrategy(), null);
        }

        // ===== Helper =====

        private List<Question> SampleQuestions() => new List<Question>
        {
            new Question { Id=1, QuestionText="Q1", OptionA="A", OptionB="B", OptionC="C", OptionD="D", CorrectOption="A", DifficultyLevel="Usor" },
            new Question { Id=2, QuestionText="Q2", OptionA="A", OptionB="B", OptionC="C", OptionD="D", CorrectOption="B", DifficultyLevel="Usor" },
            new Question { Id=3, QuestionText="Q3", OptionA="A", OptionB="B", OptionC="C", OptionD="D", CorrectOption="C", DifficultyLevel="Mediu" },
            new Question { Id=4, QuestionText="Q4", OptionA="A", OptionB="B", OptionC="C", OptionD="D", CorrectOption="D", DifficultyLevel="Greu" },
        };
    }
}