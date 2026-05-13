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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            comboBoxDifficulty.Items.Add("Usor");
            comboBoxDifficulty.Items.Add("Mediu");
            comboBoxDifficulty.Items.Add("Greu");

            comboBoxDifficulty.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            IQuizStrategy strategy;

            string selectedDifficulty = comboBoxDifficulty.SelectedItem.ToString();

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

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicație tip Quiz.");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
