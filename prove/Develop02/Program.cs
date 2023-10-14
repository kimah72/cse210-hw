using System.IO;

class Program
{
    static void Main()
    {
        string choice = "5";

        Journal journal = new Journal();

        while(true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal:");
            Console.WriteLine();
            Console.WriteLine("Please select one of the following Menu Options:");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                journal.WriteEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                journal.LoadJournal();
            }
            else if (choice == "4")
            {
                journal.SaveJournal();
            }
            else if (choice == "5")
            {
                journal.Quit();
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a valid option");
            }
        }
    }
}