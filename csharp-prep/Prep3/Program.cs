using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
       
        string option ="";
        
        do
        {
            bool result = true;
            string textResult;
            string guessInput;
            int guessNumber;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);       
            int attempts = 0;
        
            do
            {

                Console.Write("What is your guess? ");
                guessInput = Console.ReadLine();
                guessNumber = int.Parse(guessInput);

                if (guessNumber < magicNumber)
                {
                    textResult = "Higher";
                }
                else if (guessNumber > magicNumber)
                {
                    textResult = "Lower";
                }
                else
                {
                    textResult = "You guessed it!";
                    result = false;
                }
                attempts++;
                
                Console.WriteLine(textResult);
                
            } while (result);            
            Console.WriteLine($"Attempts: {attempts}");
            Console.Write("Do you want to play again? (Enter yes to continue or other key to exit) ");
            option = Console.ReadLine();
        } while (option == "yes");
        
    }
}