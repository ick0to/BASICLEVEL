using System;

namespace LongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2,-3,4,-5,6,-7,8,-9,10,-11");

            int number;
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    number = i;
                }
                else
                {
                    number = i * -1;
                }
                Console.Write(number + ",");
            }
        }
    }
}
