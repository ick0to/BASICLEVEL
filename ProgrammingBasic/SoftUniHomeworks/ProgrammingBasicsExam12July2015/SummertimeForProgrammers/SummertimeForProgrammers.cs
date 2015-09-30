using System;

namespace SummertimeForProgrammers
{
    class SummertimeForProgrammers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = n / 2;
            for (int i = 1; i <= (n / 2); i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            } Console.Write("*");
            Console.WriteLine();

            for (int i = 1; i <= n / 2; i++)
            {
                for (int k = 1; k <= (n / 2); k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            for (int i = 1; i <= n / 2; i++)
            {
                for (int k = 1; k <= s; k++)
                {
                    Console.Write(" ");
                }
                    Console.Write("*");
                for (int k = 1; k <= (n + i + i) - 3; k++)
                {
                    Console.Write(" ");

                }
                Console.WriteLine("*");
                s--;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (int j = 1; j <= n * 2 - 2; j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine("*");
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (int j = 1; j <= n * 2 - 2; j++)
                {
                    Console.Write("@");
                }
                Console.WriteLine("*");
            }

            for (int i = 1; i <= n*2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
