class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string streetInput, string cityInput, string stateInput, string countryInput)
    {
        street = streetInput;
        city = cityInput;
        state = stateInput;
        country = countryInput;
    }

    public bool IsUSA()
    {
        return country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return street + "\n" + city + ", " + state + "\n" + country;
    }
}