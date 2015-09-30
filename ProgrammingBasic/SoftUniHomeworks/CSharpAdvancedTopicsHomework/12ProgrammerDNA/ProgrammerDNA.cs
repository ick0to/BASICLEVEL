using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ProgrammerDNA
{
    class ProgrammerDNA
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string letter = Console.ReadLine();
            string alph = "ABCDEFG";
            int let = 0;
            switch (letter)
            {
                case "A": let = 0; break;
                case "B": let = 1; break;
                case "C": let = 2; break;
                case "D": let = 3; break;
                case "E": let = 4; break;
                case "F": let = 5; break;
                case "G": let = 6; break;

            }
            //-----------------------------------
            int dot = 3;
            int to7 = 0;
            int star = -1;
            int dot2 = 1;
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                to7++;
                if (to7 == 8)
                {
                    dot = 3;
                    to7 = 1;
                    star = -1;
                    dot2 = 1;
                }

                if (to7 <= 4)
                {
                    star = star + 2;
                    for (int j = dot; j >= 1; j--)
                    {
                        Console.Write(".");
                    }
                    for (int k = 1; k <= star; k++)
                    {
                        for (int f = 0; f < k; f++)
                        {
                            Console.Write("*");
                            let++;
                            if (let > 6)
                            {
                                let = 0;
                            }
                        }
   
                    }
                    for (int j = dot; j >= 1; j--)
                    {
                        Console.Write(".");
                    }
                    dot--;
                }
                else if (to7 > 4 && to7 < 8)
                {

                    star = star - 2;
                    for (int j = 1; j <= dot2; j++)
                    {
                        Console.Write(".");
                    }
                    for (int k = star; k >= 1; k--)
                    {

                        for (int j = 2; j >= 0; j--)
                        {
                            for (int f = 0; f < 1 + 2 * j; f++)
                            {
                                Console.Write("*");
                                let++;
                                if (let > 6)
                                {
                                    let = 0;
                                }
                            }
                        }
                    }
                    for (int j = 1; j <= dot2; j++)
                    {
                        Console.Write(".");
                    }
                    dot2++;
                }
                if (to7 < 8)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
