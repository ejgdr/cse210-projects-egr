using System;

class Program
{
    static void Main(string[] args)
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
            if (guess > magicNumber) 
            {
                Console.WriteLine("Lower");
                attempts += 1;
            }
            else
            {
                Console.WriteLine("Higher");
                attempts += 1;
            }
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("You guessed it!"); 
        Console.WriteLine($"You guessed in {attempts} attempts");        
    }
}