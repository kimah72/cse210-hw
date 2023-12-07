class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Speed: {_speed} kph, Pace: {GetPace():F1} min/km";
    }
}