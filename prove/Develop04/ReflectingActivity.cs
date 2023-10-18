using System;
using System.Collections.Generic;
// ReflectingActivity class
// The responsability of holding data about Listing activities. 
public class ReflectingActivity:Activity
{
    private List<string> _prompts = new List<string>(){"Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>(){"Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"};

    private List<string> _questionsUsed = new List<string>();

    public ReflectingActivity(string name, string description, int duration):base(name, description , duration){
        
    }

    public void Run(){
        List<string> _questionsUsed = new List<string>();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine("Consider the following promt");
        DisplayPrompt();
        Console.WriteLine("When you have somthing in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
      

        while(DateTime.Now < endTime){
             DisplayQuestions();
             ShowSpinner(6);
             Console.WriteLine("");
        }
          
    }

    public string GetRandomPrompt(){
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    //Get random question using unselected questions
    public string GetRandomQuestion(){
        var random = new Random();
        var result = _questions.Where(p => _questionsUsed.All(p2 => p2 != p)).ToList();
        int index = random.Next(result.Count);
        string ramdomQuestion = result[index];
        _questionsUsed.Add(ramdomQuestion);
        return ramdomQuestion;
    }

    public void DisplayPrompt(){
        Console.WriteLine($"---- {GetRandomPrompt()} ----");
    }

    public void DisplayQuestions(){
        Console.Write($"> {GetRandomQuestion()} ");
    }
   


}