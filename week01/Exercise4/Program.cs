using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.Write("Enter a list of numbers, type 0 when finished: ");
        int number = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
        while (number != 0 )
        {
            numbers.Add(number);

            Console.Write("Enter numbers: ");
            number = int.Parse(Console.ReadLine());

        }

        int sum = 0;
        int larger = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];

            if (numbers[i] > larger)
            {
                larger = numbers[i];
            }
        }

        int average = sum / numbers.Count;

        Console.WriteLine($"The sume is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {larger}");


    }
}