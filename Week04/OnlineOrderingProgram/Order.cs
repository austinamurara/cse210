using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product) => _products.Add(product);

    public double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var product in _products) subtotal += product.GetTotalCost();
        
        double shipping = _customer.LivesInUSA() ? 5.00 : 35.00;
        return subtotal + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var p in _products) label += $"- {p.GetName()} (ID: {p.GetId()})\n";
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}