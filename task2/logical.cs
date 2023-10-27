using System;

class Program
{
    static void Main()
    {
        bool A = true;
        bool B = false;
        bool C = false;

        // a. A или B;
        bool resultA = A || B;
        Console.WriteLine($"A или B: {resultA}");

        // b. A и B;
        bool resultB = A && B;
        Console.WriteLine($"A и B: {resultB}");

        // c. B или C;
        bool resultC = B || C;
        Console.WriteLine($"B или C: {resultC}");
    }
}
