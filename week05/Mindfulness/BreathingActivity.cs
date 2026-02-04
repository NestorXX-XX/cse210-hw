class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through" + 
        "breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        int numberOfBreaths = _duration / 7;
        for (int j = 0; j < numberOfBreaths; j++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(4);
            Console.WriteLine("\n");
        }
        DisplayEndingMessage();
        Thread.Sleep(4500);
        Console.Clear();

    }
}