class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        StartBreathingActivity();
                        break;
                    case 2:
                        StartReflectionActivity();
                        break;
                    case 3:
                        StartListingActivity();
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void StartBreathingActivity()
    {
        BreathingActivity activity = new BreathingActivity();
        activity.StartActivity();
    }

    static void StartReflectionActivity()
    {
        ReflectionActivity activity2 = new ReflectionActivity();
        activity2.StartActivity();
    }

    static void StartListingActivity()
    {
        ListingActivity activity3 = new ListingActivity();
        activity3.StartActivity();
    }
}