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
    public partial class EndForm : Form
    {
        public EndForm(int scorFinal)
        {
            InitializeComponent();

            // Afișăm scorul în label-ul de pe ecran
            labelScor.Text = $"Felicitări! Ai terminat quiz-ul.\nScorul tău final este: {scorFinal}";


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Închide complet toată aplicația
        }
        // Dacă utilizatorul apasă pe "X" sus în dreapta, ne asigurăm că aplicația se închide complet
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}
