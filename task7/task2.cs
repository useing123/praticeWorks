public class Money
{
    public decimal[] Amounts { get; }

    public Money(decimal[] amounts)
    {
        Amounts = amounts;
    }

    public static bool operator <(Money money1, Money money2)
    {
        return money1.Amounts.Sum() < money2.Amounts.Sum();
    }

    public static bool operator >(Money money1, Money money2)
    {
        return money1.Amounts.Sum() > money2.Amounts.Sum();
    }
}
