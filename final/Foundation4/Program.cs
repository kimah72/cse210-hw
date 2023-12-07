using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Running runningActivity = new Running(DateTime.Now, 30, 3.0);
        Cycling cyclingActivity = new Cycling(DateTime.Now.AddDays(-2), 45, 20.0);
        Swimming swimmingActivity = new Swimming(DateTime.Now.AddDays(-5), 40, 20);

        // Put activities in a list
        List<Activity> activities = new List<Activity>
        {
            runningActivity,
            cyclingActivity,
            swimmingActivity
        };

        // Display results
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}