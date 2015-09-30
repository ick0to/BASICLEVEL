using System;

namespace Problem5FormattingNumbers
{
    class Problem5FormattingNumbers
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());

            if (numberOne >= 0 && numberOne <= 500)
            {

                float numberTwo = float.Parse(Console.ReadLine());
                float numberThre = float.Parse(Console.ReadLine());

                string binary = Convert.ToString(numberOne, 2);
                Console.WriteLine("|{0,-10:X}|{1,0}|{2,10:0.00}|{3:0.000}|", numberOne, binary.PadLeft(10,'0'), numberTwo, numberThre);

            }
            else
            {
                Console.WriteLine("Not in range! 0...500");
            }

            
        }
    }
}
