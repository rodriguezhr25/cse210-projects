// BreathingActivity class
// The responsability of holding data about Breathing activities. 
public class BreathingActivity:Activity
{

   

    public BreathingActivity(string name, string description, int duration):base(name, description, duration){
      
    }

    public void Run(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
      

        while(DateTime.Now < endTime){
             Console.Write("Breathe in...");
             ShowCountDown(4);
             Console.WriteLine("");
             Console.Write("Now breathe out...");
             ShowCountDown(6);
             Console.WriteLine("");
             Console.WriteLine("");
        }
    }
    


}