using System.Runtime.CompilerServices;
using System.IO; 

class GoalManager
{
    public GoalManager() {}
    private List<Goal> _goals = new List<Goal>();

    private int _score = 0;


    public int Start()
    {
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        return choice;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalsNames()
    {
        Console.WriteLine("The type of goals are: ");
        int count = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{count}. {g.GetShortName()}");
            count += 1;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("What is the of your goal?: ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
        }
        else if (choice == 2)
        {
             _goals.Add(new EternalGoal(shortName, description, points));
        }
        else
        {
             _goals.Add(new SimpleGoal(shortName, description, points));
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        int count = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{count}. {g.GetDetailsString()}");
            count += 1;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("What goal did you accomplish?: ");
        int choice = int.Parse(Console.ReadLine());

        int points = _goals[choice-1].RecordEvent();
        _score += points;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        // First line is the score
        _score = int.Parse(lines[0]);

        // Clear existing goals
        _goals.Clear();

        // Start from line 1 (skip score)
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            // Split into type and data
            string[] mainParts = line.Split(":");
            string goalType = mainParts[0];
            string[] data = mainParts[1].Split(",");

            // Create appropriate goal based on type
            if (goalType == "SimpleGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                bool isComplete = bool.Parse(data[3]);

                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int timesCompleted = int.Parse(data[3]);
                int targetCount = int.Parse(data[4]);
                int bonus = int.Parse(data[5]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount, bonus, timesCompleted);
                _goals.Add(goal);
            }
        }
    }

}