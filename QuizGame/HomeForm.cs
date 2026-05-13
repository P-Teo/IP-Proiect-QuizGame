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
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormQuiz quizForm = new FormQuiz(); // Creăm instanța ferestrei de quiz
            quizForm.Show();              // O afișăm pe ecran
            this.Hide();                  // Ascundem fereastra principală de acasă
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicație tip Quiz.");
        }
    }
}
