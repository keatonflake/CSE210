public class Running : Activity
{
    private double _distance;

    public double GetDistance()
    {
        return _distance;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
  
    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
    public override string GetSummary()
    {
        return _date + " " + " Running " + "( " + Math.Round(_lengthInMin, 2) + "min" + " ): Distance " + Math.Round(_distance, 2) + "km " +
        Math.Round(CalculateSpeed(_distance, _lengthInMin),2) + "kph " +  Math.Round(CalculatePace(_distance, _lengthInMin),2) + "min per km";
    }

}