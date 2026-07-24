using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }   
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Get a list of visible words
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        
        if (visibleWords.Count == 0) return; // No visible words to hide

        // Randomly select words to hide
        int countToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < countToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Ensure we don't pick the same word twice in one round
        }
    }

    public string GetDisplayText()
    {
        // Build the display text from the words
        List<string> wordDisplays = new List<string>();
        foreach (Word word in _words)
        {
            wordDisplays.Add(word.GetDisplayText());
        }
        string textDisplay = string.Join(" ", wordDisplays);
        return $"{_reference.GetDisplayText()} {textDisplay}";
    }


    public bool IsCompletelyHidden()
    {
        // Check if all words are hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // Found a visible word
            }
        }
        return true; // All words are hidden
    }
    
}
    