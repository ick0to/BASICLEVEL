using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program17
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine()); // holidays
            int h = int.Parse(Console.ReadLine()); // hometown
            double plays = 0;
            double leap = 0;
            int weekends = 48;
            weekends = weekends - h;
            weekends = weekends * 3 / 4;
            h = h * 2 / 3;

            if (year == "leap")
            {
                leap = 5.97;
            }

            plays = h + weekends + p + leap;
            plays = Math.Floor(plays);
            Console.WriteLine(plays);
        }    
    }
}
