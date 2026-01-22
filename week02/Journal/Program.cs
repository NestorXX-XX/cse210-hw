using System;
// What I did to exceed the requierements is to create a new method in the Entry class, so later on in the Journal class where 
// I save the entry in a file I just class the method to get the format in comma separated values format.
class Program
{
    static void Main(string[] args)
    {
         // Initialize journal and Prompt generator
        Journal journal = new Journal();
        int choice = 0;
        PromptGenerator promptGenerator = new PromptGenerator();
        Console.WriteLine("Welcome to the Journal Program!");
        

        do {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        choice = int.Parse(Console.ReadLine());
        
        if (choice == 1)
        {
            // Get Random Prompt
            string promptChoice = promptGenerator.GetRandomPrompt();
            Console.WriteLine(promptChoice);
            string response = Console.ReadLine();

            // Get date
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            journal.AddEntry(new Entry(dateText, promptChoice, response));
        }
        else if (choice == 2)
        {
            journal.DisplayAll();
        }
        else if (choice == 3)
        {
            Console.Write("What is the filename?: ");
            string filename = Console.ReadLine();

            journal.LoadFromFile(filename);
        }
        else if (choice == 4)
        {
            Console.Write("What is the filename?: ");
            string filename = Console.ReadLine();

            journal.SaveToFile(filename);
        }
    } while (choice != 5);
    }
}