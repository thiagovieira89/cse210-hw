public class Word
{
    private string _text;
    private bool _isHidden {get; set;}

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public string GetDisplayText()
    {
        return _text;
    }

    public bool IsHidden (){
        return _isHidden;
    }

    public void SetIsHidden(bool isHidden){
        this._isHidden = isHidden;
    } 

    public void show(){
        this._isHidden = false;
    }

    public void hide(){
        this._isHidden = true;
    }
}