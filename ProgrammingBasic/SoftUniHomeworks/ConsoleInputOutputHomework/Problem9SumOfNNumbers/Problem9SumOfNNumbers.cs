using System;

namespace Problem9SumOfNNumbers
{
    class Problem9SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n number: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double number = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter more n numbers: ");
                number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("Result: {0}", sum);
        }
    }
}
