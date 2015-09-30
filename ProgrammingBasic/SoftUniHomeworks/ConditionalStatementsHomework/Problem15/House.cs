using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                for (int j = 1; j <= (n + 1) / 2 - i; j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int k = 2; k <= i; k++)
                {
                    Console.Write(".");
                }
                for (int k = 3; k <= i; k++)
                {
                    Console.Write(".");
                }
                if (i > 1)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= (n + 1) / 2 - i; j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();

            }
            for (int k = 1; k <= n; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            if (n == 5)
            {
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int k = 0; k < n / 4; k++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }

                    Console.WriteLine();
                }
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(".");
                }
                for (int i = 1; i <= (n + 7) / 4; i++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
                
            }
            else if (n == 7 || n == 9)
            {

                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int k = 0; k < (n + 5) / 4; k++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }

                    Console.WriteLine();
                }
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(".");
                }
                for (int i = 1; i <= (n + 13) / 4; i++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            else if (n == 11 || n == 15 || n == 19 || n == 23 || n == 27 || n == 31 || n == 35 || n == 39 || n == 43 || n == 47 )
            {
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    int n2 = n + 1;
                    for (int k = 0; k < (n + n2) / 4; k++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }

                    Console.WriteLine();
                }
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(".");
                }
                int n3 = n + 6;
                for (int i = 1; i <= (n + n3) / 4; i++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            else if (n == 13 || n == 17 || n == 21 || n == 25 || n == 29 || n == 33 || n == 37 || n == 41 || n == 45 || n == 49)
            {
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    int n2 = n - 3;
                    for (int k = 0; k < (n + n2) / 4; k++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= n / 4; j++)
                    {
                        Console.Write(".");
                    }

                    Console.WriteLine();
                }
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(".");
                }
                int n3 = n + 5;
                for (int i = 1; i <= (n + n3) / 4; i++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            } 
        }
    }
}
