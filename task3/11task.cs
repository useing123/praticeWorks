using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string input = Console.ReadLine();

        string result = input.ToUpper();

        Console.WriteLine("Текст с преобразованными буквами:");
        Console.WriteLine(result);
    }
}
