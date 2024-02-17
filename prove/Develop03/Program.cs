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

        _scripture._blockOfScripture = _scripture.GetRenderedText(_reference);

        while (gameOn)
        {
            // Bring the block of scriptures to the screen
            Console.WriteLine(_scripture._blockOfScripture);
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userChoice = Console.ReadLine();
            
            // To stop the program
            if (userChoice.ToLower() == "")
            {
                if (_scripture.IsCompletelyHidden())
                {
                    gameOn = false;
                }
                else
                {
                    _scripture._blockOfScripture = _scripture.HideWords();                
                    gameOn = true;
                }
                
            }
            else if (userChoice.ToLower() == "quit")
            {
                gameOn = false;
            }

            Console.Clear(); 
        }

        
    }
}