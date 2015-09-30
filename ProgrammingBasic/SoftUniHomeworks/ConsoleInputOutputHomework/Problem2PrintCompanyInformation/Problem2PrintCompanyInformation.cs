using System;

namespace Problem2PrintCompanyInformation
{
    class Problem2PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Enter Company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Enter Phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Fax number: ");
            string faxNumber = Console.ReadLine();

            if (faxNumber==string.Empty)
            {
                faxNumber = "(no fax)";
            }

            Console.Write("Enter Web site: ");
            string webSite = Console.ReadLine();
            
            Console.Write("Enter Manager first name: ");
            string mFirstName = Console.ReadLine();
            
            Console.Write("Enter Manager last name: ");
            string mLastName = Console.ReadLine();
            
            Console.Write("Enter Manager age: ");
            string mAge = Console.ReadLine();
           
            Console.Write("Enter Manager phone: ");
            string mPhone = Console.ReadLine();

            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", mFirstName, mLastName, mAge, mPhone);

        }
    }
}
