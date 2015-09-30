using System;
using System.Collections.Generic;
using System.Linq;

namespace _21OddEvenElements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(item => decimal.Parse(item)).ToArray();
            List<decimal> odd = new List<decimal> ();
            List<decimal> even = new List<decimal> ();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    odd.Add(numbers[i]);
                }
                else if (i % 2 != 0)
                {
                    even.Add(numbers[i]);
                }
            }
                decimal oddMax = odd.Max();
                decimal oddMin = odd.Min();
                decimal oddSum = odd.Sum();
            if (numbers.Length > 1)
            {
                decimal evenMax = even.Max();
                decimal evenMin = even.Min();
                decimal evenSum = even.Sum();
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum,
                    (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
            }
            else if (numbers.Length == 0)
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else if (numbers.Length == 1)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddSum, (double)oddMin, (double)oddMax);
            }
        }
    }
}
