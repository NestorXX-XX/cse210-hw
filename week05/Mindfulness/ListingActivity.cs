class ListingActivity : Activity
{
    private int _count = 0;

    private List<int> _promptAlreadyChooseListing = new List<int>();

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?", 
        "Who are some of your personal heroes?"
    };
    public ListingActivity(List<int> promptAlreadyChooseListing)
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your" + 
        "life by having you list as many things as you can in a certain area.";
        _promptAlreadyChooseListing = promptAlreadyChooseListing;
    }

    public List<int> Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        int indexPrompt = -1; // Value not possible
        if (_promptAlreadyChooseListing.Count != 4) {
        do {
        indexPrompt = Random.Shared.Next(_prompts.Count);
        } while (_promptAlreadyChooseListing.Contains(indexPrompt));
        _promptAlreadyChooseListing.Add(indexPrompt);
        }
        else
        {
            indexPrompt = Random.Shared.Next(_prompts.Count);
        }
        Console.WriteLine($" --- {_prompts[indexPrompt]} --- ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);
        while (futureTime > currentTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
        Thread.Sleep(4500);
        Console.Clear();
        return _promptAlreadyChooseListing;
    }
}