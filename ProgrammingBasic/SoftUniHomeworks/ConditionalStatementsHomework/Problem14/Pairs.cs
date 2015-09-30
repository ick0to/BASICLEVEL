using System;
using System.Linq;

namespace Problem14
{
    class Pairs
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int result = 0;
            int[] array = Array.ConvertAll(tokens, int.Parse);
            int n1 = array.Length;
            int n = n1 / 2;
            int[] sum = new int [n];
            
            for (int i = 0; i < sum.Length; i++)
            {
                int x = i + i;
                int y = i + i + 1;
                sum[i] = array[x] + array[y];
                
            }
            for (int i = 0; i < n/2; i++)
            {
                int x = i + i;
                int y = i + i + 1;
                result = result +  sum[x] - sum[y];
            }
            int max = sum.Max();
            int min = sum.Min();
            if (max == min)
            {
                Console.WriteLine("Yes, value={0}", min);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}",result * (-1));
            }
            
        }
    }
}
