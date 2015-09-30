using System;

namespace Problem3CirclePerimeterAndArea
{
    class Problem3CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            double radius = double.Parse(Console.ReadLine());

            double pI = Math.PI;
            double area = pI * radius * radius;
            double perimeter = 2 * pI * radius;
            
            Console.WriteLine("Area: {0,13:0.00}",area);
            Console.WriteLine("Perimeter: {0,8:0.00}",perimeter);
        }
    }
}
