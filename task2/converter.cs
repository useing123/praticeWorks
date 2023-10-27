using System;

class Program
{
    static void Main()
    {
        int distanceInCentimeters = 2345; 
        int fullMeters = distanceInCentimeters / 100;

        Console.WriteLine($"Число полных метров: {fullMeters}");
    }
}
