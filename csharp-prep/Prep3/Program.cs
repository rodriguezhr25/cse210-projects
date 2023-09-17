using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
       
        string option ="";
        int guesses = 0;
        do
        {
            bool result = true;
            string textResult;
            string guessInput;
            int guessNumber;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);       
           
        
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
                    guesses++;
                }
                
                Console.WriteLine(textResult);
            } while (result);
            
            Console.WriteLine("Game Over");
            Console.Write("Do you want to play again? ");
            option = Console.ReadLine();
        } while (option == "yes");
        Console.WriteLine($"You got {guesses} guesses! ");
    }
}