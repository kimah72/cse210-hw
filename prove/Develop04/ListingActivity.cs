using System;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private Random _random = new Random();
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes"
    };

    public ListingActivity() : base("Welcome to the Listing Activity!", "Reflect on the good things in your life.", "Listing Activity", 0)
    {
    }

    protected override void StartActivityCore()
    {
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Thread.Sleep(3000); // Initial pause for 3 seconds

        while (_duration > 0)
        {
            string randomPrompt = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {randomPrompt} ---");
            Console.WriteLine();
            Console.Write("You have a few seconds to start thinking about it. ");
            GetPause(5); // Pause for 5 seconds for thinking
            Console.WriteLine();
            Console.WriteLine("Start listing items:");
            Console.WriteLine("(Hit enter without entering to get new prompt)");
            Console.WriteLine();

            List<string> itemsList = new List<string>();

            while (_duration > 0)
            {
                string item = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(item))
                {
                    break;
                }
                itemsList.Add(item);
                _duration -= 2;
            }
            Console.WriteLine();
            Console.WriteLine($"You listed {itemsList.Count} items.");
        }
        Console.WriteLine();
    }
}