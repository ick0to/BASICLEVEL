using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Problem6
    {
        static void Main(string[] args)
        {
            double a = float.Parse(Console.ReadLine());
            double b = float.Parse(Console.ReadLine());
            double c = float.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double x1,x2;

            if (d > 0)
            {
                x1 = (-b - System.Math.Sqrt(d)) / (2 * a);
                x2 = (-b + System.Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            else if (d == 0)
            {
                x1 = (-b - System.Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1=x2={0}",x1);
            }
            else
            {
                Console.WriteLine("No real roots!");
            }
            


        }
    }
}
