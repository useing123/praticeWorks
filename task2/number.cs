using System;

class Program
{
    static void Main()
    {
        int twoDigitNumber = 47; // Замените это значение на ваше

        int tens = twoDigitNumber / 10;
        int units = twoDigitNumber % 10;
        int sum = tens + units;
        int product = tens * units;

        Console.WriteLine($"Число десятков: {tens}");
        Console.WriteLine($"Число единиц: {units}");
        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {product}");
    }
}
