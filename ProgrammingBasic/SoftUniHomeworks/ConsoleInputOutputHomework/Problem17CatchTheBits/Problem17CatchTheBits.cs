using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17CatchTheBits
{
    class Problem17CatchTheBits
    {
        static void Main(string[] args)
        {
            //Reed to console how meny nambers
            int n = int.Parse(Console.ReadLine());
            //Reed to console 
            int step = int.Parse(Console.ReadLine());

            //Create array
            int[] array = new int[n];
            string binary;
            string allBinary;
            string bResult;

            //crawl the array
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Reed the array
            for (int index = 0; index < array.Length; index++)
            {
                binary = Convert.ToString(array[index], 2);
                allBinary = binary.PadLeft(8, '0');

                for (int i = 1; i <= allBinary.Length; i = i + step)
                {

                    allBinary = Convert.ToString(allBinary[i]);
                    allBinary = allBinary + 0;
                }
                bResult = allBinary.PadRight(8, '0');
                Console.Write(bResult);

            }

            Console.WriteLine();
            
        }
    }
}
