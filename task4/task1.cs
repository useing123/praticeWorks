using System;
using System.Linq;

struct Student
{
    public string Name;
    public int GroupNumber;
    public int[] Grades;

    public double AverageGrade => Grades.Average();
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10];

        // Заполните массив студентов данными

        students = students.OrderBy(s => s.AverageGrade).ToArray();

        Console.WriteLine("Студенты с оценками 4 и 5:");
        foreach (var student in students)
        {
            if (student.Grades.All(grade => grade == 4 || grade == 5))
            {
                Console.WriteLine($"Фамилия: {student.Name}, Группа: {student.GroupNumber}");
            }
        }
    }
}
