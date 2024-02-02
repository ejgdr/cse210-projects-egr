using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // Variable to compare options from the user
    public static int _option;

    // Variables to call the other classes and help out the Menu
    public static Journal _journal = new Journal();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        SelectFromMenu();
    }

    public static void SelectFromMenu()
    {
        while (_option != 5)
        {
            // Additional feature to avoid the program to crash
            try
            {
                DisplayMenu();
                _option = int.Parse(Console.ReadLine());
                if (_option == 1)
                {
                    _journal.AddJournalEntry();
                }
                else if (_option == 2)
                {
                    _journal.DisplayJournal();
                }
                else if (_option == 3)
                {
                    // Additional feature, if the entered file name doesn't exist
                    // it shows the names of those .txt files saved in memory. Also
                    // gives you a message if you try to load without having any
                    // files in memory
                    _journal.LoadData();
                }
                else if (_option == 4)
                {
                    // Additional feature, appends the info to existing file, whether
                    // loads first or not.
                    _journal.SaveData();
                }
                // Additional feature, to avoid crashing the program for wrong input
                else if (_option == 5)
                {
                    Console.WriteLine("See you later!");
                }
                else
                {
                    Console.WriteLine("Wrong input. Please introduce a number according to the menu");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Try Again! Input is probably not a digit: {e.Message}");

            }
        }
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
    }
}