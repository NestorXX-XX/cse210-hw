class Running : Activity
{
    public Running(string date, int length, int distance)
    {
        _name = "Running";
        _date = date;
        _length = length;
        _distance = distance;
    }
    private int _distance = 0;

    public override double getDistance()
    {
        return _distance;
    }

    public override double getPace()
    {
        return (double)_length / _distance;
    }

    public override double getSpeed()
    {
       return (double)_distance / _length * 60;
    }
}