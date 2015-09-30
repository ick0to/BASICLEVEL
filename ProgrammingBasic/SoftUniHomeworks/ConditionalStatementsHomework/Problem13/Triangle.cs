using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());

            double ab = Math.Sqrt(((a1 - b1)*(a1 - b1)) + ((a2 - b2)*(a2 - b2)));
            double bc = Math.Sqrt(((b1 - c1)*(b1 - c1)) + ((b2 - c2)*(b2 - c2)));
            double ca = Math.Sqrt(((c1 - a1)*(c1 - a1)) + ((c2 - a2)*(c2 - a2)));

            double p = (ab + bc + ca) / 2;
            double area = Math.Sqrt((p * (p - ab) * (p - bc) * (p - ca)));

            if ((a1 - c1) * (b2 - c2) - (b1 - c1) * (a2 - c2) != 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0:0.00}",area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:0.00}",ab);
            }

            


        }
    }
}
