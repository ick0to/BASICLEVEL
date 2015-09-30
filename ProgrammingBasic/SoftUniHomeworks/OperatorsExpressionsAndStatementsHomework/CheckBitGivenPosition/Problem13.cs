using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitGivenPosition
{
    class Problem13
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int i = 1;
            int mask = i << p;
            int result = (n & mask);

            if (result != 0)
            {
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(16,'0'));
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
                Console.WriteLine(false);
            }
        }
    }
}
