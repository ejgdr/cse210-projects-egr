using System.ComponentModel.Design;

public class Menu
{
    // Display the menus on the screen, the General and for New goals
    private string _option;
    private string _selection;
    private GoalManager _manager = new GoalManager();
    public Menu(){}
    public void DisplayGeneralMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    public void DisplayNewGoalMenu()
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Which type of goal wouold you like to create? ");
    }
    public void DisplayScore()
    {
        int cumScore = _manager.CurrentScore();
        Console.WriteLine($"You have {cumScore} points\n");
    }
    public void SelectFromGeneralMenu()
    {
        Console.Clear();
        while (_option != "6")
        {
            // Additional feature to avoid the program to crash
            try
            {
                DisplayScore();
                DisplayGeneralMenu();
                _option = Console.ReadLine();
                if (_option == "1")
                {
                    DisplayNewGoalMenu();
                    _selection = Console.ReadLine();
                    _manager.CreateGoal(_selection);
                }
                else if (_option == "2")
                {
                    _manager.DisplayGoals();
                }
                else if (_option == "3")
                {
                    _manager.SaveGoals();
                }
                else if (_option == "4")
                {
                    _manager.LoadGoals();   
                }
                else if (_option == "5")
                {
                    Console.WriteLine("The goals are:");
                    _manager.DisplayGoals();
                    _manager.RecordGoals();
                }
                // Additional feature, to avoid crashing the program for wrong input
                else if (_option == "6")
                {
                    Console.WriteLine("See you later!\n");
                }
                else
                {
                    Console.WriteLine("Wrong input. Please introduce a number according to the menu\n");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Try Again! Input is probably not a digit from the menu: {e.Message}\n");

            }
        }
    }

}