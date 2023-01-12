using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("What is your first name?");
        Console.WriteLine("What in your last name?");

        string name = Console.ReadLine();
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {name}, {last} {name} " );

    }
}
