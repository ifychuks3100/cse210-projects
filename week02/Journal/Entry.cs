using System;


public class Entry
{
   public (string, string, string) AddEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string randomPrompt = prompt.GetRandomPrompt();
        string response = Console.ReadLine();
        Console.WriteLine("What mood are you in today? (happy, sad, angry, etc.)");
        string mood = Console.ReadLine();
        return (response, randomPrompt, mood);

       
    }
    
}