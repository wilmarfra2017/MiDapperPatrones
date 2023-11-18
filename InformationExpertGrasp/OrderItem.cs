public class OrderItem
{
   
    public Product? Product { get; set; }
    public int Quantity { get; set; }

    public decimal GetTotalCost()
    {
        if(Product == null)
            throw new InvalidOperationException("Producto es nulo.");

        return Product.Price * Quantity;
    }
}
