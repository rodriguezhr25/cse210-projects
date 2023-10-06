using System;
using System.Collections.Generic;
using System.Linq;
// A code template for the category of things known as Scripture. 
// Keeps track of both the reference and the text of the scripture. 
//Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

  public  Scripture(Reference reference, string text){
    _reference = reference;
     addToList(text);
  }

  public void HideRandomWords(int numberToHide){

      int c = 0;
     //As a stretch challenge, this method randomly select from only those words that are not already hidden) 
      while(c < numberToHide){
        var random = new Random();
        var wordsHidden = _words.Where(w => w.IsHidden() == false).Count();
        var wordsFiltered = _words.Where(w => w.IsHidden() == false).ToArray();
        int index = random.Next(wordsHidden);
        wordsFiltered[index].Hide();
        c++;
      }
  }

  public string GetDisplayText(){
    string referenceText = _reference.GetDisplayText();
    string scripturetext = String.Join(" ", _words.Select(w =>w.GetDisplayText()));
    string result = referenceText + " " + scripturetext;
    return result;
  }

  public bool IsCompletelyHidden(){
    var wordsHidden = _words.Where(w => w.IsHidden() == true).Count();
    if(wordsHidden == _words.Count()){
      return true;
    }
    return false;
  }

  private void addToList(string text){
     string[] words = text.Split(' ');

     foreach(string w in words){
        _words.Add(new Word(w));
     }
    
  }


}