using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Best of luck next time!");
        }


    }
}