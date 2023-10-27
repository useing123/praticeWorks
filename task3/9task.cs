using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите последовательность букв (длиной 20 символов): ");
        string input = Console.ReadLine();

        if (input.Length != 20)
        {
            Console.WriteLine("Строка должна быть длиной 20 символов.");
        }
        else
        {
            // Замените "Ваше имя" на ваше имя, которое вы хотите найти в последовательности символов.
            string nameToFind = "Ваше имя";
            if (input.Contains(nameToFind))
            {
                Console.WriteLine($"Имя найдено: {nameToFind}");
            }
            else
            {
                Console.WriteLine("Нет имени.");
            }
        }
    }
}
