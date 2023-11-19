public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _completed;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _points = 0;
        _completed = false;
    }
    // this is for the GoalManager to use since it is not part of the subclass
    public string Name => _name;

    public string Description => _description;

    public int Points => _points;

    public bool Completed => _completed;

    // subclass modifiers
    public abstract void RecordEvent();

    public virtual string DisplayGoal()
    {
        return $"[{(_completed ? 'X' : ' ')}] {_name} ({_description})";
    }
    public int RecordEventAndGetPoints()
    {
        int pointsAdded = 0;

        // Perform the common event recording logic
        RecordEvent();

        // Get the points added
        pointsAdded = Points - pointsAdded;

        return pointsAdded;
    }
    public void AddPoints(int amount)
    {
        _points += amount;
    }

    public void SetCompleted()
    {
        _completed = true;
    }

    public abstract bool IsComplete();
}