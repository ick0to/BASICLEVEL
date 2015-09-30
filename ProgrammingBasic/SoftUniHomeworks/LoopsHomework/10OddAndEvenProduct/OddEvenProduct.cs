using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10OddAndEvenProduct
{
    class OddEvenProduct
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            int odd = 1;
            int even = 1;

            for (int i = 0; i < array.Length; i++)
            {
                int n = int.Parse(array[i]);
                if (i % 2 == 0 || i == 0)
                {
                    odd = odd * n;
                }
                else
                {
                    even = even * n;
                }
            }
            if (odd == even)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}",odd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd procuct = {0}", odd);
                Console.WriteLine("even procuct = {0}", even);
            }
        }
    }
}
