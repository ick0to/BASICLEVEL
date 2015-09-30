using System;

namespace Problem4NumberComparer
{
    class Problem4NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double greater = (numberOne > numberTwo) ? numberOne : numberTwo;
            Console.WriteLine("Greter number is: {0}", greater);
        } 
    }
}
