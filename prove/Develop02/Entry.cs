
// A code template for the category of things known as Entry. 
// Represents a single journal entry.
public class Entry
{

    public string _date;
    public string _promptText;
    public string _entryText;
    // A method that display an entries
    public void Display()
    {    
       Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
       Console.WriteLine(_entryText);
       Console.WriteLine("");  
    }

}