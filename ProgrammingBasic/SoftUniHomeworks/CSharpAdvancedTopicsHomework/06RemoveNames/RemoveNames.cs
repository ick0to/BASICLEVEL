using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> remuveList = Console.ReadLine().Split(' ').ToList();

            for (int j = 0; j < remuveList.Count; j++)
            {
                list.RemoveAll(item => item == remuveList[j]);
            }

            foreach (var item in list)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
    }
}
