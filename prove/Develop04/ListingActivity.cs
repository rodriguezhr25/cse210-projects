using System;
using System.Collections.Generic;
// ListingActivity class
// The responsability of holding data about Listing activities. 
public class ListingActivity:Activity
{
    private int _count;   
    private List<string> _prompts = new List<string>(){"Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"};
    public ListingActivity(string name, string description, int duration):base(name,description,duration){
        
    }

    public void Run(){

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---- {GetRandomPrompt()} ----");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        _count = GetListFromUser().Count();
         Console.WriteLine($"You listed {_count} items ");
        
    }

    public string GetRandomPrompt(){
         var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser(){
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        List<string> answers = new List<string>();

        while(DateTime.Now < endTime){
           Console.Write(">");         
           string answer = Console.ReadLine();
           answers.Add(answer);
        }

        return answers;

    }
   


}