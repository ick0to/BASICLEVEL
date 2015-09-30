using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            string hex = Convert.ToString(dec,16);
            Console.WriteLine(hex);
        }
    }
}
