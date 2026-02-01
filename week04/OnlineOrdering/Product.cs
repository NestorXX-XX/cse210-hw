class Product
{
    string _name = "";
    int _productId = 0;

    float _price = 0;

    int _quantity = 0;

    public Product() {}

    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float totalCost()
    {
        return _price * _quantity;
    }
    public string getName()
    {
        return _name;
    }

    public int getProductId()
    {
        return _productId;
    }

}