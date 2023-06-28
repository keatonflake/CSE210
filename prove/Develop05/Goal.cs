class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected int _bonusPoints;
    protected int _completedTimes;
    protected int _neededTimes;
    protected bool _completed = false;
    public Goal()
    {
        _name = "";
        _description = "";
        _pointValue = 0;
    }
    public virtual void GetGoalInfo()
    {
        Console.WriteLine("What is the Name of your goal?: ");
        _name = Console.ReadLine();
        Console.WriteLine("What is the description of your goal?: ");
        _description = Console.ReadLine();
        Console.WriteLine("Enter the whole number value for the number of points this goal is worth \n (for example type 20): ");
        _pointValue = Int32.Parse(Console.ReadLine());
    }

    public void SetCompletedTimes(int completed)
    {
        _completedTimes += completed;
    }
    public int GetCompletedTimes()
    {
        return _completedTimes;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }

    public void SetPointValue(int value)
    {
        _pointValue = value;
    }
    public int GetNeededTimes()
    {
        return _neededTimes;
    }
    public void SetNeededTimes(int needed)
    {
        _neededTimes = needed;
    }
        public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public void SetBonusPoints(int bonus)
    {
        _bonusPoints = bonus;
    }
    public string GetCheck()
    {
        if (_completed)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }
    public void SetCheck(bool completed)
    {
        if (completed)
        {
            _completed = completed;
        }
    }
    public virtual int CheckForCompletion()
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