public class Swimming : Activity
{
    private double _laps;

    public double GetLaps()
    {
        return _laps;
    }
    public void SetLaps(double laps)
    {
        _laps = laps;
    }
    private double CalculateDistance()
    {
        double x = _laps * 50;
        return x / 1000;
    }
     public override string GetSummary()
    {
        return _date + " " + " Swimming " + "( " + _lengthInMin + "min" + " ): Distance " + Math.Round(CalculateDistance(), 2) + "km " +
         Math.Round(CalculateSpeed(CalculateDistance(), _lengthInMin), 2)+ "kph " +  Math.Round(CalculatePace(CalculateDistance(), _lengthInMin), 2) + "min per km";
    }
}