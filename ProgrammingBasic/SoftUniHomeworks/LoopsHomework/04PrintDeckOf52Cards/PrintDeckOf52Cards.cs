using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PrintDeckOf52Cards
{
    class PrintDeckOf52Cards
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
            }
                for (int j = 1; j <= 4; j++)
                {
                    switch (j)
                    {
                        case 1: Console.Write("J♣ J♦ J♥ J♠"); break;
                        case 2: Console.Write("Q♣ Q♦ Q♥ Q♠"); break;
                        case 3: Console.Write("K♣ K♦ K♥ K♠"); break;
                        case 4: Console.Write("A♣ A♦ A♥ A♠"); break;
                    }
                    Console.WriteLine();
                }


        }
    }
}
