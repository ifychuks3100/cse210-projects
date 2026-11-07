// I asked for a mood in the Entry class and i saved it in the Journal class.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Hello World! This is the Journal Project.");


            Console.WriteLine("""
            Please select one of the following choices:
            1. Write
            2. Display
            3. Load
            4. Save
            5. Quit
            """);

        
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            

        
            if (choice == "1")
            {
            
                _journal.AddEntries();
            }

            else if (choice == "2")
            {
                _journal.DisplayAll();
            }
            
            else if (choice == "3")
            {
                Console.WriteLine();
                Console.Write("Enter file name:");
                string filename = Console.ReadLine();
                _journal.LoadFromFile(filename);
            }

            else if (choice == "4")
            {
                Console.WriteLine();
                Console.Write("Enter file name:");
                string filename = Console.ReadLine();
                _journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please select a valid option.");
                Console.WriteLine();
            }
        }
        
        
    

    
    }
}