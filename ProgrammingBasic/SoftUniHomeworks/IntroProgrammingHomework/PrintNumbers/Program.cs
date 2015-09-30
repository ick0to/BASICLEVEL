using System;

namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.WriteLine("101");
            Console.WriteLine("1001");

            string[] array = { "1", "101", "1001" };
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}
