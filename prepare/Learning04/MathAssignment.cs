// MathAssignment class
// The responsability of holding data about Math Assignment 
public class MathAssignment:Assigment
{

    private string _textbookSection;
    private string _problems;


    public MathAssignment(string studentName, string topic, string textbookSection, string problems):base(studentName,topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList(){

        return $"Section {_textbookSection} Problems {_problems}";
    }
}