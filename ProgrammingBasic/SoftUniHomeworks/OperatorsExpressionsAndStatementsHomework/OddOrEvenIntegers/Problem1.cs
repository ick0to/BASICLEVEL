using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class Problem1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool odd = (n % 2) == 0;
            Console.WriteLine(!odd);
        }
    }
}
