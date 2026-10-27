using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter Garde percentage: ");
        int gradeNumber = int.Parse(Console.ReadLine());

        string letter;

        if (gradeNumber >= 90)
        {
            letter = "A";
        }

        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }

        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        string sign;

        int calculatedSign = gradeNumber % 10;

        if (calculatedSign >= 7)
        {
            sign = "+";
        }

        else if (calculatedSign < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (gradeNumber >= 93 || gradeNumber < 60)
        {
            sign = "";
        }

        if (gradeNumber >= 70)
        {
            Console.WriteLine($"Congratulation you passed with grade: {letter}{sign}.");
        }

        else
        {
            Console.WriteLine($"I am sorry you tried your best with grade: {letter}{sign}.");
        }
    }
}