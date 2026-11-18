using System;

public class Comment
{
    // Private fields
    private string _commenterName;
    private string _text;

    // Constructor
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    // Display comment details
    public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName}: {_text}");
    }
}