class Order
{
    Customer _customer = new Customer();

    List<Product> _products = new List<Product>();

    public Order() {}
    
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public float totalCost()
    {
        float total_cost = 0;
        foreach (Product product in _products)
        {
            total_cost += product.totalCost();
        }
        if (_customer.inUsa() == true)
        {
            return total_cost + 5;
        }
        return total_cost + 35;
    }

    public void displayPackingLabel()
    {
        Console.WriteLine("--------");
        Console.WriteLine("Packing Label");
        Console.WriteLine();
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.getName()} ({product.getProductId()})");
        }
        Console.WriteLine("--------");
    }
    public void displayShippingLabel()
    {
        Console.WriteLine("--------");
        Console.WriteLine("Shipping Label");
        Console.WriteLine();
        Console.WriteLine(_customer.getName());
        _customer.displayCustomerAddress();
        Console.WriteLine("--------");
    }
}