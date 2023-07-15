public class Activity
{
    protected double _lengthInMin;
    protected string _date;

    public double GetLengthInMin()
    {
        return _lengthInMin;
    }
    public void SetLengthInMin(double time)
    {
        _lengthInMin = time;
    }
     public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
          public double CalculateSpeed(double distance, double lengthInMin)
    {
        double x = distance / lengthInMin;
        return x * 60;
    }
    public double CalculatePace( double distance, double lengthInMin)
    {
        return lengthInMin / distance;
    }

    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
    public virtual string GetSummary()
    {
        return " ";
    }
}