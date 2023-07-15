using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        int creatorCount = 0;
        while (creatorCount <= 3)
        {
            Running newRun = new Running();
            newRun.SetDate("07/14/2023");
            newRun.SetDistance(GetRandomNumber(1,20));
            newRun.SetLengthInMin(GetRandomNumber(10,100));

            _activities.Add(newRun);

            Swimming newSwim = new Swimming();
            newSwim.SetDate("07/" + GetRandomNumber(10,30) + "/2023");
            newSwim.SetLaps(GetRandomNumber(10,25));
            newSwim.SetLengthInMin(GetRandomNumber(10,100));

            _activities.Add(newSwim);

            Cycling newCycle = new Cycling();
            newCycle.SetDate("07/14/2023");
            newCycle.SetSpeed(GetRandomNumber(1,10));
            newCycle.SetLengthInMin(GetRandomNumber(10,100));

            _activities.Add(newCycle);

            creatorCount++;
        }
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

        int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max) + 1;
        }
    }
}