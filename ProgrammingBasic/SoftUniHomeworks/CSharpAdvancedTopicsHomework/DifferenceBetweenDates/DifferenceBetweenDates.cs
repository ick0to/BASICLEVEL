using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            string firstIn = Console.ReadLine();
            DateTime firstDate = Convert.ToDateTime(firstIn);

            string secendIn = Console.ReadLine();
            DateTime secendDate = Convert.ToDateTime(secendIn);

            TimeSpan days = secendDate - firstDate;
            double result = days.TotalDays;
            Console.WriteLine(result);
        }
    }
}
