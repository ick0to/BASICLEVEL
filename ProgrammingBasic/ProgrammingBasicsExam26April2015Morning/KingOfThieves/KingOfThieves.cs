using System;

namespace KingOfThieves
{
    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            n = n + 2;
            for (int i = 1; i <= n /2; i++)
            {
                for (int j = 1; j <= n/2 - i; j++)
                {
                    Console.Write("-");
                }
                if (i <= n/2)
                {
                    for (int k = 1; k <=i + i - 1; k++)
                    {
                        Console.Write(symbol);
                    }
                }
                
                for (int j = 1; j <= n / 2 - i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

            }
            for (int i = 1; i < n / 2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-");
                }
                if (i <= n / 2)
                {

                    for (int k = 1; k <= n - 2 - i - i; k++)
                    {
                        Console.Write(symbol);
                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

            }
            

            
        }
    }
}
