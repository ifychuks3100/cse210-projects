using System;

class Program
{
    static void Main(string[] args)
    {
        // FIRST CUSTOMER
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "New York",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // SECOND CUSTOMER
        Address address2 = new Address(
            "15 Allen Avenue",
            "Ikeja",
            "Lagos",
            "Nigeria"
        );

        Customer customer2 = new Customer("David James", address2);


        // FIRST ORDER
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "P001", 800, 1);
        Product product2 = new Product("Mouse", "P002", 20, 2);
        Product product3 = new Product("Keyboard", "P003", 40, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // SECOND ORDER
        Order order2 = new Order(customer2);

        Product product4 = new Product("Phone", "P004", 500, 1);
        Product product5 = new Product("Headphones", "P005", 60, 2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);


        // DISPLAY FIRST ORDER
        Console.WriteLine("========== ORDER 1 ==========");

        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}");


        // DISPLAY SECOND ORDER
        Console.WriteLine("\n========== ORDER 2 ==========");

        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }
}