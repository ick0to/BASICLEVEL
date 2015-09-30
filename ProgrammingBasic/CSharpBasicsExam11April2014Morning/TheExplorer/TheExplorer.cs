using System;

namespace TheExplorer
{
    class TheExplorer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n/2 + 1; i++)
            {
                for (int j = 1; j <= n - (n / 2) - i; j++)
                {
                    Console.Write("-");
                }
                if (i < n)
                {
                    Console.Write("*");
                    for (int j = 2; j <= i + i - 2; j++)
                    {
                        Console.Write("-");
                    }
                    if (i > 1)
                    {
                        Console.Write("*");
                    }
                }
                for (int j = 1; j <= n - (n / 2) - i; j++)
                {
                    Console.Write("-");
                }

                Console.WriteLine();
            }
            for (int i = 1; i <= n / 2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-");
                }
                if (i < n - 1)
                {
                    Console.Write("*");
                    for (int j = 2; j <= n - i - i - 1; j++)
                    {
                        Console.Write("-");
                    }
                    if (i < n/2)
                    {
                        Console.Write("*");
                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-");
                }

                Console.WriteLine();
            }
        }
    }
}
