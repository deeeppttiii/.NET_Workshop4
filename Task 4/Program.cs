using System;

class Program
{
    static void Main(string[] args)
    {
        Player p1 = new Player();

        Console.WriteLine("\nPlayer 1 Details:");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        Player p2 = new Player("Alex", 5, 100);

        Console.WriteLine("\nPlayer 2 Details:");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);
    }
}
