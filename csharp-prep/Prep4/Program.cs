using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number =  1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        // Remove the last number of the list that is a 0
        numbers.Remove(0);

        // Add elements of the list
        int sum = 0;
        foreach (int numb in numbers)
        {
            sum += numb;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average using double, with decimal I get more decimal positions
        double count = numbers.Count();
        double average = sum / count;

        Console.WriteLine($"The average is: {average}");

        // Finding the max or largest number
        int max = 0;
        foreach (int numb in numbers)
        {
            if (numb > max)
            {
                max = numb;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Finding the smallest of the positive numbers
        int min = 0;
        foreach (int numb in numbers)
        {
            if (numb > 0 && numb < max)
            {
                min = numb;
            }
        }
        Console.WriteLine($"The smallest positive number is: {min}");

        // Sorting the list
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int numb in numbers)
        {
            Console.WriteLine(numb);
        }

    }
}