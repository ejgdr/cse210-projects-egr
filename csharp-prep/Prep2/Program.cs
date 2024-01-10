using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        int grade = int.Parse(Console.ReadLine());
        int reminder = reminder = grade % 10;
        string letter;

        // Calculation to the letter grade and correspondant sign
        if (grade >= 90)
        {
            if (reminder < 3)
            {
                letter = "A-";
            }    
            else
            {
                letter = "A";
            }    
        }
        else if (grade >= 80)
        {
            if (reminder < 3)
            {
                letter = "B-";
            }
            else if (reminder >= 7)
            {
                letter = "B+";
            }
            else
            {
                letter = "B";
            }
        }
        else if (grade >= 70)
        {
            if (reminder < 3)
            {
                letter = "C-";
            }
            else if (reminder >= 7)
            {
                letter = "C+";
            }
            else
            {
                letter = "C";
            }
        }
        else if (grade >= 60)
        {
            if (reminder < 3)
            {
                letter = "D-";
            }
            else if (reminder >= 7)
            {
                letter = "D+";
            }
            else
            {
                letter = "D";
            }
        }    
        else
        {
            letter = "F";
        }

        // Display results    
        Console.WriteLine($"Your letter grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }    
        else
        {
            Console.WriteLine("Don't give up and you'll get it next time!");
        }            
    }
}