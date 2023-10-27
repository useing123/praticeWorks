using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[5, 5];
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(-100, 101);
            }
        }

        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int maxElement = array.Cast<int>().Max();
        int minElement = array.Cast<int>().Min();
        int sumBetweenMinMax = 0;
        bool foundMax = false, foundMin = false;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] == maxElement)
                {
                    foundMax = true;
                }
                if (array[i, j] == minElement)
                {
                    foundMin = true;
                }
                if (foundMax && !foundMin)
                {
                    sumBetweenMinMax += array[i, j];
                }
                if (foundMin && !foundMax)
                {
                    sumBetweenMinMax += array[i, j];
                }
            }
        }

        Console.WriteLine($"Сумма элементов между минимальным и максимальным элементами: {sumBetweenMinMax}");
    }
}
