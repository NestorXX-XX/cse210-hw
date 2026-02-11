using System.Reflection.Metadata.Ecma335;

class ChecklistGoal : Goal
{
    public ChecklistGoal(string shortName, string description, int points, 
    int target, int bonus)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _bonus = bonus;
        _target = target;
    }
    public ChecklistGoal(string shortName, string description, int points, 
    int target, int bonus, int amountCompleted)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }
    private int _amountCompleted = 0;

    private int _target = 0;

    private int _bonus = 0;

    public override int RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            return _points;
        }
        return _points + _bonus;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_bonus},{_target},{IsComplete()}";
    }

     public override string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[x] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
    }





}