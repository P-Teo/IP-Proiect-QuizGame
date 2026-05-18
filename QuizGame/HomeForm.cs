using QuizGame.Logic.Strategies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    /// <summary>
    /// Formularul principal al aplicatiei (pagina de start).
    /// Permite utilizatorului sa aleaga dificultatea quiz-ului si sa acceseze sectiunile aplicatiei.
    /// </summary>
    public partial class HomeForm : Form
    {
        /// <summary>
        /// Constructorul formularului principal (pagina de start).
        /// Initializeaza interfata si populeaza lista de dificultati disponibile.
        /// </summary>
        public HomeForm()
        {
            InitializeComponent();
            // Inchidem aplicatia complet daca utilizatorul inchide fereastra principala
            this.FormClosed += (s, e) => Application.Exit();

            // Adaugam nivelurile de dificultate disponibile in lista derulanta
            comboBoxDifficulty.Items.Add("Usor");
            comboBoxDifficulty.Items.Add("Mediu");
            comboBoxDifficulty.Items.Add("Greu");
            comboBoxDifficulty.SelectedIndex = 0;
            
        }

        /// <summary>
        //// Gestioneaza apasarea butonului de start.
        /// Instantiaza strategia corespunzatoare dificultatii alese si deschide formularul de quiz.
        /// </summary>
        /// <param name="sender">Sursa evenimentului</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            IQuizStrategy strategy;

            string selectedDifficulty = comboBoxDifficulty.SelectedItem.ToString();

            // Selectam strategia de intrebari in functie de dificultatea aleasa
            switch (selectedDifficulty)
            {
                case "Usor":
                    strategy = new EasyStrategy();
                    break;

                case "Mediu":
                    strategy = new MediumStrategy();
                    break;

                case "Greu":
                    strategy = new HardStrategy();
                    break;

                default:
                    strategy = new EasyStrategy();
                    break;
            }

            FormQuiz quizForm = new FormQuiz(strategy);

            quizForm.Show();

            this.Hide();
        }

        /// <summary>
        /// Gestioneaza apasarea butonului „Despre".
        /// Afiseaza un mesaj scurt cu informatii despre aplicatie.
        /// </summary>
        /// <param name="sender">Sursa evenimentului</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicație tip Quiz.");
        }

        /// <summary>
        /// Gestioneaza apasarea butonului de iesire.
        /// Inchide complet aplicatia.
        /// </summary>
        /// <param name="sender">Sursa evenimentului</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Gestioneaza apasarea butonului de ajutor.
        /// Deschide fisierul de documentatie CHM al aplicatiei.
        /// </summary>
        /// <param name="sender">Sursa evenimentului</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("QuizGame.chm");
        }
    }
}
