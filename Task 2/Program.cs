using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        calc.PrintWelcome();

        int sum = calc.Add(5, 7);
        int product1 = calc.Multiply(4, 3); 
        int product2 = calc.Multiply(6);     

        Console.WriteLine("Addition: " + sum);
        Console.WriteLine("Multiplication (4 * 3): " + product1);
        Console.WriteLine("Multiplication with default value (6 * 1): " + product2);
    }
}
