abstract class Goal
{
    protected string _shortName;

    protected string _description;

    protected int _points;

    public string GetShortName()
    {
        return _shortName;
    }
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[x] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }




}