using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofElements
{
    class Problem14
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
                array = Console.ReadLine().Split();
            long[] convert = Array.ConvertAll(array, long.Parse);
            long temp = 0;

            //if (2 < n||n > 1000)
            //{
            //}
            //else
            //{
                //Console.WriteLine("You are idiat!!!");
            //}  
  
            for (int i = 0; i < array.Length; i++)
            {
               
                    
                }
                Console.WriteLine(convert[i]);
            }

        }
    }
}
