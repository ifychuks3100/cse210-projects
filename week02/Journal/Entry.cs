using System;
using System.Collections.Generic;
using System.IO; 

public class Entry
{
   public (string, string, string, string) AddEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string randomPrompt = prompt.GetRandomPrompt();
        string response = Console.ReadLine();
        Console.WriteLine("What mood are you in today? (happy, sad, angry, etc.)");
        string mood = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return (response, randomPrompt, dateText, mood);

       
    }
    
}