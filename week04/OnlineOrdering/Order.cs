using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        decimal shippingCost = 0;
        if (_customer.IsInUsa())
        {
            shippingCost = 5.00m;
        }
        else
        {
            shippingCost = 35.00m;
        }

        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- Shipping Label ---\n";
        label += $"{_customer.GetName()}\n";
        label += $"{_customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}
