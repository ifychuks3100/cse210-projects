public class Address
{
    // Private fields
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Check if the customer lives in the USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Return the complete address
    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}