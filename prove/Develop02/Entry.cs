using System;

public class Entry
{
    public string _date;
    public string _response;
    public string _prompt;
    public void EntryDisplay()
    {
        Console.WriteLine($"{_date}; {_prompt}");
        Console.WriteLine($"{_response}");
    }
}