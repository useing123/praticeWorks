public class Decimal
{
    private char[] digits;

    public Decimal(string value)
    {
        if (value.Length != 100)
        {
            throw new ArgumentException("Value must have exactly 100 digits.");
        }
        digits = value.ToCharArray();
    }

    public static Decimal operator +(Decimal num1, Decimal num2)
    {
        char[] result = new char[100];
        int carry = 0;
        for (int i = 99; i >= 0; i--)
        {
            int sum = (num1.digits[i] - '0') + (num2.digits[i] - '0') + carry;
            result[i] = (char)((sum % 10) + '0');
            carry = sum / 10;
        }
        return new Decimal(new string(result));
    }

    public override string ToString()
    {
        return new string(digits);
    }
}
