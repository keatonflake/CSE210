public class Listing : Activity
{
    private string _startingMessage = "Welcome";
    private string _endingMessage = "Thanks for taking the time to List your thoughts";

    List<string> _dailyJournalPrompts = new List<string>()
{
    "What are three things you are grateful for today and why?",
    "Describe a positive interaction you had with someone today.",
    "Write about a small act of kindness you did for someone or someone did for you.",
    "What are your goals for today and how will you work towards achieving them?",
    "Reflect on a challenge you faced today and how you overcame it.",
    "Write about a new thing you learned today and how it expanded your knowledge.",
    "Describe a moment of joy or happiness you experienced today.",
    "What made you smile or laugh today?",
    "Write about a book, article, or podcast that inspired you today and why.",
    "Reflect on your emotions today and what might have influenced them.",
    "Describe a moment of self-care or self-reflection you had today.",
    "What is something you accomplished today that you're proud of?",
    "Write about a decision you made today and the thought process behind it.",
    "What are you looking forward to tomorrow and why?",
    "Describe a situation or conversation that made you think deeply today.",
    "Write about a mistake you made today and what you learned from it.",
    "Reflect on a moment of gratitude for the simple things in your life today.",
    "What is one thing you can do differently tomorrow to improve your day?",
    "Write about a moment of mindfulness or being fully present today.",
    "Describe a goal or intention you have for the upcoming week and why it's important to you."
};

    public void StartActivity(){
        Console.WriteLine();
        ShowSpinner(3);
        Console.WriteLine();

        string _activePrompt = _dailyJournalPrompts[Randomindex(_dailyJournalPrompts.Count()-1)];
        Console.WriteLine(_activePrompt);
        File.AppendAllText("answers.txt", "\n\n" + _activePrompt);


        Console.Write("Get ready to type in...");
        Countdown(3);
        Console.WriteLine("Start typing: ");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        while(futureTime > DateTime.Now)
        {
            Console.WriteLine();
            string input = Console.ReadLine();
            File.AppendAllText("answers.txt", "\n" + input);
        }

        GetEndingMessage();
        ShowSpinner(3);
    }

    public void GetStartingMessage(){
        Console.WriteLine(_startingMessage);
    }
    public void GetEndingMessage(){
        Console.WriteLine(_endingMessage);
    }
}