using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is your gender female? Enter YES or NO. ");
            string gender = Console.ReadLine();
            bool isFemalel = (gender == "yes");
            Console.WriteLine(isFemalel);


        }  
    }
}
