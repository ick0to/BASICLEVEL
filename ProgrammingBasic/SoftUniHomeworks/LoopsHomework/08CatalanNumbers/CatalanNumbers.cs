using System;
using System.Numerics;

namespace _08CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (1 < n && n < 100)
            {
                BigInteger numerator = 1;
                BigInteger denominator = 1;
                BigInteger result = 1;
                for (int k = 2; k <= n; k++)
                {
                    numerator *= n + k;
                    denominator *= k;
                }
                result = numerator / denominator;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("out of range");
            }      
        }
    }
}
