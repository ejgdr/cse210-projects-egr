using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate Reference and Scripture to Start
        Reference _reference = new Reference("Proverbs", 3, 5);
        Scripture _scripture = new Scripture();

        // Variables to run program
        string userChoice;
        bool gameOn = true;
        while (gameOn)
        {
            // Bring the block of scriptures to the screen
            Console.WriteLine(_scripture.GetRenderedText(_reference));
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userChoice = Console.ReadLine();
            Console.Clear();

            // To stop the program
            if (userChoice.ToLower() == "quit")
            {
                gameOn = false;
            } 
        }

        
    }
}