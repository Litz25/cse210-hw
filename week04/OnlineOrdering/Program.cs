using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("18 Tokyo way", "Lusaka", "Lusaka", "Zambia");
        Customer customer1 = new Customer("Lita Mwiya", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 500, 1));
        order1.AddProduct(new Product("SSD", 102, 20, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("TOTAL: $" + order1.GetTotalPrice());

        Console.WriteLine();

        Address address2 = new Address("Oak Road", "New York", "NY", "USA");
        Customer customer2 = new Customer("Mary Jackson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", 201, 300, 1));
        order2.AddProduct(new Product("Case", 202, 15, 3));
        order2.AddProduct(new Product("Charger", 203, 25, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("TOTAL: $" + order2.GetTotalPrice());
    }
}