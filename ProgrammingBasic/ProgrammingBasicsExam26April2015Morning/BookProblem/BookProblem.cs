using System;

namespace BookProblem
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            int nPages = int.Parse(Console.ReadLine());
            int nCampingDays = int.Parse(Console.ReadLine());
            int nPagesOnDay = int.Parse(Console.ReadLine());
            int yers = 1;
            int mounths = 1;
            int days = 30;


            if (nCampingDays >= 30 || nPagesOnDay == 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                days = days - nCampingDays;
                days = days * nPagesOnDay;
                nPages = (int)Math.Ceiling((double)nPages / days);
                yers = nPages / 12;
                mounths = nPages % 12;
                if (yers == 0 && mounths == 0)
                {
                    Console.WriteLine("0 years 1 months");
                }
                else
                {
                    Console.WriteLine("{0} years {1} months", yers, mounths);
                }
            }
        }
    }
}
