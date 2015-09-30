using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11RandomNumbersInGivenRange
{
    class RandomNumbersGivenRange
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            if (min <= max)
            {
                Random random = new Random();
                for (int i = 0; i < count; i++)
                {
                    Console.Write("{0} ", random.Next(min, max + 1));
                }
            }
            else
            {
                Console.WriteLine("incorrect input");
            }    
        }
    }
}
