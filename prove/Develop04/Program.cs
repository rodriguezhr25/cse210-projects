using System;

class Program
{
    static void Main(string[] args)
    {
       int option = 0;
       
       do{
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu");
            option = int.Parse(Console.ReadLine());
            string activityName = "";
            string activityDescription = "";
            int duration = 0;
            switch (option)
            {
                case 1:
                    Console.Clear();
                    activityName = "Breathing";
                    activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    BreathingActivity breathing = new BreathingActivity(activityName,activityDescription, duration );
                    breathing.DisplayStartingMessage();
                    duration = int.Parse(Console.ReadLine());
                    breathing.SetDuration(duration);
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                    break;
                
                case 2:
                    //For the strech challenge this activity won't select repeated questions
                    Console.Clear();
                    activityName = "Reflection";
                    activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectingActivity reflecting = new ReflectingActivity(activityName,activityDescription, duration );
                    reflecting.DisplayStartingMessage();
                    duration = int.Parse(Console.ReadLine());
                    reflecting.SetDuration(duration);
                    reflecting.Run();
                    reflecting.DisplayEndingMessage();
                    break;
                case 3:
                 Console.Clear();
                    activityName = "Listing";
                    activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    ListingActivity listing = new ListingActivity(activityName,activityDescription, duration );
                    listing.DisplayStartingMessage();
                    duration = int.Parse(Console.ReadLine());
                    listing.SetDuration(duration);
                    listing.Run();
                    listing.DisplayEndingMessage();
                    break;
                
                
            }
        // This will clear the console
       // Console.Clear();
      }while(option!= 4);
    }
}