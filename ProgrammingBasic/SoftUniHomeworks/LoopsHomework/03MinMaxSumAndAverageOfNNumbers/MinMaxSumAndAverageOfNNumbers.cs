using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int min = 0;
            int max = 0;
            int sum = 0;
            double avg = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            min = array.Min();
            max = array.Max();
            sum = array.Sum();
            avg = array.Average();

            Console.WriteLine("min = {0}",min);
            Console.WriteLine("max = {0}",max);
            Console.WriteLine("sum = {0}",sum);
            Console.WriteLine("avg = {0:0.00}",avg);

        }
    }
}
