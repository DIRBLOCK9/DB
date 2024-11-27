using System;

class Program
{
    public class Generic<T> where T : IComparable<T>
    {
        private T value;

        public Generic(T value)
        {
            this.value = value;
        }

        public T GetSmaller(T otherValue)
        {
            if (value.CompareTo(otherValue) < 0)
                return value;
            else
                return otherValue;
        }
    }

    static void Main(string[] args)
    {
        var intGeneric = new Generic<int>(5);
        Console.WriteLine($"Smaller between 5 and 10: {intGeneric.GetSmaller(10)}");

        var doubleGeneric = new Generic<double>(3.5);
        Console.WriteLine($"Smaller between 3.5 and 2.1: {doubleGeneric.GetSmaller(2.1)}");
    }
}
