using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Hector Rodriguez";
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Manager";
        job1._startYear = "2018";
        job1._endYear = "2023";

        myResume._jobs.Add(job1);

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = "2015";
        job2._endYear = "2020";

        myResume._jobs.Add(job2);
        
        myResume.DisplayResumeDetails();
    }
}