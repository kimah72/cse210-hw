
class Activity
{
    private DateTime _date;
    protected int _durationInMinutes; // I could not get this to work as a private class. So I changed it to protected.

    public Activity(DateTime date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation for activities without specific distance calculation
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation for activities without specific speed calculation
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation for activities without specific pace calculation
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} - {GetType().Name} ({_durationInMinutes} min)";
    }
}