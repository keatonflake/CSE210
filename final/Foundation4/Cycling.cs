public class Cycling : Activity
{
    private double _speed;

    public double GetSpeed()
    {
        return _speed;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    private double CalculateDistance()
    {
        return _speed * _lengthInMin;
    }
    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
        public override string GetSummary()
    {
        return _date + " " + " Cycling " + "( " + Math.Round(_lengthInMin, 2) + "min" + " ): Distance " + Math.Round(CalculateDistance(), 2) + "km " +
         Math.Round(CalculateSpeed(CalculateDistance(), _lengthInMin),2) + "kph " +  Math.Round(CalculatePace(CalculateDistance(), _lengthInMin),2) + "min per km";
    }
}