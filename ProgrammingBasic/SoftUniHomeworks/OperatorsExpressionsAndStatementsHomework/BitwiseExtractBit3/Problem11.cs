﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBit3
{
    class Problem11
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int i = 1;
            int mask = i << p;
            int result = (n & mask);

            if (result != 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
