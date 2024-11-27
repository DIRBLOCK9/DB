using System;

class Program
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        double a = 5.5, b = 10.5;
        Console.WriteLine($"Before Swap: a = {a}, b = {b}");
        Swap(ref a, ref b); 
        Console.WriteLine($"After Swap: a = {a}, b = {b}");

        string x = "Hello", y = "World";
        Console.WriteLine($"Before Swap: x = {x}, y = {y}");
        Swap(ref x, ref y); 
        Console.WriteLine($"After Swap: x = {x}, y = {y}");
    }
}
