using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 5, 6, 7 };
        
        int[] commonElements = array1.Intersect(array2).Distinct().ToArray();

        Console.WriteLine("Общие элементы без повторений:");
        Console.WriteLine(string.Join(" ", commonElements));
    }
}
