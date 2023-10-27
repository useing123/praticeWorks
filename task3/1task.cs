using System;

class Program
{
    static void Main()
    {
        // Одномерный массив
        double[] A = new double[5];
        Console.WriteLine("Введите 5 чисел для массива A:");
        for (int i = 0; i < 5; i++)
        {
            A[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Массив A:");
        Console.WriteLine(string.Join(" ", A));

        // Двумерный массив
        double[,] B = new double[3, 4];
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = random.NextDouble();
            }
        }
        Console.WriteLine("Массив B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Поиск общих максимального и минимального элементов, суммы и произведения
        double maxA = A.Max();
        double maxB = B.Cast<double>().Max();
        double minA = A.Min();
        double minB = B.Cast<double>().Min();
        double sumA = A.Sum();
        double sumB = B.Cast<double>().Sum();
        double productA = A.Aggregate(1.0, (x, y) => x * y);
        double productB = B.Cast<double>().Aggregate(1.0, (x, y) => x * y);

        Console.WriteLine($"Максимальный элемент в A: {maxA}");
        Console.WriteLine($"Максимальный элемент в B: {maxB}");
        Console.WriteLine($"Минимальный элемент в A: {minA}");
        Console.WriteLine($"Минимальный элемент в B: {minB}");
        Console.WriteLine($"Сумма элементов в A: {sumA}");
        Console.WriteLine($"Сумма элементов в B: {sumB}");
        Console.WriteLine($"Произведение элементов в A: {productA}");
        Console.WriteLine($"Произведение элементов в B: {productB}");

        // Сумма четных элементов в A и сумма нечетных столбцов в B
        double sumEvenA = A.Where(x => x % 2 == 0).Sum();
        double sumOddColumnsB = 0;
        for (int j = 0; j < 4; j += 2)
        {
            sumOddColumnsB += B.Cast<double>().Where((value, index) => index % 4 == j).Sum();
        }
        Console.WriteLine($"Сумма четных элементов в A: {sumEvenA}");
        Console.WriteLine($"Сумма нечетных столбцов в B: {sumOddColumnsB}");
    }
}
