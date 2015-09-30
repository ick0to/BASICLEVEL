using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            try
            {
                string inTime = Console.ReadLine();
                DateTime time = Convert.ToDateTime(inTime);
                DateTime beerTime = DateTime.Parse("1:00 PM");
                DateTime nonBeerTime = DateTime.Parse("3:00 AM");

                if (time >= beerTime || time < nonBeerTime )
                {
                    Console.WriteLine("beer Time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
