using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class PlayIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Please enter a int:"); int integer = int.Parse(Console.ReadLine()); 
                    Console.WriteLine(integer + 1); break;
                case 2: Console.WriteLine("Please enter a double:"); double doub = double.Parse(Console.ReadLine()); 
                    Console.WriteLine(doub + 1); break;
                case 3: Console.WriteLine("Please enter a string:"); string str = Console.ReadLine(); 
                    Console.WriteLine("{0}*", str); break;
                default: Console.WriteLine("Next time choose 1, 2 or 3!");
                    break;
            }
        }
    }
}
