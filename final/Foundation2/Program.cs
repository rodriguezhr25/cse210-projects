using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer(
            "Hector Rodriguez",
            new Address("Carabobo Street 143", "Cantaura", "Anzoategui", "Venezuela")
        );
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("SSD Kingstom 128 GB", "S1", 54.00, 3));
        order1.AddProduct(new Product("Memory ram 8 GB", "M1", 15.00, 2));

        Customer customer2 = new Customer(
            "Yetza GarciA",
            new Address("South Street 143", "Salt Lake", "UT", "US")
        );
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop HP", "L1", 250.00, 1));
        order2.AddProduct(new Product("Mouse Logitech", "Mo1", 20.35, 2));
        order2.AddProduct(new Product("Keyboard", "K25", 20.00, 6));
        
        Console.WriteLine("");
        Console.WriteLine("Order Details");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("");
        Console.WriteLine("Shipping Label");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Order total cost: {order1.CalculateTotalCost()}");
        Console.WriteLine("---------------------------");
        Console.WriteLine("");
        Console.WriteLine("Order Details");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Packing Label");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("");
        Console.WriteLine("Shipping Label");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Order total cost: {order2.CalculateTotalCost()}");
        Console.WriteLine("---------------------------");
    }
}
