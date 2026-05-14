using QuizGame.Logic;
using QuizGame.Logic.Strategies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class FormQuiz : Form
    {
        private QuizManager _quizManager;
        private bool _quizFinished = false;

        public FormQuiz(IQuizStrategy strategy)
        {
            InitializeComponent();
            this.FormClosed += (s, e) => { if (!_quizFinished) Application.Exit(); };

            _quizManager = new QuizManager(strategy);

            try
            {
                _quizManager.SetupGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            try
            {
                _quizManager.SetupGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AfiseazaIntrebareaCurenta();

        }
        private void AfiseazaIntrebareaCurenta()
        {
            var intrebare = _quizManager.GetCurrentQuestion();

            if(intrebare != null)
            {
                labelQuestion.Text = intrebare.QuestionText;
                radioButtonOptionA.Text = intrebare.OptionA;
                radioButtonOptionB.Text = intrebare.OptionB;
                radioButtonOptionC.Text = intrebare.OptionC;
                radioButtonOptionD.Text = intrebare.OptionD;

                //adaugam scorul
                labelScore.Text = "Scor: " + _quizManager.Score;

                //debifam toate butoanele pentru noua intrebare
                radioButtonOptionA.Checked = false;
                radioButtonOptionB.Checked = false;
                radioButtonOptionC.Checked = false;
                radioButtonOptionD.Checked = false;
            }
            else
            {
                _quizFinished = true;
                EndForm paginaFinal = new EndForm(_quizManager.Score);
                paginaFinal.Show();
                this.Close();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var intrebare = _quizManager.GetCurrentQuestion();
            if (intrebare == null)
                return;

            string raspunsSelectat = "";

            //verificam daca butoanul a fost selectat
            if (radioButtonOptionA.Checked) raspunsSelectat = radioButtonOptionA.Text;
            else if (radioButtonOptionB.Checked) raspunsSelectat = radioButtonOptionB.Text;
            else if (radioButtonOptionC.Checked) raspunsSelectat = radioButtonOptionC.Text;
            else if (radioButtonOptionD.Checked) raspunsSelectat = radioButtonOptionD.Text;
            else
            {
                MessageBox.Show("Te rog sa selectezi un raspuns!");
                return;
            }

            //verificam daca raspunsul este corect(apelam logica din DLL)
            bool eCorect = _quizManager.CheckAnswer(raspunsSelectat, intrebare.CorrectOption);

            if(!eCorect)
            {
                MessageBox.Show($"Raspuns gresit! Varianta corecta era: {intrebare.CorrectOption}");
            }

            //trecem la urmatoarea intrebare
            _quizManager.NextQuestion();

            //reimprospatare ecran
            AfiseazaIntrebareaCurenta();
        }
    }
}
