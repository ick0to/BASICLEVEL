using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            long dec = Convert.ToInt64(hex, 16);
            Console.WriteLine(dec);
        }
    }
}
