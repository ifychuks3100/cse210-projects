using System;


public class Entry
{
   public (string, string) Display()
    {
        PromptGenerator prompt = new PromptGenerator();
        string randomPrompt = prompt.GetRandomPrompt();
        string response = Console.ReadLine();
        return (response, randomPrompt);

       
    }
    
}