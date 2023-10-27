public class MoneyConverter
{
    public decimal ExchangeRate { get; }

    public MoneyConverter(decimal exchangeRate)
    {
        ExchangeRate = exchangeRate;
    }

    public Money Convert(Money money, MoneyConverter converter)
    {
        decimal[] convertedAmounts = money.Amounts.Select(amount => amount * converter.ExchangeRate).ToArray();
        return new Money(convertedAmounts);
    }

    public static bool operator ==(Money money1, Money money2)
    {
        return money1.Amounts.SequenceEqual(money2.Amounts);
    }

    public static bool operator !=(Money money1, Money money2)
    {
        return !money1.Amounts.SequenceEqual(money2.Amounts);
    }
}
