class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    public Product(string nameInput, int idInput, double priceInput, int quantityInput)
    {
        name = nameInput;
        productId = idInput;
        price = priceInput;
        quantity = quantityInput;
    }

    public double TotalCost()
    {
        return price * quantity;
    }

    public string GetPackingInfo()
    {
        return name + " (ID: " + productId + ")";
    }
}