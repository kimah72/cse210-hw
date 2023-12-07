class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    public override double GetPace()
    {
        return _durationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min/km";
    }
}