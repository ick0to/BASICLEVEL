using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c && b != c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else if (c > b)
                {
                Console.WriteLine("{0} {1} {2}", a, c, b);
                    
                }
                
            }
            else if (b > a && b > c && a != c)
            {
                if (a > c)
                {
                Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else if (c > a)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else if (c > a && c > b && a != b)
            {
                if (a > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else if (b > a)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
            else if (a > b && a == c || a > b && b == c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            else if (a > c && a == b || a > c && c == b)
            {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if (b > a && b == c || b > a && c == a)
            {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            else if (b > c && b == a || b > c && a == c)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            else if (c > a && c == b || c > a && a == b)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            else if (c > b && c == a || c > b && a == b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else if (a == b && a == c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
