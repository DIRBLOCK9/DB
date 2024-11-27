using System;

class Program
{
   
    public static T GetMax<T>(T[] arr) where T : IComparable<T>
    {
        T max = arr[0];
        foreach (var item in arr)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }

    public static T GetMin<T>(T[] arr) where T : IComparable<T>
    {
        T min = arr[0];
        foreach (var item in arr)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }
        return min;
    }

    static void Main(string[] args)
    {
        int[] intArray = { 1, 5, 3, 9, 7 };
        double[] doubleArray = { 2.3, 3.4, 1.2, 5.6 };

        Console.WriteLine($"Max in intArray: {GetMax(intArray)}");
        Console.WriteLine($"Min in intArray: {GetMin(intArray)}");

        Console.WriteLine($"Max in doubleArray: {GetMax(doubleArray)}");
        Console.WriteLine($"Min in doubleArray: {GetMin(doubleArray)}");
    }
}
