using System;

namespace Problem1
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double a1 = 0;
            double b1 = 0;
            if (a > b)
            {
                a1 = b;
                b1 = a;
                Console.WriteLine("{0}  {1}", a1, b1);
            }
            else
            {
                Console.WriteLine("{0}  {1}", a, b);
            }
        }
    }
}
