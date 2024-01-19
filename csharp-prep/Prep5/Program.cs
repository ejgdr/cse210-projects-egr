using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string userName, int sqrNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrNumber}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string namePrompt = PromptUserName();
        int numberPrompt = PromptUserNumber();
        int squaredNumber = SquareNumber(numberPrompt);
        DisplayResult(namePrompt, squaredNumber);
    }
}