using System;

namespace Problem8NumbersFrom1ToN
{
    class Problem8NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("  Sum: ");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("   {0}", i);
            }
        }
    }
}
