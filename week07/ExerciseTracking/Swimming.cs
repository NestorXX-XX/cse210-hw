class Swimming : Activity
{
    public Swimming(string date, int length, int swimming_laps)
    {
        _name = "Swimming";
        _date = date;
        _length = length;
        _swimming_laps = swimming_laps;
    }
    private int _swimming_laps = 0;

    public override double getDistance()
    {
        return _swimming_laps * 50.0 / 1000;  // 50.0 forces floating-point division
    }

    public override double getPace()
    {
        return (double)_length / getDistance();  // min per km
    }

    public override double getSpeed()
    {
        return getDistance() / _length * 60;  // km per hour
    }
}