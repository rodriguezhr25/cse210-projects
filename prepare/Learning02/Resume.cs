
// A code template for the category of things known as Resume. 
// The responsability of a ResumeKeeps track of the person's name and a list of their jobs
public class Resume
{

    public string _name = "";
    public List<Job> _jobs = new List<Job>();


    // // A method that displays the resume details 
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine("Jobs: ");
        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }
       
    }



}