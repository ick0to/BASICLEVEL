using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunlight
{
    class Sunlight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dot = ".";
            string star = "*";
            int x = (n + n) / 4;
            //          ....*....                   <---
            for (int i = 1; i <= n + x; i++)
            {
                Console.Write(dot);
            }
            Console.Write(star);
            for (int j = 1; j <= n + x; j++)
            {
                Console.Write(dot);
            }
            Console.WriteLine();

            /*          .*..*..*.                   <---
                        ..*.*.*..
                        ...***...           */
            if (n == 3)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int m = 1; m <= n - i; m++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int m = 1; m <= n - i; m++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(dot);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int m = 1; m < (n - i) + x; m++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int m = 1; m < (n - i) + x; m++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(dot);
                    }
                    Console.WriteLine();
                }
            }

            //      .....*****.....                 <---
            //      .....*****.....
            if (n > 3)
            {
                for (int i = 1; i <= n / 2; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(dot);
                    }
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(star);
                    }
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(dot);
                    }

                    Console.WriteLine();
                }
            }

            //          *********                   <---
            for (int i = 1; i <= n * 3; i++)
            {
                Console.Write(star);
            }
            Console.WriteLine();

            //      .....*****.....                 <---
            //      .....*****.....
            if (n > 3)
            {
                for (int i = 1; i <= n / 2; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(dot);
                    }
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(star);
                    }
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(dot);
                    }
                    Console.WriteLine();
                }
            }

            /*      ....*..*..*....                 <---
                    ...*...*...*...
                    ..*....*....*.. 
                    .*.....*.....*.         */
            if (n == 3)
            {
                
                 for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int m = 1; m < i; m++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int m = 1; m < i; m++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write(dot);
                    }

                    Console.WriteLine();
                 }
            }

            /*      ...***...                       <---
                    ..*.*.*..
                    .*..*..*.           */

            else
            {

                for (int i = 2; i <= n; i++)
                {
                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int m = 1; m < i + x - 1; m++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int m = 1; m < i + x - 1; m++)
                    {
                        Console.Write(dot);
                    }
                    Console.Write(star);
                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write(dot);
                    }

                    Console.WriteLine();
                }

            }
            //      ....*....                       <---
            for (int j = 1; j <= n + x; j++)
            {
                Console.Write(dot);
            }
            Console.Write(star);
            for (int j = 1; j <= n + x; j++)
            {
                Console.Write(dot);
            }

            Console.WriteLine();
        }
    }
}
