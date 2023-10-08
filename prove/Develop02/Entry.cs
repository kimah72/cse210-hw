using System.IO;

public class Entry
{
    public string _date;
    public string _response;
    public string _prompt;
    public void EntryDetails()
    {
        Console.WriteLine($"{_date}; {_prompt}");
        Console.WriteLine($"{_response}");
    }
    public string GetRandomPrompt()
    {
        var random = new Random();
        var prompts = new List<string>
        {
            "Describe something you learned today.",
            "What made you happy today?",
            "Write about a challenge you faced.",
            "Name three things you are grateful for.",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What are your top three goals for this month?",
            "How do you cope with stress?"
        };
        int index = random.Next(prompts.Count);
        _prompt = prompts[index];
        return _prompt;
    }
    public string DisplayDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToString("yyyy-MM-dd HH:mm:ss");
        return dateText;
    }
}