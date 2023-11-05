using System;
using System.Threading;

public class Activity
{
    private string _startMessage;
    private string _endMessage;
    private string _name;
    protected int _duration;

    public Activity(string startMessage, string endMessage, string name, int duration)
    {
        _startMessage = startMessage;
        _endMessage = endMessage;
        _name = name;
        _duration = duration;
    }
    // I love arrow functions. I learned this in JS. I'm grateful they can be used in C# as well.
    public string GetStartMessage() => _startMessage;
    public string GetEndMessage() => _endMessage;
    public string GetName() => _name;

    public void GetPause(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - (i.ToString().Length + 1), Console.CursorTop);
            if (i == 0)
            {
                Console.Write(new string(' ', i.ToString().Length + 1)); // Clear the countdown
            }
        }
        Console.WriteLine();
    }

    public void GetAnimation()
    {
        int duration = 4000; // 4 seconds
        string animation = "|/-\\";

        for (int i = 0; i < duration; i += 500)
        {
            Console.Write(animation[i / 500 % animation.Length]);
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
    public void GetTimer(int userDuration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(userDuration);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;

        if (currentTime < futureTime)
        {
            Console.WriteLine($"You have completed {userDuration} seconds of the {_name}");
        }
    }

    public virtual void StartActivity()
    {
        Console.WriteLine();
        Console.WriteLine(GetStartMessage());

        Console.WriteLine();
        Console.Write("Enter the duration (in seconds) for the activity: ");
        if (int.TryParse(Console.ReadLine(), out int userDuration))
        {
            _duration = userDuration;
        }
        else
        {
            Console.WriteLine("Invalid duration input. Using the default duration.");
        }

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        Thread.Sleep(1000);
        GetAnimation();

        StartActivityCore();

        Console.WriteLine();
        Console.WriteLine("--- You have finished the exercise. ---");
        Console.WriteLine();
        GetAnimation();
        GetTimer(userDuration);
        Console.WriteLine();
        Console.WriteLine(GetEndMessage());
        Thread.Sleep(3000);
    }

    protected virtual void StartActivityCore()
    {
        // This method can be overridden by derived classes
    }
}