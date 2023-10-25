using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activity instances
        DateTime date1 = new DateTime(2023, 10, 3);
        Running runningActivity = new Running(date1, 30, 4.8f);
        DateTime date2 = new DateTime(2023, 10, 17);
        Cycling cyclingActivity = new Cycling(date2, 30, 6.0f);
        DateTime date3 = new DateTime(2023, 10, 22);
        Swimming swimmingActivity = new Swimming(date3, 30, 4);

        // Store activities in a list
        Activity[] activities = { runningActivity, cyclingActivity, swimmingActivity };

        // Iterate through the list and display summaries
        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}
