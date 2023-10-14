using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Random Random = new Random();
    public string[] _prompts = 
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
    public void WriteEntry()
    {
        Entry entry = new Entry();
        string randomPrompt = _prompts[Random.Next(_prompts.Length)];
        Console.WriteLine("Use this : " + randomPrompt);
        entry._prompt = randomPrompt;
        Console.Write("Your Entry: ");
        string response = Console.ReadLine();
        entry._response = response;
        _entries.Add(entry);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.EntryDisplay();
        }
    }
    public void LoadJournal()
    {
        _entries.Clear();
        Console.Write("Enter the file path to load entries: ");
        string fileName = Console.ReadLine();
    }
    public void SaveJournal()
    {

        Console.Write("Enter the file path to save entries to: ");
        string saveFilePath = Console.ReadLine();
    //     using (StreamWriter outputFile = new StreamWriter(fileName))
    //     {
    //         foreach (Entry line in _entries)
    //         {
    //             outputFile.WriteLine($"{line._date} {line._prompt} {line._response}");
    //         }
    //     }
    }
    public void Quit()
    {
        Console.WriteLine("Goodbye!");
        Console.WriteLine();
        Environment.Exit(0);
    }
}