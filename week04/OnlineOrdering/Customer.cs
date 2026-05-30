class Customer
{
    private string name;
    private Address address;

    public Customer(string nameInput, Address addressInput)
    {
        name = nameInput;
        address = addressInput;
    }

    public bool LivesInUSA()
    {
        return address.IsUSA();
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}