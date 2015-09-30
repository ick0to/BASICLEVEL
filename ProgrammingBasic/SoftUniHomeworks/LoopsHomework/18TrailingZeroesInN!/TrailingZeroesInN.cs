using System;
using System.Linq;
using System.Numerics;
namespace _18TrailingZeroesInN_
{
    class TrailingZeroesInN
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int zeroes = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            
            BigInteger[] array = Array.ConvertAll(factorial.ToString().ToArray(), x=>(BigInteger)x - 48);
            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == 0)
                {
                    zeroes = zeroes + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(zeroes);
        }
    }
}
