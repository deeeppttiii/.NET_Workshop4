using System;

class Program
{
    static void Main(string[] args)
    {
        Parameter demo = new Parameter();

        int value = 20;
        demo.Increase(ref value);
        Console.WriteLine("After Increase: " + value);

        demo.GetFullName(out string myName);
        Console.WriteLine("Full Name: " + myName);

        int result = demo.SumAll(5, 10, 15, 20);
        Console.WriteLine("Sum of all numbers: " + result);
    }
}
