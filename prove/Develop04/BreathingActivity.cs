public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Welcome to the Breathing Activity!", "Remember to Breathe In and Out when life is stressful.", "Breathing Activity", 0)
    {
    }

    protected override void StartActivityCore()
    {
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine();
        Thread.Sleep(3000); // Initial pause for 3 seconds

        while (_duration > 0)
        {
            
            Console.Write("Breathe in... ");
            GetPause(3); // Pause for 3 seconds
            _duration -= 3;
            if (_duration <= 0) break; // Check if the duration has been reached

            Console.Write("Now breathe out... ");
            GetPause(5); // Pause for 5 seconds
            _duration -= 3;
        }
        Console.WriteLine();
    }
}