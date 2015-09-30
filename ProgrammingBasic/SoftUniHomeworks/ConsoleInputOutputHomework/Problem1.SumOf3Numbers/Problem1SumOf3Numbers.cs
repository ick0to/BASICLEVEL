using System;

namespace Problem1SumOf3Numbers
{
    class Problem1SumOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three real numbers: ");

            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum = {0}", numberOne + numberTwo + numberThree);


        }
    }
}
