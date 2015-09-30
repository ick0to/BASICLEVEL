using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            //Declarirame 2 promenlivi.
            string hello = "Hello";
            string world = "World";

            //Obedinqvame promenlivite i ostavqme mqsto mejdu tqh.
            object all = hello + " " + world;

            //Preobrazuvame ot "object" na "string".
            string together = (string)(all);

            //Izvejdane v konzolata rezultatite.
            Console.WriteLine("{0}!", all);
            Console.WriteLine("{0}!", together);


        }
    }
}
