using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTheTorches
{
    class LightTheTorches
    {
        static void Main(string[] args)
        {
            int n = 5;// int.Parse(Console.ReadLine());

            string series = Console.ReadLine();
            
            List<string> commands = new List<string> { };
            List<int> comInt = new List<int> { };
            string input = Console.ReadLine();
            while (input != "END")
            {
                commands.Add(input);
                input = Console.ReadLine();

            }
            foreach (var item in commands)
            {
                
            }
        }
    }
}
