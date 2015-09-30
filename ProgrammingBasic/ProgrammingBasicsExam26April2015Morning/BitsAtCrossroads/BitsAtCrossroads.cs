using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAtCrossroads
{
    class BitsAtCrossroads
    {
        static void Main(string[] args)
        {
            int n = 8; // int.Parse(Console.ReadLine());
            List<string> position = new List<string> { }; 
            string inString = "";

            int x = 0;

            while (inString != "end")
            {
                position.Add(inString);
                inString = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                }
            }
            foreach (var item in position)
            {
                Console.WriteLine(item);
            }
        }
    }
}
