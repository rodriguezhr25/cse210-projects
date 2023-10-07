// Assigment class
// The responsability of holding data about class assignments
public class Assigment
{

    private string _studentName;
    private string _topic;

    public Assigment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }

    //Getters for student name and topic
    public string GetStudentName(){
        return _studentName;
    }
     public string GetTopic(){
        return _studentName;
    }

    public string GetSummary(){

        return _studentName + " - " + _topic;
    }


}