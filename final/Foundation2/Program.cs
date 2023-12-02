using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address
        var address1 = new Address("123 Main St", "Springville", "MO", "USA");
        var address2 = new Address("456 Oak St", "Montreal", "Quebec", "Canada");

        // Create Customers
        var customer1 = new Customer("John Doe", address1);
        var customer2 = new Customer("Jane Smith", address2);

        // Create Products
        var product1 = new Product("Laptop", "LPT001", 850, 2);
        var product2 = new Product("Mouse", "MS001", 25, 3);
        var product3 = new Product("Keyboard", "KB001", 50, 1);

        // Create Orders
        var order1 = new Order(new List<Product> { product1, product2, product3 }, customer1);
        var order2 = new Order(new List<Product> { product1, product3 }, customer2);

        // Display results
        Console.WriteLine();
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Order 1 - Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Order 1 - Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order 1 - Total Cost: ${order1.CalculateTotalCost():F2}\n");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Order 2 - Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Order 2 - Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order 2 - Total Cost: ${order2.CalculateTotalCost():F2}\n");
    }
}