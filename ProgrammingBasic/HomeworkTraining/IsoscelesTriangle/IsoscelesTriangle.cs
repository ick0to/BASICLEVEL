using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            char star = '\u002A';

            Console.WriteLine("Enter how much symbals to have pyramid. Minimum 3 symbals!");
            int numberSymbol = 0;

            do
            {
              numberSymbol = int.Parse(Console.ReadLine());

            } while (numberSymbol % 3 != 0);


            int count = 1;
            string emptySpace = new string(' ', numberSymbol / 3);

            Console.Write(emptySpace);
            Console.Write("{0}", star);
            Console.Write(emptySpace);
            Console.WriteLine();

            for (int i = 1, j = 1; i < numberSymbol / 3; i++, j = j + 2)
            {
                emptySpace = new string(' ', numberSymbol / 3 - i);
                Console.Write(emptySpace);
                Console.Write("{0}", star);
                string emptySpaceMiddle = new string(' ', j);
                Console.Write(emptySpaceMiddle);
                Console.Write("{0}", star);
                Console.Write(emptySpace);
                Console.WriteLine();
                count += 2;
            }
            for (int i = 0; i < numberSymbol-count; i++)
            {
                Console.Write("{0}", star);
                string emptySpaceDown = new string(' ', 1);
                Console.Write(emptySpaceDown);
            }
            Console.WriteLine();
           }
    }
}