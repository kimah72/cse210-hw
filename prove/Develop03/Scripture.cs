using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words = new List<Word>();
    private readonly Random _random = new Random(); // Moved the Random object initialization to here

    public Scripture(string book, int chapter, int verseStart, int verseEnd, string verse1Text, string verse2Text)
    {
        _reference = new Reference(book, chapter, verseStart, verseEnd);

        _words.AddRange(verse1Text.Split(" ").Select(word => new Word(word)));
        _words.AddRange(verse2Text.Split(" ").Select(word => new Word(word)));
    }

    public void HideRandomWord()
    {
        bool wordHidden = false;

        do
        {
            int countWord = _words.Count; // Removed unnecessary () from Count
            int rIndex = _random.Next(0, countWord);
            Word word = _words[rIndex];
            if (word.ShowWord())
            {
                word.HideWord();
                wordHidden = true;
            }
        } while (!wordHidden);
    }

    public void GetRenderedText()
    {
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetWord())));
    }

    public bool CompletelyHidden()
    {
        return _words.All(word => !word.ShowWord());
    }

    public Reference GetReference()
    {
        return _reference;
    }
}
