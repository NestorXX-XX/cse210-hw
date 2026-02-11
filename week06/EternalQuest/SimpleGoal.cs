using System.Reflection.Metadata.Ecma335;

class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) 
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }
    private bool _isComplete = false;

    public override int RecordEvent()
    {
        if (IsComplete() == true)
        {
            return 0;
        }
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }




}