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
    /// <summary>
    /// Formularul principal de desfasurare a quiz-ului.
    /// Gestioneaza afisarea intrebarilor, preluarea raspunsurilor si calculul scorului.
    /// </summary>
    public partial class FormQuiz : Form
    {
        private QuizManager _quizManager; // Managerul principal al jocului de quiz, responsabil cu logica intrebarilor si scorului
        private bool _quizFinished = false; // Indica daca quiz-ul s-a terminat, pentru a evita inchiderea accidentala a aplicatiei

        /// <summary>
        /// Constructorul formularului de quiz.
        /// Initializeaza interfata, seteaza strategia de dificultate si pregateste jocul.
        /// </summary>
        /// <param name="strategy">Strategia de selectie a intrebarilor (Usor, Mediu sau Greu)</param>
        public FormQuiz(IQuizStrategy strategy)
        {
            InitializeComponent();
            // Daca quiz-ul nu s-a terminat normal, inchidem intreaga aplicatie la inchiderea ferestrei
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

        /// <summary>
        /// Evenimentul de incarcare al formularului.
        /// Initializeaza jocul si afiseaza prima intrebare.
        /// </summary>
        /// <param name="sender">Sursa evenimentului</param>
        /// <param name="e">Argumentele evenimentului</param>
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

        /// <summary>
        /// Afiseaza intrebarea curenta in interfata grafica.
        /// Daca nu mai exista intrebari, deschide formularul de final si inchide cel curent.
        /// </summary>
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

                // Actualizam scorul afisat dupa fiecare intrebare
                labelScore.Text = "Scor: " + _quizManager.Score;

                // Debifam toate optiunile pentru a evita preluarea raspunsului anterior
                radioButtonOptionA.Checked = false;
                radioButtonOptionB.Checked = false;
                radioButtonOptionC.Checked = false;
                radioButtonOptionD.Checked = false;
            }
            else
            {
                // Nu mai sunt intrebari disponibile, quiz-ul s-a incheiat
                _quizFinished = true;
                EndForm paginaFinal = new EndForm(_quizManager.Score);
                paginaFinal.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Returneaza textul optiunii selectate de utilizator.
        /// Arunca o exceptie daca nicio optiune nu este selectata.
        /// </summary>
        /// <returns>Textul raspunsului selectat de utilizator</returns>
        /// <exception cref="QuizException">Aruncata cand utilizatorul nu a selectat niciun raspuns</exception>
        private string GetRaspunsSelectat()
        {
            if (radioButtonOptionA.Checked) return radioButtonOptionA.Text;
            if (radioButtonOptionB.Checked) return radioButtonOptionB.Text;
            if (radioButtonOptionC.Checked) return radioButtonOptionC.Text;
            if (radioButtonOptionD.Checked) return radioButtonOptionD.Text;

            throw new QuizException("Te rog să selectezi un răspuns!");
        }

        /// <summary>
        /// Gestioneaza apasarea butonului „Urmatoarea intrebare".
        /// Verifica raspunsul selectat, afiseaza mesaj daca este gresit, apoi trece la urmatoarea intrebare.
        /// </summary>
        /// <param name="sender">Sursa evenimentului</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
          
            try
            {
                var intrebare = _quizManager.GetCurrentQuestion();
                if (intrebare == null)
                    return;

                string raspunsSelectat = "";
                raspunsSelectat = GetRaspunsSelectat();

                // Verificam corectitudinea raspunsului prin logica din DLL
                bool eCorect = _quizManager.CheckAnswer(raspunsSelectat, intrebare.CorrectOption);
                if(!eCorect)
                {
                    MessageBox.Show($"Raspuns gresit! Varianta corecta era: {intrebare.CorrectOption}");
                }

                // Trecem la urmatoarea intrebare si reimprospatam interfata

                _quizManager.NextQuestion();

                AfiseazaIntrebareaCurenta();
            }
            catch (QuizException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
        }

        
    }
}
