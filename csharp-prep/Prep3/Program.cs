using System;

class Program
{
    static void Main(string[] args)
    {
        // Start by asking the user for the magic number.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        //offsets the value of the integer
        int guess = -1;
        // making the count start at zero
        int guessCount = 0;

        while (guess != magicNumber)
        {
            //Ask the user for a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            // this is the counter for how many guesses it will take to find the Magic Number
            guessCount++;
            //Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.
            
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the Magic Number!");
            }

        }
        Console.WriteLine($"You made {guessCount} guesses to find the Magic Number.");
    }
}