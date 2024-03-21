using System.Dynamic;
using System.Linq.Expressions;
using System;

public class Scriptures
{
    private Reference _reference;
    private List<Word> _words;

    public Scriptures(Reference Reference, string text)
    {
        _reference = Reference;
        _words = NewWordList(text);    

    }
    private List<Word> NewWordList(string text)
    {
        List<Word> wordList = new List<Word>();

        string[] words = text.Split(new char [] {' '},StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            wordList.Add(newWord);
        }
        return wordList;
    }
    public void HideRandomWords(int numberToHide)
    {   
        
    }

    public string GetDisplayText()
    {
        return $"{_reference} : {_words}";
    }
    public bool isCompletelyHidden()
    {
        
    }
}