using System;

namespace NewHouse
{
    class Problem15
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string roof = "*";
            string space = "-";
            string floor = "|";

            for (int i = 1; i <= number; i++)
            {
                if ((i % 2) == 0)
                {
                    continue;
                }
                for (int j = 1; j < number - i ; j++)
                {
                    
                    j++;
                    Console.Write(space);
                }
                for (int k = 1; k <= i; k++)
                {
                    
                    Console.Write(roof);
                }
                for (int j = 1; j < number - i; j++)
                {
                   
                    j++;
                    Console.Write(space);
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= number; i++)
            {
                Console.Write(floor);
                for (int j = 1; j <= number - 2; j++)
                {
                    Console.Write(roof);

                }
                Console.WriteLine(floor);
            }

        }
    }
}
