using System;

class Program 
{
    static void Main(string[] args)
    {
        string book = "Alma";
        int chapter = 32;
        int verseStart = 17;
        int verseEnd = 18;
        string verse1Text = "Yea, there are many who do say: If thou wilt show unto us a sign from heaven, then we shall know of a surety; then we shall believe.";
        string verse2Text = "Now I ask, is this faith? Behold, I say unto you, Nay; for if a man knoweth a thing he hath no cause to believe, for he knoweth it.";

        Scripture scripture = new Scripture(book, chapter, verseStart, verseEnd, verse1Text, verse2Text);

        scripture.GetReference().DisplayReference();
        scripture.GetRenderedText();
        Console.WriteLine("\nHit enter to hide words or type 'quit' to end the program.");

        string response = string.Empty;

        while (response != "quit" && !scripture.CompletelyHidden())
        {
            response = Console.ReadLine();

            if (response == "quit")
                break;

            if (string.IsNullOrWhiteSpace(response))
            {
                for (int i = 0; i < 3 && !scripture.CompletelyHidden(); i++)
                {
                    scripture.HideRandomWord();
                }

                Console.Clear();
                scripture.GetReference().DisplayReference();
                scripture.GetRenderedText();
            }
        }
    }
}
