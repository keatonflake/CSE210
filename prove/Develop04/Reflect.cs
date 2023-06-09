public class Reflect : Activity
{
    private string _startingMessage = "Lets take some time to reflect...";
    private string _endingMessage = "Thanks for taking time to reflect!!!";

    private List<string> _topics = new List<string>()
{
    "What part of your day made you smile?",
    "What challenges did you overcome today?",
    "How did you show kindness to someone today?",
    "What new thing did you learn today?",
    "What was the highlight of your day?",
    "What made you feel grateful today?",
    "What made you feel proud of yourself today?",
    "What inspired or motivated you today?",
    "What was the most interesting conversation you had today?",
    "What mistake or failure did you learn from today?",
    "What did you do to take care of yourself today?",
    "What goal or achievement are you working towards?"
};

    private List<string> _followUpQuestions = new List<string>()
{
    "How did that experience make you feel?",
    "What thoughts or emotions did it evoke?",
    "Can you describe the impact it had on you?",
    "Did it remind you of any similar experiences?",
    "How do you think it contributes to your overall well-being?",
    "What lessons, if any, did you learn from this?",
    "How does it align with your values or priorities?",
    "Did it change your perspective on anything?",
    "How do you think it might influence your future actions?",
    "What connections can you draw between this and other aspects of your life?",
    "In what ways does it relate to your long-term goals?",
    "How might you extend or build upon this experience?"
};

    public void StartActivity()
    {
        
        Console.WriteLine();
        Console.WriteLine(_topics[Randomindex(_topics.Count()-1)]);
        Console.WriteLine();
        Console.WriteLine("When you have someting in mind hit enter");
        string input = Console.ReadLine();
        while (input != "")
        {
            Console.WriteLine("When you have someting in mind press enter to continue");
            input = Console.ReadLine();
        }
        Console.WriteLine();
        Console.WriteLine($"You may begin in...");
        Countdown(3);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);

        while (futureTime > DateTime.Now)
        {
            Console.WriteLine(_followUpQuestions[Randomindex(_followUpQuestions.Count() -1)]);
            ShowSpinner(5);
        }

    }

    public void GetStartingMessage(){
        Console.WriteLine(_startingMessage);
    }

    public void GetEndingMessage(){
        Console.WriteLine(_endingMessage);
    }

}