using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private Random _random = new Random();
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _refectQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Welcome to the Reflection Activity!", "Well done, keep reflecting on your past experiences.", "Reflection Activity", 0)
    {
    }

    protected override void StartActivityCore()
    {
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Thread.Sleep(3000); // Initial pause for 3 seconds

        while (_duration > 0)
        {
            string randomPrompt = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {randomPrompt} ---");
            Console.WriteLine();
            Console.Write("When you have something in mind, press enter to continue.");
            Console.Read();

            foreach (string question in _refectQuestions)
            {   
                Console.WriteLine();
                Console.Write($"{question} ");
                
                if (_duration <= 0)
                {
                    break; // Break the loop if the duration is over
                }
                
                GetPause(3);
                _duration -= 3;
            }
        }
        Console.WriteLine();
    }
}