public class Lecture : Event
{
    protected string _speaker;

    protected int _maxCapacity;

    public string GetSpeaker()
{
    return _speaker;
}
public void SetSpeaker(string text)
{
    _speaker = text;
}
public int GetMaxCapacity()
{
    return _maxCapacity;
}
public void SetMaxCapacity(int number)
{
    _maxCapacity = number;
}

    public override void GetFullDetails()
    {
        Console.WriteLine("Lecture: ");
        Console.WriteLine("The Speaker is: " + _speaker);
        GetStandardDetails();
    }
    public override void GetShortDescription()
    {
        Console.WriteLine("Lecture: ");
        Console.WriteLine(_title);
        Console.WriteLine(_date);
    }
}