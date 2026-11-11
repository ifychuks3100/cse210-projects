// I allowed user to choose how many words to hide at a time.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture reference
        Reference reference = new Reference("John", 3, 16);

        // Store the scripture text
        string text = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life";

        // Create the scripture object
        Scripture scripture = new Scripture(reference, text);

        // ADDED FEATURE: Difficulty Levels
        
        Console.WriteLine("Choose your difficulty level:");
        Console.WriteLine("1. Easy - Hide 1 word");
        Console.WriteLine("2. Medium - Hide 3 words");
        Console.WriteLine("3. Hard - Hide 5 words");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        int numberToHide = 3;

        if (choice == "1")
        {
            numberToHide = 1;
        }
        else if (choice == "2")
        {
            numberToHide = 3;
        }
        else if (choice == "3")
        {
            numberToHide = 5;
        }
        else
        {
            Console.WriteLine("Invalid choice. Medium difficulty selected.");
        }

        // Display the scripture
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        // Continue until the user quits or all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide words based on the selected difficulty
            scripture.HideRandomWords(numberToHide);

            // Display the updated scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine();
        Console.WriteLine("Thank you for using Scripture Memorizer!");
    }
}