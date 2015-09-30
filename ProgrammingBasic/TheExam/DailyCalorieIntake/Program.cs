using System;

namespace DailyCalorieIntake
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int hInch = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int wPerWeek = int.Parse(Console.ReadLine());


            double heightCm = (double)hInch * 2.54;
            double weightKg = (double)weight / 2.2;

            double bmr = 0;
            if (gender == "m")
            {
                double bmrM = 66.5 + (13.75 * weightKg) + (5.003 * heightCm) - (6.755 * age);
                bmr = bmrM;
            }
            else if (gender == "f")
            {
                double bmrF = 655 + (9.563 * weightKg) + (1.850 * heightCm) - (4.676 * age);
                bmr = bmrF;
            }

            double dci = 0;
            if (wPerWeek <= 0)
            {
                dci = bmr * 1.2;
            }
            else if (wPerWeek >= 1 && wPerWeek <= 3)
            {
                dci = bmr * 1.375;
            }
            else if (wPerWeek >= 4 && wPerWeek <= 6)
            {
                dci = bmr * 1.55;
            }
            else if (wPerWeek >= 7 && wPerWeek <= 9)
            {
                dci = bmr * 1.725;
            }
            else if (wPerWeek > 9)
            {
                dci = bmr * 1.9;
            }
            dci = Math.Floor(dci);
            Console.WriteLine("{0:0}",dci);
        }
    }
}
