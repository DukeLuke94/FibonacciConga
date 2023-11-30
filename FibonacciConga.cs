using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Get ready for the Fibonacci Conga Line!");

        int limit = 4000000;
        int sum = 0;

        int a = 1;
        int b = 2;

        string congaLine = "🎈";

        while (b <= limit)
        {
            if (b % 2 == 0)
            {
                sum += b;
                Console.WriteLine($"Caught an even Fibonacci number: {b}! Adding it to the conga line.");
            }

            Console.WriteLine(congaLine);
            Thread.Sleep(500);

            congaLine = congaLine.Insert(0, "💃🕺");

            int next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine($"The Fibonacci Conga Line has ended, and the sum of even numbers is: {sum}");
        Console.WriteLine("Thanks for dancing with the Fibonacci Conga Line! 🎉");
    }
}
