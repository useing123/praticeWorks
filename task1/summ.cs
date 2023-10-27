using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите несколько чисел через пробел: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sum = 0;
        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int n))
            {
                sum += n;
            }
        }

        Console.WriteLine("Сумма чисел: " + sum);
    }
}
