using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());

            int attempts = 0;

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != magicNumber)
            {
                attempts += 1;

                if (guess > magicNumber) 
                {
                    Console.WriteLine("Lower"); 
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!"); 
                }
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"You guessed in {attempts} attempts");
            Console.Write("Would you like to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }        
    }
}