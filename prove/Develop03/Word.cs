using System;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = true;
    }

    public void HideWord()
    {
        _hidden = false;
        string replaceText = "";

        for (int i = 0; i < _word.Length; i++)
        {
            replaceText += '_';
        }
        _word = replaceText;
    }

    public bool Hidden()
    {
        return !_hidden;
    }

    public bool ShowWord()
    {
        return _hidden;
    }

    public string GetWord()
    {
        return _word;
    }
}