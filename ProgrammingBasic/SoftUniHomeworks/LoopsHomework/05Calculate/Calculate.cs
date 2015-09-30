using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            float sum = 1;
            float factorial = 1;
            int power = x;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                sum = sum + factorial / x;
                
                x = x * power;
            }
            Console.WriteLine("{0 :F5}", sum);
        }
    }
}
