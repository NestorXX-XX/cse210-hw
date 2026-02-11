using System.Reflection.Metadata.Ecma335;

class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points}s";
    }




}