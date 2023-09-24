using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal Program!");
        int option = 0;
        string fileName = "";
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        do
        {

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load JSON file");
            Console.WriteLine("4. Save to JSON file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("--------------------------------------------");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {

                case 1:
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    string entryText = Console.ReadLine();
                    Entry entry = new Entry
                    {
                        _promptText = randomPrompt,
                        _entryText = entryText,
                        _date = DateTime.Now.ToShortDateString()
                    };
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("What is the file name? (just enter the name without extension)");
                    fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName);
                    break;
                case 4:
                    Console.WriteLine("What is the file name? (just enter the name without extension)");
                    fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;
            }



        } while (option != 5);
    }
}