public class Product
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public IDiscount? Discount { get; set; } //asociacion

    public decimal GetDiscountedPrice()
    {
        if (Discount == null)
        {
            return Price;
        }

        return Discount.ApplyDiscount(Price);
    }
}