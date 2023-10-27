using System;
using System.Collections.Generic;
using System.Linq;

abstract class Animal
{
    public string Name { get; set; }
    public abstract string Type { get; }
    public abstract double CalculateFood();

    public override string ToString()
    {
        return $"{Name} ({Type}): {CalculateFood()} кг";
    }
}

class Carnivore : Animal
{
    public override string Type => "Хищник";

    public override double CalculateFood()
    {
        return 2.0;
    }
}

class Omnivore : Animal
{
    public override string Type => "Всеядное";

    public override double CalculateFood()
    {
        return 1.0;
    }
}

class Herbivore : Animal
{
    public override string Type => "Травоядное";

    public override double CalculateFood()
    {
        return 0.5;
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Carnivore { Name = "Лев" },
            new Herbivore { Name = "Зебра" },
            new Omnivore { Name = "Человек" }
        };

        animals = animals.OrderByDescending(a => a.CalculateFood())
                         .ThenBy(a => a.Name)
                         .ToList();

        Console.WriteLine("Животные и количество потребляемой пищи:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}
