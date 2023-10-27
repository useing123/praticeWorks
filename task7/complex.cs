public struct Complex
{
    public double Real { get; }
    public double Imaginary { get; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary,
                          a.Real * b.Imaginary + a.Imaginary * b.Real);
    }

    public static Complex operator /(Complex a, Complex b)
    {
        double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
        return new Complex((a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator,
                          (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator);
    }

    public static implicit operator Complex(double real)
    {
        return new Complex(real, 0);
    }

    public static bool operator ==(Complex a, Complex b)
    {
        return a.Real == b.Real && a.Imaginary == b.Imaginary;
    }

    public static bool operator !=(Complex a, Complex b)
    {
        return a.Real != b.Real || a.Imaginary != b.Imaginary;
    }

    public override bool Equals(object obj)
    {
        if (obj is Complex other)
        {
            return this == other;
        }
        return false;
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}
