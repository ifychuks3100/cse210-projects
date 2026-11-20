using System.Collections.Generic;

public class Order
{
    // Private fields
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Add products to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate shipping cost
    private decimal GetShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    // Calculate total order cost
    public decimal CalculateTotalCost()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        total += GetShippingCost();

        return total;
    }

    // Generate packing label
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return label;
    }

    // Generate shipping label
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";

        label += _customer.GetName() + "\n";
        label += _customer.GetAddress().GetAddressString();

        return label;
    }
}