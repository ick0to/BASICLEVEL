using System;
using System.Collections.Generic;

namespace Illuminati
{
    class Illuminati
    {
        static void Main(string[] args)
        {
            string inString = Console.ReadLine();
            List<char> revers = new List<char> { };
            int sum = 0;
            int all = 0;
            for (int i = 0; i < inString.Length; i++)
			{
                revers.Add(inString[i]);
			}

            for (int i = 0; i < revers.Count; i++)
            {
                switch (revers[i])
                {
                    case 'A': sum = sum + 65; all = all + 1; break;
                    case 'E': sum = sum + 69; all = all + 1; break;
                    case 'I': sum = sum + 73; all = all + 1; break;
                    case 'O': sum = sum + 79; all = all + 1; break;
                    case 'U': sum = sum + 85; all = all + 1; break;
                    case 'a': sum = sum + 65; all = all + 1; break;
                    case 'e': sum = sum + 69; all = all + 1; break;
                    case 'i': sum = sum + 73; all = all + 1; break;
                    case 'o': sum = sum + 79; all = all + 1; break;
                    case 'u': sum = sum + 85; all = all + 1; break;
                }
            }
            Console.WriteLine(all);
            Console.WriteLine(sum);
        }
    }
}
