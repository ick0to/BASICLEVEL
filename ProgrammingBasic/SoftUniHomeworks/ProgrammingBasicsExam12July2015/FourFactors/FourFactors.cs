using System;

namespace FourFactors
{
    class FourFactors
    {
        static void Main(string[] args)
        {
            double fG = double.Parse(Console.ReadLine()); 
            double fGA = double.Parse(Console.ReadLine());
            double threeP = double.Parse(Console.ReadLine());
            double tOV = double.Parse(Console.ReadLine());
            double oRB = double.Parse(Console.ReadLine());
            double oppDRB = double.Parse(Console.ReadLine());
            double fT = double.Parse(Console.ReadLine());
            double fTA = double.Parse(Console.ReadLine());

            double eFG = (fG + 0.5 * threeP) / fGA;
            double TOV = tOV / (fGA + 0.44 * fTA + tOV);
            double ORB = oRB /(oRB + oppDRB);
            double FT = fT / fGA;

            Console.WriteLine("eFG% {0:0.000}",eFG);
            Console.WriteLine("TOV% {0:0.000}", TOV);
            Console.WriteLine("ORB% {0:0.000}", ORB);
            Console.WriteLine("FT% {0:0.000}", FT);

        }
    }
}
