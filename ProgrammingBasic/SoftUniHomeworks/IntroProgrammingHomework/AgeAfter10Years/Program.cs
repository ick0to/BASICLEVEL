using System;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
            DateTime yourBirthday = DateTime.Parse(Console.ReadLine());
            var result = DateTime.Today.Subtract(yourBirthday).Ticks;
            Console.WriteLine("Now you are {0} years old.", new DateTime(result).Year - 1);
            Console.WriteLine("After 10 years you will be {0} years old.", new DateTime(result).AddYears(10).Year - 1);
        }
    }
}
