using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LongestNonDecreasingSubsequence
{
    class LongestNonDecreasingSubsequence
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                 .ReadLine()
                 .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(item => int.Parse(item))
                 .ToArray();

            int smoll = numbers.Max();
            List<int> list = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smoll)
                {
                    
                    smoll = numbers[i];
                    list.Add(numbers[i]);
                }
            }


        }
    }
}
