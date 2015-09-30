using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(item => int.Parse(item)).ToList();
            List<int> secendList = Console.ReadLine().Split(' ').Select(item => int.Parse(item)).ToList();

            for (int i = 0; i < secendList.Count; i++)
            {
                int n = secendList[i];
                firstList.RemoveAll(item => item == n);
            }
            
            firstList.AddRange(secendList);
            firstList.Sort();
            foreach (var item in firstList)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
    }
}
