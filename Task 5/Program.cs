using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a day (Example: Sunday): ");
        string day = Console.ReadLine().Trim().ToLower();

        DayType type;

        if (day == "friday" || day == "saturday")
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine($"It is: {type}");


        Book book1 = new Book("Atomic Habits", "James Clear", 999.50);

        Book book2 = book1 with { title = "The Alchemist", price = 850.00 };

        Console.WriteLine("\nBook 1 Details:");
        Console.WriteLine(book1);

        var (title, author, price) = book2;

        Console.WriteLine("\nBook 2 Deconstructed Values:");
        Console.WriteLine($"Title = {title}");
        Console.WriteLine($"Author = {author}");
        Console.WriteLine($"Price = {price}");
    }
}
