using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class Problem8
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(false);
            }
            else
            {
                int count = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                bool prime = true;
                if (count > 2)
                {
                    prime = false;
                }
                Console.WriteLine(prime);
            }

           
        }
    }
}
