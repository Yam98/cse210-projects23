using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        //Console.WriteLine ("what is the magic number? ");
        //int num = int.Parse(Console.ReadLine());

        Random numbergene = new Random ();
        int num =numbergene.Next(1,201);
        int guess =-1;
        while (guess != num) 
        { 
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (num > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (num < guess)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("you guessed it!");
            }

        }


        

    }
}