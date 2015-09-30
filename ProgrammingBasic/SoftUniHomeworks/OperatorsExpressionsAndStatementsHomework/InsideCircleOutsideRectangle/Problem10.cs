using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideCircleOutsideRectangle
{
    class Problem10
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool k = x < 2.6 && x > - 0.6 && y < 2.6 && y >- 0.6 ;
            Console.WriteLine(k);

            bool r = y > 1.1 && y < -1.1 && x > 5.1 && x < -1.1;
            Console.WriteLine(r);

            if (k == true && r == false )
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
