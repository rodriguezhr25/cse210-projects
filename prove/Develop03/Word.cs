using System.Text.RegularExpressions;
// A code template for the category of things known as Word. 
// Keeps track of a single word and whether it is shown or hidden.

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

  
    public void Hide(){

        _isHidden = true;

    }
    public void Show(){

        _isHidden = false;

    }
    public bool IsHidden(){

        return _isHidden;

    }
    public string GetDisplayText(){
        
        if(_isHidden){
            return Regex.Replace(_text, "[^.]","_");
        }
        return _text;
    }
}