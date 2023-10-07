// Assigment class
// The responsability of holding data about Writing Assignments 
public class WritingAssignment : Assigment
{

    private string _title;


    public WritingAssignment(string studentName, string topic, string title):base(studentName,topic){
        _title = title;
    }

    //Getters
    public string GetTitle(){
        return _title;
    }

    public string GetWritingInformation(){

        return $"{_title} by {base.GetStudentName()}";
    }


}