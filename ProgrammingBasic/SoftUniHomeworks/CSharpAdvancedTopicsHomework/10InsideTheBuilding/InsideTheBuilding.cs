using System;

namespace _10InsideTheBuilding
{
    class InsideTheBuilding
    {
        static void Main(string[] args)
        {

            int h = int.Parse(Console.ReadLine()); //2

            int x1 = int.Parse(Console.ReadLine()); //3         outside
            int y1 = int.Parse(Console.ReadLine()); //10
            
            int x2 = int.Parse(Console.ReadLine()); //0         outside
            int y2 = int.Parse(Console.ReadLine()); //6

            int x3 = int.Parse(Console.ReadLine()); //2         inside
            int y3 = int.Parse(Console.ReadLine()); //2

            int x4 = int.Parse(Console.ReadLine()); //3         inside
            int y4 = int.Parse(Console.ReadLine()); //1

            int x5 = int.Parse(Console.ReadLine()); //6         inside
            int y5 = int.Parse(Console.ReadLine()); //0

            if (y1 > h*4 || y1 < h - h || x1 < h - h || x1 > h*3 || y1 > h && x1 < h || y1 > h && x1 > h*2 )
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }

            if (y2 > h * 4 || y2 < h - h || x2 < h - h || x2 > h * 3 || y2 > h && x2 < h || y2 > h && x2 > h * 2)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }

            if (y3 > h * 4 || y3 < h - h || x3 < h - h || x3 > h * 3 || y3 > h && x3 < h || y3 > h && x3 > h * 2)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }

            if (y4 > h * 4 || y4 < h - h || x4 < h - h || x4 > h * 3 || y4 > h && x4 < h || y4 > h && x4 > h * 2)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }

            if (y5 > h * 4 || y5 < h - h || x5 < h - h || x5 > h * 3 || y5 > h && x5 < h || y5 > h && x5 > h * 2)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }
        }
    }
}
