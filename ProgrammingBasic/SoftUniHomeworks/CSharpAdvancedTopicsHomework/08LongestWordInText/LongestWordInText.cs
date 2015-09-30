using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08LongestWordInText
{
    class LongestWordInText
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(' ').ToList();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Count; i++)
            {
                StringBuilder a = new StringBuilder(text[i]);

                if (a.Length > result.Length)
                {
                    result = a;
                }
            }

            Console.WriteLine(result);
        }
    }
}
