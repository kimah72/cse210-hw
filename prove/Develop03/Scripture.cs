  using System;
  using System.Collections.Generic;
  using System.Linq;
  public class Scripture
  {
    private Reference _reference;
    private List<Word> _words = new List<Word>();

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
            var countWord = _words.Count();
            Random r = new Random();
            int rIndex = r.Next(0, countWord);
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