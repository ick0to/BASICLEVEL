using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            int n = Convert.ToInt32(bin, 2);
            Console.WriteLine(n);

        }
    }
}
