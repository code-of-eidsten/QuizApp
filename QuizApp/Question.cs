namespace QuizApp;

public class Question
{
    string _question;
    List<string> _answerList;
    char _answer;
    
    public Question(string question, List<string> answerList, char answer)
    {
        _question = question;
        _answerList = answerList;
        _answer = answer;
    }



    public string GetQuestion()
    {
        return _question;
    }
    
    public void GetAnswerList()
    {
        foreach (string answer in _answerList)
        {
            Console.WriteLine(answer);
        }
    }
    
    public bool CheckAnswer(char answerEntered)
    {
        if (answerEntered == _answer)
        {
            return true;
        }
        return false;
    }
}