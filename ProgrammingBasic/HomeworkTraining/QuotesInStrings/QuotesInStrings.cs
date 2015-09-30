using System;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string firsWay = "The \"use\" of quotations causes difficulties.";
            string secendWay = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(firsWay);
            Console.WriteLine(secendWay);
        }
    }
}
