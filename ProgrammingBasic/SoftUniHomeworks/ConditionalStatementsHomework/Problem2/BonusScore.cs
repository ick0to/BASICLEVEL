﻿using System;

namespace Problem2
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score == 1 || score == 2 || score == 3)
            {
                Console.WriteLine(score * 10);
            }
            else if (score == 4 || score == 5 || score == 6)
            {
                Console.WriteLine(score * 100);
            }
            else if (score == 7 || score == 8 || score == 9)
            {
                Console.WriteLine(score * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
