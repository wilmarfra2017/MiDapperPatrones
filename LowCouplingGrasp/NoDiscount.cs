public class NoDiscount : IDiscount
{
    public decimal ApplyDiscount(decimal price)
    {
        return price;
    }
}