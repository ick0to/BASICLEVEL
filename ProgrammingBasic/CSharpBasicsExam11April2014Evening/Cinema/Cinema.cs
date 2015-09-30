using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0;
            if (type == "Premiere")
            {
                price = 12.00;
            }
            else if (type == "Normal")
            {
                price = 7.50;
            }
            else if (type == "Discount")
            {
                price = 5.00;
            }

            double result = rows * columns * price;
            Console.WriteLine("{0:0.00} leva",result);
        }
    }
}
