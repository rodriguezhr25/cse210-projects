// CheckList goal class
// The responsability of holding data about checkList goals

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted > 0 && _amountCompleted == _target)
        {
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }
    public override bool Iscomplete()
    {

        if (_amountCompleted > 0 && _amountCompleted == _target)
        {
            return true;
        }
        return false;
    }
    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({GetDescription()}) --- Currently completed: {_amountCompleted}/{_target} ";
    }
    public override string GetStringRepresentation()
    {
        return "";

    }

}