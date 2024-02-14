using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _reference = new Reference("Proverbs", 3, 5);
        
        Scripture _scripture = new Scripture();
        Console.WriteLine(_scripture.GetRenderedText(_reference));

        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
        Console.ReadLine();
    }
}