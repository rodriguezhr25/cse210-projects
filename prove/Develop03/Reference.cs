// A code template for the category of things known as Reference. 
// Keeps track of the book, chapter, and verse information.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int starVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = starVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(){

        string referenceText = "";

        if(_endVerse > 0){
            referenceText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }else{
            referenceText = $"{_book} {_chapter}:{_verse}";
        }

        return referenceText;
    }


}