class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalProductCost = 0;

        foreach (var product in _products)
        {
            totalProductCost += product.CalculateProductTotalPrice();
        }

        decimal shippingCost = _customer.IsInUSA() ? 5 : 35;

        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        var packingLabel = "";

        foreach (var product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        var customerName = _customer.GetName();
        var addressDetails = _customer.GetAddress().GetAddressDetails();

        return $"{customerName}\n{addressDetails}";
    }
}