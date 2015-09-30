using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFootballStatistician
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay = double.Parse(Console.ReadLine());
            string match = "";
            int s = 0;
            List<int> result = new List<int> { };
            List<string> winers = new List<string> { };
            string[] array;
            while (match != "End of the league.")
            {
                match = Console.ReadLine();
                if (match != "End of the league.")
                { }
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(winers[i]);
                Console.WriteLine(result[i]);
            }

        }
    }
}
