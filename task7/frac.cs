public class Frac
{
    public int Numerator { get; }
    public int Denominator { get; }

    public Frac(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public static Frac operator +(Frac a, Frac b)
    {
        int lcm = LCM(a.Denominator, b.Denominator);
        int newNumerator = a.Numerator * (lcm / a.Denominator) + b.Numerator * (lcm / b.Denominator);
        return new Frac(newNumerator, lcm);
    }

    public static Frac operator -(Frac a, Frac b)
    {
        int lcm = LCM(a.Denominator, b.Denominator);
        int newNumerator = a.Numerator * (lcm / a.Denominator) - b.Numerator * (lcm / b.Denominator);
        return new Frac(newNumerator, lcm);
    }

    public static Frac operator *(Frac a, Frac b)
    {
        int newNumerator = a.Numerator * b.Numerator;
        int newDenominator = a.Denominator * b.Denominator;
        return new Frac(newNumerator, newDenominator);
    }

    public static Frac operator /(Frac a, Frac b)
    {
        int newNumerator = a.Numerator * b.Denominator;
        int newDenominator = a.Denominator * b.Numerator;
        return new Frac(newNumerator, newDenominator);
    }

    public static implicit operator double(Frac frac)
    {
        return (double)frac.Numerator / frac.Denominator;
    }

    public static bool operator ==(Frac a, Frac b)
    {
        return a.Numerator * b.Denominator == a.Denominator * b.Numerator;
    }

    public static bool operator !=(Frac a, Frac b)
    {
        return a.Numerator * b.Denominator != a.Denominator * b.Numerator;
    }

    private static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }

    private static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }
}
