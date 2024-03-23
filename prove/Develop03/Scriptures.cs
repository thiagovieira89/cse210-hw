using System.Dynamic;
using System.Linq.Expressions;
using System;

public class Scriptures
{
    private Reference _reference;
    private List<Word> _words;

    public Scriptures(Reference reference, string text)
    {
        _reference = reference;
        _words = NewWordList(text);    

    }
    private List<Word> NewWordList(string text)
    {
        List<Word> wordList = new List<Word>();

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            wordList.Add(newWord);
        }
        return wordList;
    }
    public void HideRandomWords(int numberToHide)
    {   
        _words.ElementAt(numberToHide).hide();
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach(Word word in _words){
            if(!word.IsHidden()){
                text = text + " " + word.GetDisplayText();
            }else{
                text = text + " " + "____";
            }
        }
        return $"{_reference.GetDisplayText()} : {text}";
    }
    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden()){
                return false;
            }
        }
        return true;       
    }

    public List<Word> getWords(){
        return _words;
    }
}