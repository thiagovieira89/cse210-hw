public class Word
{
    private string _text;
    //private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}