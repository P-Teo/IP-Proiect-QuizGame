using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizGame.AccessData;
using QuizGame.Logic;
using System;

namespace QuizGame.Tests
{
    [TestClass]
    public class QuizGameTests
    {
        [TestMethod]
        public void CheckAnswer_RaspunsCorect_ReturneazaTrue()
        {
            var manager = new QuizManager();
            bool rezultat = manager.CheckAnswer("Paris", "Paris");
            Assert.IsTrue(rezultat);
        }

        [TestMethod]
        public void CheckAnswer_RaspunsGresit_ReturneazaFalse()
        {
            var manager = new QuizManager();
            bool rezultat = manager.CheckAnswer("Roma", "Paris");
            Assert.IsFalse(rezultat);
        }

        [TestMethod]
        public void CheckAnswer_RaspunsCorect_ScorulCreste()
        {
            var manager = new QuizManager();
            manager.CheckAnswer("Paris", "Paris");
            Assert.AreEqual(1, manager.Score);
        }

        [TestMethod]
        public void CheckAnswer_RaspunsGresit_ScorulNuCreste()
        {
            var manager = new QuizManager();
            manager.CheckAnswer("Roma", "Paris");
            Assert.AreEqual(0, manager.Score);
        }

        [TestMethod]
        public void CheckAnswer_DoiRaspunsuriCorecte_ScorulEste2()
        {
            var manager = new QuizManager();
            manager.CheckAnswer("Paris", "Paris");
            manager.CheckAnswer("7", "7");
            Assert.AreEqual(2, manager.Score);
        }

        [TestMethod]
        public void CheckAnswer_StringGol_ReturneazaFalse()
        {
            var manager = new QuizManager();
            bool rezultat = manager.CheckAnswer("", "Paris");
            Assert.IsFalse(rezultat);
        }

        [TestMethod]
        public void CheckAnswer_CaseSensitive_ReturneazaFalse()
        {
            var manager = new QuizManager();
            bool rezultat = manager.CheckAnswer("paris", "Paris");
            Assert.IsFalse(rezultat);
        }

        [TestMethod]
        public void CheckAnswer_AmbeleStringuriGoale_ReturneazaTrue()
        {
            var manager = new QuizManager();
            bool rezultat = manager.CheckAnswer("", "");
            Assert.IsTrue(rezultat);
        }

        // ===== TESTARE Score =====

        [TestMethod]
        public void Score_Initial_EsteZero()
        {
            var manager = new QuizManager();
            Assert.AreEqual(0, manager.Score);
        }

        [TestMethod]
        public void Score_DupaSetupGame_EsteZero()
        {
            var manager = new QuizManager();
            manager.SetupGame();
            Assert.AreEqual(0, manager.Score);
        }

        [TestMethod]
        public void Score_DupaUnRaspunsCorect_EsteUnu()
        {
            var manager = new QuizManager();
            manager.CheckAnswer("Paris", "Paris");
            Assert.AreEqual(1, manager.Score);
        }

        [TestMethod]
        public void Score_DupaSetupGameDinNou_SeReseteazaLaZero()
        {
            var manager = new QuizManager();
            manager.CheckAnswer("Paris", "Paris");
            manager.SetupGame(); // reset
            Assert.AreEqual(0, manager.Score);
        }

        // ===== TESTARE GetCurrentQuestion =====

        [TestMethod]
        public void GetCurrentQuestion_DupaSetupGame_NuEsteNull()
        {
            var manager = new QuizManager();
            manager.SetupGame();
            var intrebare = manager.GetCurrentQuestion();
            Assert.IsNotNull(intrebare);
        }

        [TestMethod]
        public void GetCurrentQuestion_PrimaIntrebare_AreText()
        {
            var manager = new QuizManager();
            manager.SetupGame();
            var intrebare = manager.GetCurrentQuestion();
            Assert.IsFalse(string.IsNullOrEmpty(intrebare.QuestionText));
        }

        [TestMethod]
        public void GetCurrentQuestion_PrimaIntrebare_Are4Variante()
        {
            var manager = new QuizManager();
            manager.SetupGame();
            var intrebare = manager.GetCurrentQuestion();
            Assert.IsFalse(string.IsNullOrEmpty(intrebare.OptionA));
            Assert.IsFalse(string.IsNullOrEmpty(intrebare.OptionB));
            Assert.IsFalse(string.IsNullOrEmpty(intrebare.OptionC));
            Assert.IsFalse(string.IsNullOrEmpty(intrebare.OptionD));
        }

        [TestMethod]
        public void GetCurrentQuestion_PrimaIntrebare_AreRaspunsCorect()
        {
            var manager = new QuizManager();
            manager.SetupGame();
            var intrebare = manager.GetCurrentQuestion();
            Assert.IsFalse(string.IsNullOrEmpty(intrebare.CorrectOption));
        }

        // ===== TESTARE NextQuestion =====

        [TestMethod]
        public void NextQuestion_SchimbaIntrebareaCurenta()
        {
            var manager = new QuizManager();
            manager.SetupGame();
            var primaIntrebare = manager.GetCurrentQuestion();
            manager.NextQuestion();
            var aDouaIntrebare = manager.GetCurrentQuestion();
            Assert.AreNotEqual(primaIntrebare.Id, aDouaIntrebare.Id);
        }

        [TestMethod]
        public void NextQuestion_DupaToateIntrebarile_ReturneazaNull()
        {
            var manager = new QuizManager();
            manager.SetupGame();

            // Trecem prin toate întrebările
            while (manager.GetCurrentQuestion() != null)
            {
                manager.NextQuestion();
            }

            Assert.IsNull(manager.GetCurrentQuestion());
        }

        // ===== TESTARE Question (modelul) =====

        [TestMethod]
        public void Question_ProprietatiSetate_SeStocheazaCorect()
        {
            var q = new Question
            {
                Id = 1,
                QuestionText = "Test?",
                OptionA = "A",
                OptionB = "B",
                OptionC = "C",
                OptionD = "D",
                CorrectOption = "A",
                DifficultyLevel = "Usor"
            };

            Assert.AreEqual(1, q.Id);
            Assert.AreEqual("Test?", q.QuestionText);
            Assert.AreEqual("A", q.CorrectOption);
            Assert.AreEqual("Usor", q.DifficultyLevel);
        }

        [TestMethod]
        public void Question_RaspunsCorectEsteUnadinVariante()
        {
            var manager = new QuizManager();
            manager.SetupGame();
            var intrebare = manager.GetCurrentQuestion();

            bool corectulEInVariante =
                intrebare.CorrectOption == intrebare.OptionA ||
                intrebare.CorrectOption == intrebare.OptionB ||
                intrebare.CorrectOption == intrebare.OptionC ||
                intrebare.CorrectOption == intrebare.OptionD;

            Assert.IsTrue(corectulEInVariante);
        }
    }
}
