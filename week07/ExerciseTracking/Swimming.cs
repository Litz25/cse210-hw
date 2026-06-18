public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double lengthInMinutes, double laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // 1 lap = 50 meters = 0.03107 miles
        return (_laps * 50 / 1000) * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthInMinutes() / GetDistance();
    }
}