using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string userInput;
        int numberInput;
        List<int> numbersList = new List<int>();
        List<int> postiveNumbersList = new List<int>();
        int sum = 0;
        float average;

        Console.WriteLine("Enter a list of numbers (negative or positive), type 0 when finished. ");
        do
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            numberInput = int.Parse(userInput);
            if (numberInput != 0)
            {
                numbersList.Add(numberInput);
            }


        } while (numberInput != 0);

        // Sum
        foreach (int number in numbersList)
        {
            sum += number;
        }
        // average
        average = (float)(sum) / numbersList.Count();
        // Get Max value
        int max = numbersList.Max();

        // get  smallest positive value
        //First we copy the list and then we remove all negative values
        foreach (int number in numbersList)
        {
           postiveNumbersList.Add(number);
        }
        postiveNumbersList.RemoveAll(t => t < 0);
        postiveNumbersList.Sort();
        int minPositive = postiveNumbersList.Min();
        

        //Print results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number: {max}");
        Console.WriteLine($"The smallest positive number is: {minPositive}");
        Console.WriteLine("The sorted list is:");

        numbersList.Sort();
        foreach (int number in numbersList)
        {
            Console.WriteLine(number);
        }
    }
}