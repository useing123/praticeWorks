using System;

class ExceptionHandlingExample
{
    public void MethodWithException()
    {
        Console.WriteLine("MethodWithException: Start");
        // Генерируем исключение
        throw new Exception("This is a sample exception.");
        Console.WriteLine("MethodWithException: End"); // Этот код не выполнится из-за исключения
    }

    public void CallingMethod()
    {
        Console.WriteLine("CallingMethod: Start");
        try
        {
            MethodWithException(); // Вызываем метод с исключением
        }
        catch (Exception ex)
        {
            Console.WriteLine($"CallingMethod: Exception caught - {ex.Message}");
        }
        Console.WriteLine("CallingMethod: End");
    }
}

class Program
{
    static void Main()
    {
        ExceptionHandlingExample example = new ExceptionHandlingExample();

        try
        {
            example.CallingMethod();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Main: Exception caught in Main - {ex.Message}");
        }
    }
}
