using System;

namespace _20ExamSchedule
{
    class ExamSchedule
    {
        static void Main(string[] args)
        {
            int h1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            int h2 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());

            if (format == "PM")
            {
                h1 = h1 + 12;

                if (h1 == 24)
                {
                    h1 = 0;
                }
            }

            DateTime Time = new DateTime(2014, 04, 09, h1, m1, 0);
            DateTime result = Time.AddHours(h2).AddMinutes(m2);
            Console.WriteLine("{0:hh:mm:tt}", result);

            
        }
    }
}
