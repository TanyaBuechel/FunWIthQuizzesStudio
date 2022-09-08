using FunWithQuizzes;

MultipleChoice capitalCity = new MultipleChoice("What is the capital city of Illinois?", 5, "A: Springfield, B: Chicago, C: Alton");
MultipleChoice river = new MultipleChoice("Which river creates the western boarder of Illinois?", 5, "A: Illinois River, B: Mississippi River, C: Kaskaskia River");

List<string> allQuestions = new List<string>();
List<string> allAnswers = new List<string>();

capitalCity.DisplayQuestion(); 
capitalCity.DisplayChoices();
allAnswers.Add(capitalCity.GetAnswers());

river.DisplayQuestion();
river.DisplayChoices();
allAnswers.Add(river.GetAnswers());

for (int i = 0; i < allAnswers.Count; i++)
{
    Console.WriteLine(allAnswers[i]);
}
