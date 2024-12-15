using System;

class Program
{
 
    delegate double FunctionDelegate(double x);

    
    static double F1(double x)
    {
        return 4 * x - 1;
    }

    
    static double F2(double x)
    {
        return 25 * x + 10;
    }

   
    static double F3(double x)
    {
        return 0;
    }

    static void Main()
    {
        Console.WriteLine("Введiть значення x:");

       
        string input = Console.ReadLine();

        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Потрiбно було ввести число");
            return;
        }

       
        if (!double.TryParse(input, out double x))
        {
            Console.WriteLine("Невiрне значення. Введiть число.");
            return;
        }

        
        FunctionDelegate function;

       
        if (x < 0)
        {
            function = F1;
        }
        else if (x > 0)
        {
            function = F2;
        }
        else
        {
            function = F3;
        }

  
        double result = function(x);
        Console.WriteLine($"Результат F({x}) = {result}");
    }
}
