using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your FirstName.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your LastName.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your Age.");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Gender.");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter your Personal ID.");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Unique Employee number.");
            int und = int.Parse(Console.ReadLine());


            Console.WriteLine("First Name: {0} ", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", id);
            Console.WriteLine("Unique Employee number: {0}", und);

        }
    }
}
