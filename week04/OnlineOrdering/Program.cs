using System;

class Program
{
    static void Main(string[] args)
    {
        // FIRST ORDER
        Address address1 = new Address("164 Main Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("Job Gamu", address1);

        Product product1 = new Product("Freezer", 67, 1500.67, 1);
        Product product2 = new Product("Fan", 105, 500.72, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost is ${order1.GetTotalCost():F2}");

        // sECOND ORDER
        Address address2 = new Address("74 Main Street", "Kampala", "KLA", "Uganda");
        Customer customer2 = new Customer("Jacob Monti", address2);

        Product product3 = new Product("Laptop", 27, 900.89, 2);
        Product product4 = new Product("Cooker", 152, 1100.99, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost is ${order2.GetTotalCost():F2}");
    }   
}