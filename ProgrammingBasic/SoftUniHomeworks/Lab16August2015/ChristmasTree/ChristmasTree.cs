using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            //----------------------------up
            for (int i = 1; i <= n; i++)
            {
                
                    if (i % 2 == 0)
                    {
                        continue;
                    } 
                //-------------------------left
                for (int j = 0; j <= n * 2 - i; j++)
                {
                    Console.Write("'");
                    j++;
                }
                //------------------------midel
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("^");
                }
                //------------------------right
                for (int j = 0; j <= n * 2 - i; j++)
                {
                    Console.Write("'");
                    j++;
                }
                Console.WriteLine();
            }
            //-------------------------- mid
            for (int i = 2; i <= n + 2; i++)
            {

                if (i % 2 == 0)
                {
                    continue;
                }
                //-------------------------left
                for (int j = 0; j <= n * 2 - i; j++)
                {
                    Console.Write("'");
                    j++;
                }
                //------------------------midel
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("^");
                }
                //------------------------right
                for (int j = 0; j <= n * 2 - i; j++)
                {
                    Console.Write("'");
                    j++;
                }
                Console.WriteLine();
            }
            //---------------------------bottom
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("'");
                }
                Console.Write("| |");
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("'");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n*2 +1; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
