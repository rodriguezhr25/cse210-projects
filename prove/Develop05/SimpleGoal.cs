// Simple goal class
// The responsability of holding data about simple goals

public class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }
    public override bool Iscomplete()
    {
        return _isComplete;

    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }

    public void SetCompleted(bool iscomplete)
    {
        _isComplete = iscomplete;
    }

}