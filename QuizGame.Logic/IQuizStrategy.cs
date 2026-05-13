using QuizGame.AccessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Logic.Strategies
{
    public interface IQuizStrategy
    {
        int CalculateScore(int currentScore);

        List<Question> FilterQuestions(List<Question> questions);
    }
}