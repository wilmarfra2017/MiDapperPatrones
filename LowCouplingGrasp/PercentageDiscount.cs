public class PercentageDiscount : IDiscount
{
    private readonly decimal _percentage;

    public PercentageDiscount(decimal percentage)
    {
        _percentage = percentage;
    }

    public decimal ApplyDiscount(decimal price)
    {
        return price * (1 - _percentage / 100);
    }
}
