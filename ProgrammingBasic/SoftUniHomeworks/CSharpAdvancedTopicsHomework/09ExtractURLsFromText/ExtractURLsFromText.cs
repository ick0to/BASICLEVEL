using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(' ').ToList();

            foreach (var item in text)
            {
                if (item.Contains("http://") || item.Contains("www."))
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
