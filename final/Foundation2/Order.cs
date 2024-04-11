using System.Runtime.CompilerServices;

public class Order
{
    private Costumer _costumer;
    private List<Product> _products;
    private decimal _shippingCost;

    public Order (Costumer costumer, List<Product> products, decimal shippingCost)
    {
        _costumer = costumer;
        _products = products;
        _shippingCost = shippingCost;
    }
    public void SetProducts(List<Product> products)
    {
        _products = products;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public Costumer GetCostumer()
    {
        return _costumer;
    }
    public decimal CalculateTotalCost (Product _products, decimal shippingCost)
    {
        decimal total = _products.GetTotalCost();
        return total;
    }
}