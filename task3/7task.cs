using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        var uniqueLetters = input.Where(char.IsLetter).Select(char.ToLower).Distinct();
        int uniqueLetterCount = uniqueLetters.Count();

        Console.WriteLine($"Количество различных букв в строке: {uniqueLetterCount}");
    }
}
