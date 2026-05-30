using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customerInput)
    {
        customer = customerInput;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product p in products)
        {
            total += p.TotalCost();
        }

        if (customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";

        foreach (Product p in products)
        {
            label += p.GetPackingInfo() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return "SHIPPING LABEL:\n" +
               customer.GetName() + "\n" +
               customer.GetAddress().GetFullAddress();
    }
}