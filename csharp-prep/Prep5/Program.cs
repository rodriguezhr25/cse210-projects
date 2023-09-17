using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userFavoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userFavoriteNumber);
        DisplayResult(userName, squaredNumber );
    }
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
     static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userFavoriteNumber = int.Parse(Console.ReadLine());
        return userFavoriteNumber;
    }

    static int SquareNumber(int userFavoriteNumber)
    {
        return userFavoriteNumber * userFavoriteNumber;
    }

    static void DisplayResult(string userName, int squaredNumber){

        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        
    }
}