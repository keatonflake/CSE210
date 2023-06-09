public class Activity
{
    protected int _time;
    public void GetTime(){
        Console.WriteLine("how many seconds would you like to do this activity for?: ");
        string time = Console.ReadLine();
        _time = Int32.Parse(time);
    }
    public void ShowSpinner(int duration)
    {
        List<string> animations = new List<string>
            {
                "-",
                "\\",
                "|",
                "/",
            };

        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        int animationIndex = 0;
        while (DateTime.Now < endTime)
        {
            string frame = animations[animationIndex];
            Console.Write(frame);

            Thread.Sleep(250);

            Console.Write("\b \b");

            animationIndex++;
            if (animationIndex >= animations.Count)
            {
                animationIndex = 0;
            }
        }
    }
    public void Countdown(int duration)
    {
        int currentValue = duration;
        while (currentValue > 0)
        {
            Console.Write(currentValue);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            currentValue--;
        }
    }
    Random random = new Random();
    protected int Randomindex(int maxNumber)
    {
    {
        return random.Next(1, maxNumber + 1);
    }
    }

}