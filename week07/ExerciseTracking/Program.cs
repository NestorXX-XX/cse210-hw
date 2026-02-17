using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>()
        {
            new Running("03 Feb 2026", 30, 5),
            new Cycling("04 Feb 2026", 60, 5),
            new Swimming("03 Feb 2026", 20, 30)
        };

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.getSummary());
        }
    }
}