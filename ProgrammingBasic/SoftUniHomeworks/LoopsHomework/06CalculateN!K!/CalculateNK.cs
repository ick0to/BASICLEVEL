using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06CalculateN_K_
{
    class CalculateNK
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            ulong result = 1;
            if (1 < k && k < n && n < 100 )
            {
                for (int i = k + 1; i <= n; i++)
                {
                    result = result * (ulong)i;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("out of range");
            }

        }
    }
}
