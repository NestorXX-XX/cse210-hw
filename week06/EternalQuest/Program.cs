ListChangedEventArgsusing System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager _goalManager = new GoalManager();
        int choice = 0;

        while (choice != 6)
        {
            choice = _goalManager.Start();

            if (choice == 1)
            {
                _goalManager.CreateGoal();
            }
            else if (choice == 2)
            {
                _goalManager.ListGoalDetails();
            }
            else if (choice == 3)
            {
                _goalManager.SaveGoals();
            }
            else if (choice == 4)
            {
                _goalManager.LoadGoals();
            }
            else if (choice == 5)
            {
                _goalManager.RecordEvent();  
            }
        }
            



    }
}