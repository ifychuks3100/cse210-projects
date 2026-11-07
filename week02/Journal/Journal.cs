using System;
using System.Collections.Generic;
using System.IO; 

public class Journal
{

    List<string> _promptEntries = new List<string>();
    List<string> _journalEntries = new List<string>();
    List<string> _dateEntries = new List<string>();
    List<string> _moodEntries = new List<string>();

    public void AddEntries()
    {
        Entry entry = new Entry();
        (string response, string prompt, string mood) = entry.AddEntry();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _journalEntries.Add(response);
        _promptEntries.Add(prompt);
        _dateEntries.Add(dateText);
        _moodEntries.Add(mood);
        Console.WriteLine();

    }

    public void DisplayAll()
    {
        for (int i = 0; i < _journalEntries.Count; i++)
        {
            Console.WriteLine($"{_dateEntries[i]} Prompt: {_promptEntries[i]}");
            Console.WriteLine($"Response: {_journalEntries[i]}");
            Console.WriteLine($"Mood: {_moodEntries[i]}");
            Console.WriteLine();
        }
        
    }

    public void LoadFromFile(string _filename)
    {
        string filename = _filename;

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string prompt = parts[0];
            string response = parts[1];
            string date = parts[2];
            string mood = parts[3];

            _promptEntries.Add(prompt);
            _journalEntries.Add(response);
            _dateEntries.Add(date);
            _moodEntries.Add(mood);
        }
        Console.WriteLine("File loaded successfully.");
        Console.WriteLine();
    }

    public void SaveToFile(string _filename)
    {
        string filename = _filename;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            for(int i = 0; i < _journalEntries.Count; i++)
            {
                outputFile.WriteLine($"{_promptEntries[i]}| {_journalEntries[i]} | {_dateEntries[i]} | {_moodEntries[i]}");
            }
            
        }
        Console.WriteLine("Journal saved successfully.");
        Console.WriteLine();
    }
}