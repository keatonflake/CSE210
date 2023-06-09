public class Breathe : Activity
{
    private string _startingMessage = "Lets slow things down and start breathing...";
    private string _endingMessage = "Thanks for taking the time to slow down";
    // private int _totalDuration;
    private int breatheinDuration = 5;
    private int breatheoutDuration = 5;

    public void GetStartingMessage(){
        Console.WriteLine(_startingMessage);
        ShowSpinner(3);
    }

    public void GetEndingMessage(){
        Console.WriteLine(_endingMessage);
        ShowSpinner(3);
    }

    public void StartActivity(){

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        
        while(futureTime > DateTime.Now)
        {
            Console.WriteLine("breath In");
            Countdown(breatheinDuration);
            // Thread.Sleep(_time * 1000);

            Console.WriteLine("breath out");
            Countdown(breatheoutDuration);
            // Thread.Sleep(_time * 1000);
        }

    }
}