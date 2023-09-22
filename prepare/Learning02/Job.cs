
    // A code template for the category of things known as Job. The
    // responsibility of a Job is to keep track of the company, job title, start year, and end year.
    public class Job
    {
        
        public string _company = "";
        public string _jobTitle = "";
        public string _startYear = "";
        public string _endYear = "";

        

        // // A method that displays the job details 
        public void DisplayJobDetails ()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ");
        }

    }