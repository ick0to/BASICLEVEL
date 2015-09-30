using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class Problem5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = n / 100 %10;
            
            bool digit = (n1 == 7);
            Console.WriteLine(digit);
        }
    }
}
