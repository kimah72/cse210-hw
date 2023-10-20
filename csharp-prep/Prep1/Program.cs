// system package
using System;

// shell that contains everything in the program
class Program
{
    // main function tells it where to start. Main is the place!
    // static = doesn't belong to an instance of a class. It can be run directly
    // void = tells us what it's going to return when it's done (nothing)
    // Main = is the name of the function
    // () states when it starts that it can receive perameters. It can receive an array of strings called args
    static void Main(string[] args)
    {
        // Within the body of these curly braces we can write the code that we want to be run
        // Everything will reside here as we start writing our code.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}