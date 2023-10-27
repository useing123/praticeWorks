using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку длиной 20 символов: ");
        string input = Console.ReadLine();

        if (input.Length != 20)
        {
            Console.WriteLine("Строка должна быть длиной 20 символов.");
        }
        else
        {
            int digitCount = 0;
            for (int i = 0; i < 20; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digitCount++;
                }
            }

            Console.WriteLine($"Количество цифр в строке: {digitCount}");
        }
    }
}
