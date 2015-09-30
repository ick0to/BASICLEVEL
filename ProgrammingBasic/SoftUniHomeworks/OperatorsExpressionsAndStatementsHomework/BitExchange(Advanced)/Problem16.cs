using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange_Advanced_
{
    class Problem16
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine()); //3
            int q = int.Parse(Console.ReadLine()); //24
            int k = int.Parse(Console.ReadLine()); //indeks
            long n2 = n;
            int mask = 0;
            
            long result = 0;
            long result2 = 0;
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            
            for (int i = p; i <p + k; i++)
            {
                int i2 = i;
                mask = 1 << i;
                result = (n & mask) >> i;
                //Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
                if (result == 0)
                {
                    n2 = n2 & (~(1 << i2 - p + q));
                }
                else if (result == 1)
                {
                    n2 = n2 | (1 << i2 - p + q);
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                

            }

            for (int i = q; i < q + k; i++)
            {
                int i2 = i;
                mask = 1 << i;
                result2 = (n & mask) >> i;
                
                if (result2 == 0)
                {
                    n2 = n2 & (~(1 << i2 + p - q));
                }
                else if (result2 == 1)
                {
                    n2 = n2 | (1 << i2 + p - q);
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                
            }

           
            Console.WriteLine();
            Console.WriteLine(Convert.ToString(n2, 2).PadLeft(32, '0'));
            Console.WriteLine(n2);


        }
    }
}
