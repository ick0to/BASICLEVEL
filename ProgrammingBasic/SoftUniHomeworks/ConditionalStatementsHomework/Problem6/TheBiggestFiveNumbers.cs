using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class TheBiggestFiveNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double biggest = 0;
            if (a >= b && a >= c && a >= d && a >= e )
            {
                biggest = a;
            }
            else if (b >= c && b >= d && b >= e)
            {
                biggest = b;
            }
            else if (c >= d && c >= e)
            {
                biggest = c;
            }
            else if (d >= e)
            {
                biggest = d;
            }
            else
            {
                biggest = e;
            }
            Console.WriteLine(biggest);
            
        }
    }
}
