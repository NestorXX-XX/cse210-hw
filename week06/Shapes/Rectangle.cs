using System.Dynamic;

class Rectangle : Shape
{
    private double _length = 0;
    private double _width = 0;

    public Rectangle(double length, double width, string color) : base(color) 
    {
        _length = length;

        _width = width;
    }

    public override double GetArea()
    {
        return _length = _width * 2;
    }
}