using System;

namespace _11StudentCables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] size = new int[n];
            string[] measure = new string[n];
            int result = 0;
            int remainder = 0;
            int joining = 0;
            for (int i = 0; i < n; i++)
            {
                size[i] = int.Parse(Console.ReadLine());
                measure[i] = Console.ReadLine();

                if (measure[i] == "meters")
                {
                    size[i] = size[i] * 100;
                }
                
                if (size[i] >= 20)
                {
                    result = result + size[i];
                    joining++;
                }
                
            }
            joining = (joining - 1) * 3;
            result = result - joining;
            remainder = result;
            result = result / 504; //500cm + 2cm RJ + 2cm RJ
            remainder = remainder - (result * 504);
            Console.WriteLine(result);
            Console.WriteLine(remainder);


        }
    }
}
