using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuizzes
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public int Points { get; set; }

        public Question (string questionText, int points)
        {
            QuestionText = questionText;
            Points = points;
        }

        //Display the questions
        public abstract void DisplayQuestion();

        //Display answer choices
        public abstract void DisplayChoices();
        
        //Get user answer
        public abstract string GetAnswers();

    }
}
