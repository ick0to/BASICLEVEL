using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = Console.ReadLine().Split();
            double convert = 0;
            double sum = 0;
            
            
            for (int i = 0; i < array.Length; i++)
			{
                convert = Convert.ToDouble(array[i]);
                sum += convert;
            }

                Console.WriteLine(convert);
            

        }
    }
}
