using System.Net.Sockets;

class Customer
{
    string _name = "";
    Address _address = new Address();
    
    public Customer() {}
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool inUsa()
    {
        return _address.inUsa();
    }
    public string getName()
    {
        return _name;
    }
    public void displayCustomerAddress()
    {
        _address.displayAddress();
    }
}