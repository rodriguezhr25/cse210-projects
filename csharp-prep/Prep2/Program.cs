using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Plese enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string gradeLetter = "";
        string lastDigit= "";
        int remainder = (grade%10) ;
        if(grade >= 90){
            gradeLetter = "A";
            
        }else if(grade >= 80){
            gradeLetter = "B";
        }else if(grade >= 70){            
            gradeLetter = "C";
        }else if(grade >= 60){            
            gradeLetter = "D";
        }else{
            gradeLetter = "F";
        }
        if(grade>= 60 && grade < 90){
            if(remainder >= 7){
                lastDigit = "+";
            }else if(remainder < 3){
                lastDigit = "-";
            } 
        }else if(grade >= 90){
            if(remainder < 3){
                lastDigit = "-";
            }
        }
          
        
        Console.WriteLine(remainder);
        Console.WriteLine($"Your final grade is {gradeLetter}{lastDigit}");

        if(grade >= 70){
            Console.WriteLine($"Congratualations!! You passed the course!!");
        }else{
            Console.WriteLine($"Sorry, you didn't get the miminum grade to pass, keep working hard next semester! ");
        }
        
    }
}