using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Main St", "Cityville", "New York", "NY 12345" , "USA");
        Address address2 = new Address("456 Elm St", "Townsville", "Utah", "UT 67890","USA");
        Address address3 = new Address("789 Oak St", "Villageville", "Texas", "TX 54321", "USA");

        Lecture lecture = new Lecture("1984 Lecture", "Reading 1984 of Geroge Orwell", DateTime.Parse("12/05/2023"), TimeSpan.FromHours(1), address1, "Hector Rodriguez", 100);
        Reception reception = new Reception("Wedding Recepction", "Wedding details for the reservation", DateTime.Parse("11/25/2023"), TimeSpan.FromHours(2), address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Gathering Wiht Friends", "Lucnh and meeting in the gardens", DateTime.Parse("10/24/2023"), TimeSpan.FromHours(3), address3, "Sunny");

        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
    
    }
}








