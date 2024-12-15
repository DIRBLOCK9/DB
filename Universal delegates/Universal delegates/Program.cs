using System;

class Program
{
    
    static T Add<T>(T a, T b) => (dynamic)a + (dynamic)b;
    static T Subtract<T>(T a, T b) => (dynamic)a - (dynamic)b;
    static T Multiply<T>(T a, T b) => (dynamic)a * (dynamic)b;
    static T Divide<T>(T a, T b)
    {
        if ((dynamic)b == 0)
            throw new DivideByZeroException("Дiлення на нуль!");
        return (dynamic)a / (dynamic)b;
    }

    static void Main()
    {
        Console.WriteLine("Консольний калькулятор");
        Console.WriteLine("Доступнi операцiї: +, -, *, /");
        Console.WriteLine("Введiть перше число:");

        
        string input1 = Console.ReadLine();
        Console.WriteLine("Введiть друге число:");
        string input2 = Console.ReadLine();
        Console.WriteLine("Введiть операцiю (+, -, *, /):");
        string operation = Console.ReadLine();

        
        if (string.IsNullOrWhiteSpace(input1) || string.IsNullOrWhiteSpace(input2) || string.IsNullOrWhiteSpace(operation))
        {
            Console.WriteLine("Не всi данi введено. Завершення програми.");
            return;
        }

        
        bool isInt1 = int.TryParse(input1, out int int1);
        bool isInt2 = int.TryParse(input2, out int int2);
        bool isDouble1 = double.TryParse(input1, out double double1);
        bool isDouble2 = double.TryParse(input2, out double double2);

        try
        {
            
            if (isInt1 && isInt2)
            {
                PerformOperation<int>(int1, int2, operation);
            }
            else if (isDouble1 && isDouble2)
            {
                PerformOperation<double>(double1, double2, operation);
            }
            else
            {
                Console.WriteLine("Неправильний формат чисел.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static void PerformOperation<T>(T a, T b, string operation)
    {
        Func<T, T, T> func = operation switch
        {
            "+" => Add,
            "-" => Subtract,
            "*" => Multiply,
            "/" => Divide,
            _ => throw new InvalidOperationException("Неправильна операцiя.")
        };

        
        T result = func(a, b);
        Console.WriteLine($"Результат: {result}");
    }
}
