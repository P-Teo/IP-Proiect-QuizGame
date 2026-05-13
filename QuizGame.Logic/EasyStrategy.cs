using QuizGame.AccessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Logic.Strategies
{
    public class EasyStrategy : IQuizStrategy
    {
        public int CalculateScore(int currentScore)
        {
            return currentScore + 1;
        }

        public List<Question> FilterQuestions(List<Question> questions)
        {
            return questions
                .Where(q => q.DifficultyLevel == "Usor")
                .ToList();
        }
    }
}