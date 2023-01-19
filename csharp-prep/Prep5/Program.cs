using System;

class Program
{
    static void Main(string[] args)
    {
        hi(); 
        string username = addnam();
        int usernumber = numer(); 

        int square = square2(usernumber);
        answer(username, square);


    } 
    
    //Console.WriteLine("Hello Prep5 World!");
    public static void hi ()
    {
        Console.WriteLine("Welcome to Programing!!");
    }

    //public static void addnam ()
    public static string addnam ()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;

    }

    public static int numer()
    {
        Console.Write("please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    
    static int square2(int number)
    {
        int square = number * number;
        return square;
    }
    static void answer(string name, int square) => Console.WriteLine($"Hello {name}, the square of your number is {square}");
    //Welcome to the program! done
    //Please enter your name: Brother Burton done
    //Please enter your favorite number: 42
    //Brother Burton, the square of your number is 1764
}