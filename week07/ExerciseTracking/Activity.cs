using System;

public abstract class Activity
{
    private string _date;
    private double _lengthInMinutes;

    public Activity(string date, double lengthInMinutes)
    {
        _date = date;
        
        _lengthInMinutes = lengthInMinutes;
    }

    protected double GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    protected string GetDate()
    {
        return _date;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthInMinutes} min) - " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}