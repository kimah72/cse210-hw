using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // We do not use ; that are defining the body of a function only the statements in the function.
    static void Main(string[] args)
    {
        // In c#, to print, or write something as output to the cosole you use
        // Console.WriteLine("Hello World");

        // To get input from the user use the Console.ReadLine() function
        // Console.Write("What is your favorite color? ");
        // string color = Console.ReadLine();

        // {} braces define the body of an if stant of a function.
        // if (x > y)
        // {
        //   Console.WriteLine("greater");
        // }

        // Statements end in semicolons ;
        
        // String Interpolation - if you would like to use a variable inside an string, you start the string with a $
        // string school = "BYU-Idaho";
        // Console.WriteLine($"I am studying at {school});
        Console.WriteLine("I'm just trying to figure this out");
        Console.WriteLine("This is just how you write anything");
        // Variables are a specific type
        // when first declaring an int you must state it before but once it has been declared, it recognizes the value.
        int number = 5;
        number = 8;
        number = number + 3;
        Console.WriteLine(number);
        // one statement per line seperated by a ;

        // when deffining an if statement, it does not need a ; but only within the body.

        if (number > 3)
        {
            Console.WriteLine("");
            Console.WriteLine("It is writing this line becuase the number was greater than 3.");
            // This is a blank line. It is used for aethetics.
            Console.WriteLine("");
        }
        // Input/Output
        // This will write the line and prompt the line below.
        Console.WriteLine("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine(color);
        // This way will write the line and ask for the prompt on the same line.
        Console.Write("What is your favorite color? ");
        string color2 = Console.ReadLine();
        // Interpolation can be written concatonated like ($"Hi" + {name}) or
        Console.WriteLine($"Your 2nd favorite color is {color2}.");

        // This is a review of Prep 2 to understand the basic functions of if, else and else if statements.
        int x = 22;
        int y = 10;
        if (x > y)
        {
            Console.WriteLine("greater than");
        }
        // if you put a block of code inside another, it should be indented as follows:
        int z = 2;
        if (x > y)
        {
            if (x > z)
            {
            Console.WriteLine("greater than both");
            }
        }
        // Else and Else if
        if (x > y)
        {
            Console.WriteLine("greater than");
        }
        else
        {
            Console.WriteLine("less than");
        }
        // the else if condition also defines its body in the same fashion
        if (x > y)
        {
            Console.WriteLine("greater than y");
        }
        else if (x > z)
        {
            Console.WriteLine("greater than z");
        }
        else
        {
            Console.WriteLine("less than both");
        }
        // Operators == is used to check if two variable are equal
        // != is not equal, >= greater than or equal, <= less than of equal and so forth
        string name = "John";
        if (name == "John")
        {
            Console.WriteLine("");
            Console.WriteLine("The name is John");
            Console.WriteLine("");
        }
        // And, Or, and Not Operators. and = &&, or = ||, not = ! and can be combined with other expressions

        // This following is just logic expression but is written to explain the concepts of Operators
        // if (name == "Peter" || name == "James" || name == "John")
        // {
        //     Console.WriteLine("This is a biblical name.");
        // }
        //
        // if (firstName == "Brigham" && lastName == "Young")
        // {
        //     Console.WriteLine("Welcome Brother Brigham!");
        // }
        //
        // if (!(name == "Peter" || name == "James" || name == "John"))
        // {
        //     Console.WriteLine("This is not one of those three");
        // }

        // Variables and Types

        // Converting Types = you can create an integer from the digits stored in a string using the int.Parse() function.
        string valueInText = "42";
        int number2 = int.Parse(valueInText);
        Console.WriteLine("");
        // This is important if the value comes from the user via a Console.ReadLine() statement which always returns a string.
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number3 = int.Parse(userInput);
        Console.WriteLine("");
        // Numbers to Strings = similarly an iteger can be converted to a string using the .ToString() function
        int number4 = 42;
        string textVersion = number4.ToString();
        Console.WriteLine("");

        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();

        int a = int.Parse(valueFromUser);
        int b = 2;
        int c = 5;

        if ((a < b || a < c) && b < c)
        {
            Console.WriteLine("Greater");
        }
        else if (a < b)
        {
            Console.WriteLine("Less");
        }

        // Prep 3 Loops = while, do-while, for, foreach

        // While Loops
        string response = "yes";
        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }

        // Do-While Loops
        string response2;
        do
        {
            Console.Write("Do you want to continue? ");
            response2 = Console.ReadLine();

        } while (response2 == "yes");

        // For Loops
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        for (int j = 2; j <= 20; j = j + 2)
        {
            Console.WriteLine(j);
        }
        // Foreach Loops = It is important to remember that the iterator variable must have its type define, like any other variable.

        // foreach (string color in colors)
        // {
        //   Console.WriteLine(color);
        // }

        // Random Numbers

        Random randomGenerator = new Random();
        int number5 = randomGenerator.Next(1, 11);

        // Prep 4 - Lists
        // To create a new list of integers you specify int inside angle brackets <> directly following the name of the data structure: List<int> and if you want to have a list of strings, you would use: List<strings> as shown below.

        List<int> numbers = new List<int>();
        
        // Notice the extra parentheses () at the end, that we use any time we create a new object.

        // What is "new" and why do we need it? It turns out that List is a class or custom data type and we are creating a new object or instance of that class. This is actually the complete focus of this course.

        // Just remember to include new before you start using a list

        // Adding Items to the List - To add items to the list, you use the .Add() method

        List<string> words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        Console.WriteLine(words.Count);

        // Iterating through a List - the easier is the foreach loop

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // You can also access the items by their index

        for (int k = 0; k < words.Count; k++)
        {
            Console.WriteLine(words[k]);
        }        
    }
}