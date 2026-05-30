class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string nameInput, int idInput, double priceInput, int quantityInput)
    {
        _name = nameInput;
        _productId = idInput;
        _price = priceInput;
        _quantity = quantityInput;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return _name + " (ID: " + _productId + ")";
    }
}