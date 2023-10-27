using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку символов: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string word in words)
        {
            if (word.Length >= 2 && word[0] == word[word.Length - 1])
            {
                count++;
            }
        }

        Console.WriteLine($"Количество слов с одинаковыми первым и последним символами: {count}");
    }
}
