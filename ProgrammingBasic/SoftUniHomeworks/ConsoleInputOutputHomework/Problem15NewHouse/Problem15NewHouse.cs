using System;

namespace Problem15NewHouse
{
    class Problem15NewHouse
    {
        static void Loop(int length, char ch)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(ch);

            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Loop(N / 2, '-');
            Console.Write("*");
            Loop(N / 2, '-');
            Console.WriteLine();
            for (int j = 1; j < (N - (N / 2)); j++)
            {
                Loop(N / 2 - j, '-');
                Loop(N - (N / 2 - j) * 2, '*');
                Loop(N / 2 - j, '-');
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                Loop(1, '|');
                Loop(N - 2, '*');
                Loop(1, '|');
                Console.WriteLine();
            }
        }
    }
}
