using System;
using System.ComponentModel.Design;

// In order to exceed the requirements what I did was to have a count of the prompts already
// used in the session so they do not get repeated
class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        List<int> _promptAlreadyChooseListing = new List<int>();
        do {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");
        selection = int.Parse(Console.ReadLine());
        if (selection == 1)
            {
                new BreathingActivity().Run();
            }
        else if (selection == 2)
            {
                new ReflectingActivity().Run();
            }
        else if (selection == 3)
            {
                _promptAlreadyChooseListing = new ListingActivity(_promptAlreadyChooseListing).Run();
            }
        } while (selection != 4);
    }
}