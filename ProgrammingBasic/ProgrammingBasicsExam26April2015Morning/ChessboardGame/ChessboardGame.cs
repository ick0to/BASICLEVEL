using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChessboardGame
{
    class ChessboardGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string inString = Console.ReadLine();
            List<char> black = new List<char> { };
            List<char> white = new List<char> { };
            n = n * n;
            if (inString.Length > n)
            {
                inString = inString.Substring(0, n);
            }

            int sumBTeam = 0;
            int sumWTeam = 0;
            //-------------------------------------------
            for (int i = 0; i < inString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    black.Add(inString[i]);
                    if (char.IsUpper(inString[i]))
                    {
                        black.Remove(inString[i]);
                        white.Add(inString[i]);
                    }
                }
                else if (i % 2 != 0)
                {
                    white.Add(inString[i]);
                    if (char.IsUpper(inString[i]))
                    {
                        white.Remove(inString[i]);
                        black.Add(inString[i]);
                    }
                }
            }
            //------------------------------------------------
            char[] bT = new char [black.Count];
            for (int i = 0; i < bT.Length; i++)
            {
                bT[i] = black[i];
            }
            string blackTeam = new string(bT);
            blackTeam = Regex.Replace(blackTeam, "[^a-zA-Z0-9]", "");

            char[] wT = new char[white.Count];
            for (int i = 0; i < wT.Length; i++)
            {
                wT[i] = white[i];
            }
            string whiteTeam = new string(wT);
            whiteTeam = Regex.Replace(whiteTeam, "[^a-zA-Z0-9]", "");
            //-------------------------------------------------------
            for (int i = 0; i < blackTeam.Length; i++)
            {
                sumBTeam = sumBTeam + (int)blackTeam[i];
            }
            for (int i = 0; i < whiteTeam.Length; i++)
            {
                sumWTeam = sumWTeam + (int)whiteTeam[i];
            }
            //---------------------------------------------------
            if (sumBTeam > sumWTeam)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(sumBTeam - sumWTeam);
            }
            else if (sumWTeam > sumBTeam)
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(sumWTeam - sumBTeam);
            }
            else if (sumBTeam == sumWTeam)
            {
                Console.WriteLine("Equal result: {0}", sumBTeam);
            }
            
        }
    }
}
