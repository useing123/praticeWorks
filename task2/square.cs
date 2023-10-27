using System;

class Program
{
    static void Main()
    {
        double radius = 5; // Замените это значение на радиус вашего круга
        double sideLength = 8; // Замените это значение на длину стороны вашего квадрата

        double circleArea = Math.PI * Math.Pow(radius, 2);
        double squareArea = Math.Pow(sideLength, 2);

        if (circleArea > squareArea)
        {
            Console.WriteLine("Площадь круга больше.");
        }
        else if (circleArea < squareArea)
        {
            Console.WriteLine("Площадь квадрата больше.");
        }
        else
        {
            Console.WriteLine("Площади равны.");
        }
    }
}
