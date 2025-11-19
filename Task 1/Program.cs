using System;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student();

        s1.name = "John";
        s1.age = 20;
        s1.address = "Kathmandu";

        s2.name = "Deepti";
        s2.age = 21;
        s2.address = "Morang";

        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Address: " + s1.address);

        Console.WriteLine();

        Console.WriteLine("Student 2 Details:");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Address: " + s2.address);

        Console.WriteLine();

        Console.WriteLine("School Name (Static Field): " + Student.schoolName);
    }
}
