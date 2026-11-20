public class Customer
{
    // Private fields
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Get customer name
    public string GetName()
    {
        return _name;
    }

    // Get customer address
    public Address GetAddress()
    {
        return _address;
    }

    // Check if customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}