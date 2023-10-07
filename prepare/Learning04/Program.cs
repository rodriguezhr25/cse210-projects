using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment a = new Assigment("Hector Rodriguez" , "Multiplication");
        Console.WriteLine(a.GetSummary());
        Console.WriteLine("");
        MathAssignment mathAssignment = new MathAssignment("Sebastian Rodriguez", "Fractions",  "22", "7-25");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("");
        WritingAssignment writingAssignment = new WritingAssignment("Alan Rodriguez", "History",  "The importance of Bolivar");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}