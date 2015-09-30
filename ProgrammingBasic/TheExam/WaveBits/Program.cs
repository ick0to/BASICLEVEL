using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveBits
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong[] bitNumbers = new ulong[64];
            ulong[] newNumbers = new ulong[64];

            for (int i = 64 - 1; i >= 0 ; i--)
            {
                bitNumbers[i] = (n >> 63 - i) & 1;
                
            }
            int zero = 0;
            int one = 0;
            int x = 0;
            for (int i = 0; i < 64; i++)
            {
                if (zero < 2 && one < 2)
                {
                    if (bitNumbers[i] == 0)
                    {
                        zero++;
                        one = 0;
                    }
                    else
                    {
                        one++;
                        zero = 0;
                    }
                    x = i;

                }

            }
            foreach (var item in newNumbers)
            {
                Console.Write(item);
            }
        }
    }
}
