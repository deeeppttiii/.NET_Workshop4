using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks: ");
        int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total: ");
        int.TryParse(Console.ReadLine(), out int total);

        // BREAKPOINT 1
        double percentage = (double)marks / total * 100;

        // BREAKPOINT 2
        Console.WriteLine("Percentage: " + percentage);
    }
}
