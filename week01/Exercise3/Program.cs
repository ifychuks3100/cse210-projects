using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        
        
        string choice = "yes";
        
        while (choice != "no")
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 101);
            Console.Write("What is the magic number? ");
            int guess = int.Parse(Console.ReadLine());
            int guessTimes = 1;

            
            while (magicNumber != guess)
            {

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessTimes ++;
            }

            Console.WriteLine($"You guessed it after {guessTimes} trail.");
            Console.Write("Do you wish to guess again? yes/no: ");
            choice = Console.ReadLine();

        }





    }
}