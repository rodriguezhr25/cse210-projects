using System;
using System.Text.Json;
using System.Text.Json.Serialization;
class Program
{
    static void Main(string[] args)
    {
      //As a stretch challenge, now we are creting a list of scriptures to slect one randomly) 
      //Create list of scriptures
      List<Scripture> scriptureList = new List<Scripture>();
      //Add scriptures to the list
      scriptureList.Add(new Scripture(new Reference("John",3,16),"For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have heverlasting life."));
      scriptureList.Add(new Scripture(new Reference("Moroni",10,3,5),"Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that yewould remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until thetime that ye shall receive these things, and ponder it in your hearts.And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, ifthese things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truthof it unto you, by the power of the Holy Ghost.And by the power of the Holy Ghost ye may know the truth of all things"));
      scriptureList.Add(new Scripture(new Reference("Ether",12,27),"And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."));
      //Select random scripture and display it
      var random = new Random();
      int index = random.Next(scriptureList.Count);
      Scripture scripture = scriptureList[index];
      string option ="";
      do{
        Console.WriteLine(scripture.GetDisplayText());
         Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        option = Console.ReadLine();
        if(option == ""){
          //Hide random words
          bool statusWords = scripture.IsCompletelyHidden();
          if(!statusWords){
            Random randomGenerator = new Random();
            int wordsToHide = randomGenerator.Next(1, 4);
            //As a stretch challenge, this method randomly select from only those words that are not already hidden) 
            scripture.HideRandomWords(wordsToHide);
          }else{
            break;
          }
        }
        // This will clear the console
        Console.Clear();
      }while(option!="quit");
    }

    
}