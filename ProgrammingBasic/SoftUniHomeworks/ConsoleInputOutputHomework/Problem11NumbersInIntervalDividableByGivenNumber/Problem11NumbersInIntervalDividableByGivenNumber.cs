using System;

namespace Problem11NumbersInIntervalDividableByGivenNumber
{
    class Problem11NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter (start) number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter (end) number: ");
            int end = int.Parse(Console.ReadLine());
            int p = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine("start = {0}; end = {1}; p = {2};", start, end, p);
        }
    }
}
