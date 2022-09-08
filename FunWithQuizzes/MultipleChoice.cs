using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithQuizzes
{
    public class MultipleChoice : Question
    {
        public string ChoicesText {get; set;}

        public MultipleChoice(string questionText, int points, string choicesText) : base(questionText, points)
        {
            ChoicesText = choicesText;
        }
        public override void DisplayQuestion()
        {
            Console.WriteLine(this.QuestionText);
        }
        public override void DisplayChoices()
        {
            Console.WriteLine(this.ChoicesText);
        }

        public override string GetAnswers()
        {
            string answer = Console.ReadLine();
            return answer;
        }
    }
}
