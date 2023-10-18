// Activity class
// The responsability of holding data about class mindfullnes activities. Base class
public class Activity
{

    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void SetDuration(int duration){
        _duration = duration;
    }
    public int GetDuration(){
        return _duration;
    }
    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds){
        List<string> animationStrings = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while(DateTime.Now < endTime){
            String s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if(i >= animationStrings.Count){
                i = 0;
            }
        }
           
    }
    public void ShowCountDown(int seconds){

        for(int i=seconds ; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }



}