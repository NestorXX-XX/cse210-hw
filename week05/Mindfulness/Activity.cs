class Activity
{
    protected string _name = "";
    protected string _description = "";

    protected int _duration = 0;

    public Activity() {}

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity. \n");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! \n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerCharacters = new List<string> {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        for (int i = 0; i <= seconds; i++)
        {
            if (i == 8) {i = 0; seconds -= 7;}
            Console.Write(spinnerCharacters[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            int digits = i.ToString().Length;
            Console.Write(new string('\b', digits) + new string(' ', digits) + new string('\b', digits));
        }
    }


}