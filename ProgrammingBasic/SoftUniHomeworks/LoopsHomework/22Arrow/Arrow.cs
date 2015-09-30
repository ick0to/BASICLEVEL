using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n/2; i++)
            {
                Console.Write(".");
            }
            for (int i = 1; i <= n ; i++)
            {
                Console.Write("#");
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            //-----------------------------------

            for (int i = 1; i <= n - 2; i++)
            {
                for (int k = 1; k <= n/2; k++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int j = 1; j <= n - 2; j++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int k = 1; k <= n / 2; k++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            //--------------------------------
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write("#");
            }
            Console.Write("#");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(".");
            }
            Console.Write("#");
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            //-------------------------------
            
            
            for (int i = 1; i < n; i++)
            {
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int j = 1; j <= (n * 2) - (i * 2) - 3; j++) 
                {
                    
                    Console.Write(".");
                }
                if (i != n - 1)
                {
                    Console.Write("#");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}
