public class OrderItem
{
    public Product Product { get; private set; } //1
    public int Quantity { get; set; }

    public OrderItem(string productName, decimal productPrice, int quantity)
    {
        this.Product = CreateProduct(productName, productPrice);
        this.Quantity = quantity;
    }

    private Product CreateProduct(string name, decimal price)
    {
        return new Product(name, price); //3
    }

    public decimal GetTotalCost()
    {
        return Product.Price * Quantity; //2
    }
}
