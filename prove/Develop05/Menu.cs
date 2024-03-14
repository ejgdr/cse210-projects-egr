public class Menu
{
    // Display the menus on the screen, the General and for New goals
    private string _option;
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
        Console.Write("Which type of goal would you like to create? ");
    }
    
    public void SelectFromGeneralMenu()
    {
        while (_option != "6")
        {
            // Additional feature to avoid the program to crash
            try
            {
                DisplayGeneralMenu();
                _option = Console.ReadLine();
                if (_option == "1")
                {
                    DisplayNewGoalMenu();
                }
                else if (_option == "2")
                {
                    
                }
                else if (_option == "3")
                {
                    
                }
                else if (_option == "4")
                {
                    
                }
                else if (_option == "5")
                {
                    
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