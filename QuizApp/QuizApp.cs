namespace QuizApp;

public class QuizApp
{
    int _numberOfCorrectAnswers;
    List<Question> _questionList = new List<Question>();
    
    
    public QuizApp()
    {
        CreateQuestions();
    }

    private void CreateQuestions()
    {
        List<string> answerList1 = new List<string>();
        answerList1.Add("A: Faris");
        answerList1.Add("B: Paris");
        answerList1.Add("C: Lyon");
        Question q1 = new Question("Hva er hovedstaden i Frankrike?", answerList1,'b');
        
        List<string> answerList2 = new List<string>();
        answerList2.Add("A: 100");
        answerList2.Add("B: 200");
        answerList2.Add("C: 300");
        Question q2 = new Question("Hva er verdien til 100?", answerList2,'a');
        
        List<string> answerList3 = new List<string>();
        answerList3.Add("A: Rød");
        answerList3.Add("B: Grønn");
        answerList3.Add("C: Blå");
        Question q3 = new Question("Hvilken farge er IKKE i det norske flagget?", answerList3, 'b');
        
        _questionList.Add(q1);
        _questionList.Add(q2);
        _questionList.Add(q3);
    }

    public void StartQuiz()
    {
        foreach (Question q in _questionList)
        {
            Console.WriteLine($"{q.GetQuestion()}");
            q.GetAnswerList();
            Console.WriteLine("Enter your answer: ");
            char answer = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (q.CheckAnswer(answer))
            {
                Console.WriteLine("Correct answer");
                _numberOfCorrectAnswers++;
            }
            else if (q.CheckAnswer(answer) == false)
            {
                Console.WriteLine("Wrong answer");
            }
           
            Console.WriteLine($"Your points: {_numberOfCorrectAnswers}");
            
        }
    }
    
    
}