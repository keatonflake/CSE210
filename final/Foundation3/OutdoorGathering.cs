public class OutdoorGathering : Event
{
    protected string _forecast;

    public string GetForecast()
    {
        return _forecast;
    }
    public void SetForecast(string text)
    {
        _forecast = text;
    }
    public override void GetFullDetails()
    {
        Console.WriteLine("Outdoor Gathering: ");
        Console.WriteLine("Forecast: " + _forecast);
        GetStandardDetails();
    }
    public override void GetShortDescription()
    {
        Console.WriteLine("Outdoor Gathering: ");
        Console.WriteLine(_title);
        Console.WriteLine(_date);
    }
}