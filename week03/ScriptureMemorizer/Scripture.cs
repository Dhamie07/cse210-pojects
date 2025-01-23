using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = new ScriptureReference(reference);
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        var random = new Random();
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
        }
    }

    public string GetScriptureText()
    {
        return string.Join(" ", Words.Select(w => w.GetDisplayText()));
    }
}