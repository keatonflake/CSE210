class Checklist : Goal
{   
    public Checklist(){
    }

    public override void GetGoalInfo(){
         Console.WriteLine("What is the Name of your goal?: ");
        _name = Console.ReadLine();
        Console.WriteLine("What is the description of your goal?: ");
        _description = Console.ReadLine();
        Console.WriteLine("Enter the whole number value for the number of points this goal is worth \n (for example type 20): ");
        _pointValue = Int32.Parse(Console.ReadLine());
        Console.WriteLine("What is the number of times this goal needs to be accomplished to recieve a bonus?: ");
        _neededTimes = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of bonus points that will be given for reaching the goal");
        _bonusPoints = Int32.Parse(Console.ReadLine());
    }

    public void SetCompletedTimes()
    {
        _completedTimes += 1;
    }

    public override int CheckForCompletion()
    {
        Console.WriteLine(_completedTimes + "/" + _neededTimes);

        if (_neededTimes == _completedTimes)
        {
            Console.WriteLine("Goal completed!!! Bonus points applied");
            SetCheck(false);
            return _bonusPoints;
        }
        else
        {
            Console.WriteLine("Only " + (_neededTimes - _completedTimes) + " to go!!");
            Console.WriteLine();
            return 0;
        }
    }
}