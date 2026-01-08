using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        int user_number;
        int number_of_guesses = 0;
        do
        {
            Console.Write("What is your guess? ");
            user_number = int.Parse(Console.ReadLine());
            number_of_guesses++;

            if (user_number > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (user_number < magic_number)
            {
                Console.WriteLine("Higher");
            }
        } while (magic_number != user_number);

        Console.WriteLine($"You guessed it! (It took you {number_of_guesses} guesses)");


    }
}