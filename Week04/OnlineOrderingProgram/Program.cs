using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA
        Address a1 = new Address("123 Llama Lane", "Rexburg", "ID", "USA");
        Customer c1 = new Customer("John Smith", a1);
        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Laptop Stand", "LS-01", 25.00, 1));
        o1.AddProduct(new Product("USB-C Cable", "USB-09", 12.50, 2));

        // Order 2: International (Zimbabwe)
        Address a2 = new Address("456 Harare Way", "Harare", "Harare", "Zimbabwe");
        Customer c2 = new Customer("Austina Murara", a2);
        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Mechanical Keyboard", "KB-77", 85.00, 1));
        o2.AddProduct(new Product("Gaming Mouse", "GM-02", 45.00, 1));
        o2.AddProduct(new Product("Desk Mat", "DM-10", 20.00, 1));

        // Display
        Console.WriteLine("===============================");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${o1.CalculateTotal():0.00}");
        
        Console.WriteLine("\n===============================");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${o2.CalculateTotal():0.00}");
        Console.WriteLine("===============================");
    }
}