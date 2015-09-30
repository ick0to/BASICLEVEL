using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? number = null;
            int number1 = 5;
            double number2 = 3.14;
            Console.WriteLine("Number1 = {0}", number.HasValue);
            Console.WriteLine("Number2 = {0}", number1);
            Console.WriteLine("Number3 = {0}", number2);

            number = number1;
            Console.WriteLine("Number1 = {0}", number);

            
            double newDeclaration = number2;
            
            Console.WriteLine("Number1 = {0}", newDeclaration);


        }
    }
}
