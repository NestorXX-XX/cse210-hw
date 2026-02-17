abstract class Activity
{
    protected string _name;
    protected string _date;
    protected int _length;

    public abstract double getDistance();

    public abstract double getSpeed();

    public abstract double getPace();

    public virtual string getSummary()
    {
        return $"{_date} {_name} ({_length} minutes) - Distance {getDistance()} km, Speed {getSpeed()} km/h, Pace {getPace()} min per km";
    }
}