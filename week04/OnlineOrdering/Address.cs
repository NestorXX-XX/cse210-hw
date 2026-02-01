class Address
{
    string _streetAddress = "";
    string _city = "";
    string _state = "";
    string _country = "";

    public Address() {}
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool inUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }
    public void displayAddress()
    {
        Console.WriteLine(_streetAddress);
        Console.WriteLine($"{_city}, {_state}");
        Console.WriteLine(_country);
    }
}