// In order to exceed the requierements what I did was to load the scriptures from a file. And it choosed a random one from there.

using System;
class Program
{
    static void Main(string[] args)
    {
        string scripturesFilename = "scriptures.txt";
        Scripture scripture = new Scripture();
        scripture = scripture.LoadScripture(scripturesFilename);

        string response = "";

        do {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.Write("Press enter to continue or type 'quit' to finish: ");
        response = Console.ReadLine();
        if (response == "" && scripture.isCompletelyHidden() == false)
            {
                scripture.HideRandomWords();

            }
        } while (response == "" && scripture.isCompletelyHidden() == false);
    
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
    }
}