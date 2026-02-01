using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Avenida de Seneca 20", "Los Biolos", "Madrid", "Spain");

        Customer customer = new Customer("Nestor Gomez Artiles", address);

        List<Product> order1_products = new List<Product>
        {
            new Product("Bread", 1202, 2.50f, 2),
            new Product("Water", 1102, .50f, 8),
            new Product("Meet", 1002, 10f, 1),
        };

        Order order1 = new Order(customer, order1_products);

        List<Product> order2_products = new List<Product>
        {
            new Product("Milk", 1301, 1.20f, 3),
            new Product("Eggs", 1302, 2.75f, 2),
            new Product("Apples", 1303, 0.80f, 6),
        };

        Order order2 = new Order(customer, order2_products);

        Console.WriteLine("Order 1");
        order1.displayPackingLabel();
        order1.displayShippingLabel();
        Console.WriteLine($"Total cost order 1: {order1.totalCost()}");

        Console.WriteLine("Order 2");
        order2.displayPackingLabel();
        order2.displayShippingLabel();
        Console.WriteLine($"Total cost order 2: {order2.totalCost()}");


    }
}