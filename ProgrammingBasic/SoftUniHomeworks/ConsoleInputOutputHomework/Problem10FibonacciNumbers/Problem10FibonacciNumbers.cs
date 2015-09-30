using System;

namespace Problem10FibonacciNumbers
{
    class Problem10FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1;

            Console.Write("First {0} terms of Fibonacci series are: ", n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a);
                int c = a;
                a = b;
                b = c + b;
            }
            Console.WriteLine();
        }
    }
}
