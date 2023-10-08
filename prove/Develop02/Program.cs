using System.IO;

class Program
{
    
    static void Main(string[] args)
    {
        string userResponse = "5";
       
        Journal journal = new Journal();
       

        while(true)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to your Journal.");
            Console.WriteLine();
            Console.WriteLine("Please select one of the Menu Options.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            userResponse = Console.ReadLine();
            
            Console.WriteLine();

            if (userResponse == "1")
            {
               journal.AddEntry();     
            }
            else if (userResponse == "2")
            {
                journal.DisplayJournal();
            }
            else if (userResponse == "3")
            {
                journal.LoadJournal();
            }
            else if (userResponse == "4")
            {
                journal.SaveJournal();
            }
            else if (userResponse == "5")
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