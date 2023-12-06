using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Create Addresses
        Address address1 = new Address("123 Main St", "Sprinville", "MO", "USA");
        Address address2 = new Address("456 Oak St", "Montreal", "Quebec", "Canada");

        // Create Events
        Lecture lectureEvent = new Lecture("Ted Talk", "Explore Programming with Class", DateTime.Now.AddDays(30), new TimeSpan(14, 0, 0), address1, "John Doe", 100);
        Reception receptionEvent = new Reception("Networking Mixer", "Meet and Greet", DateTime.Now.AddDays(80), new TimeSpan(18, 30, 0), address2, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Luminaria", "Experience a beautiful, winter light show", DateTime.Now.AddDays(60), new TimeSpan(12, 0, 0), address1, "Dress for cold weather!");

        // Display marketing messages
        Console.WriteLine("Lecture Event - Standard Details:\n" + lectureEvent.GenerateStandardDetails() + "\n");
        Console.WriteLine("Lecture Event - Full Details:\n" + lectureEvent.GenerateFullDetails() + "\n");
        Console.WriteLine("Lecture Event - Short Description:\n" + lectureEvent.GenerateShortDescription());
        Console.WriteLine();
        Console.WriteLine("Reception Event - Standard Details:\n" + receptionEvent.GenerateStandardDetails() + "\n");
        Console.WriteLine("Reception Event - Full Details:\n" + receptionEvent.GenerateFullDetails() + "\n");
        Console.WriteLine("Reception Event - Short Descripotion:\n" + receptionEvent.GenerateShortDescription());
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering Event - Standard Details:\n" + outdoorEvent.GenerateStandardDetails() + "\n");
        Console.WriteLine("Outdoor Gathering Event - Full Details:\n" + outdoorEvent.GenerateFullDetails() + "\n");
        Console.WriteLine("Outdoor Gathering Event - Short Descripotion:\n" + outdoorEvent.GenerateShortDescription());
    }
}