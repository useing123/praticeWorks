using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        Console.WriteLine($"Количество слов в предложении: {wordCount}");
    }
}
