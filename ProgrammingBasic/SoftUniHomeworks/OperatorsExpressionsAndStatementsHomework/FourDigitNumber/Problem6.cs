using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class Problem6
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n4 = n % 10;
            int n3 = (n / 10) % 10;
            int n2 = ((n / 10) / 10) % 10;
            int n1 = (((n / 10) / 10) / 10) % 10;

            int sum = n4 + n3 + n2 + n1;
            string reversed = "" + n4 + n3 + n2 + n1;
            string lastFront = "" + n4 + n1 + n2 + n3;
            string secendThird = "" + n1 + n3 + n2 + n4;

            Console.WriteLine(sum);
            Console.WriteLine(reversed);
            Console.WriteLine(lastFront);
            Console.WriteLine(secendThird);
        }
    }
}
