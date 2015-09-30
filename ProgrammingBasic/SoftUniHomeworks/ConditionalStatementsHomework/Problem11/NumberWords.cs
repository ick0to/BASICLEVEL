using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class NumberWords
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Sevan"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                case 10: Console.WriteLine("Ten"); break;
                case 11: Console.WriteLine("Eleven"); break;
                case 12: Console.WriteLine("Twelve"); break;
                case 13: Console.WriteLine("Thirteen"); break;
                case 14: Console.WriteLine("Fourteen"); break;
                case 15: Console.WriteLine("Fifteen"); break;
                case 16: Console.WriteLine("Sixteen"); break;
                case 17: Console.WriteLine("Seventeen"); break;
                case 18: Console.WriteLine("Eighteen"); break;
                case 19: Console.WriteLine("Nineteen"); break;
                    
            }
                //---------------------


            int hundred = number / 100;
            int ten2 = number / 10 / 10;
            switch (hundred)
            {
                case 1: Console.Write("One handred and "); break;
                case 2: Console.Write("Two handred and "); break;
                case 3: Console.Write("Three handred and "); break;
                case 4: Console.Write("Four handred and "); break;
                case 5: Console.Write("Five handred and "); break;
                case 6: Console.Write("Six handred and "); break;
                case 7: Console.Write("Seven handred and "); break;
                case 8: Console.Write("Eight handred and "); break;
                case 9: Console.Write("Nine handred and "); break;
            }
            switch (ten2)
            {
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sexty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninty "); break;
            }
            if (number >= 20)
            {
                int ten = number / 10;
                int one = number % 10;
                switch (ten)
                {
                    case 2: Console.Write("Twenty "); break;
                    case 3: Console.Write("Thirty "); break;
                    case 4: Console.Write("Fourty "); break;
                    case 5: Console.Write("Fifty "); break;
                    case 6: Console.Write("Sexty "); break;
                    case 7: Console.Write("Seventy "); break;
                    case 8: Console.Write("Eighty "); break;
                    case 9: Console.Write("Ninty "); break;
                }
                switch (one)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("sevan"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            Console.WriteLine();
        }
    }
}
