using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _list = new List<Shape>()
        {
            new Square(10, "Red"),
            new Rectangle(10, 10 , "Green"),
            new Circle(2, "Blue")
        };

        foreach (Shape e in _list)
        {
            Console.WriteLine(e.GetColor());
            Console.WriteLine(e.GetArea());
        }
    }
}