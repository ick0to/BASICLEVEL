using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 1;

            if (1 <= n && n <= 20)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int k = 1; k <= n; k++)
                    {
                        Console.Write("{0} ", m);
                        m++;   
                    }
                    m = m - (n - 1);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("out of range");
            }
        }
    }
}
