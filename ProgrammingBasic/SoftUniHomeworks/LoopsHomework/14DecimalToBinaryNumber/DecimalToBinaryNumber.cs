using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            string bin = Convert.ToString(dec, 2);
            Console.WriteLine(bin);

        }
    }
}
