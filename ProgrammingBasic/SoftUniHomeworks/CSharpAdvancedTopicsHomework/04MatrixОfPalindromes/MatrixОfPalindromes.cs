using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MatrixОfPalindromes
{
    class MatrixОfPalindromes
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            string[,] array = new string[,]
            {
                {"aaa","aba","aca","ada","aea","afa"},
                {"bbb","bcb","bdb","beb","bfb","bgb"},
                {"ccc","cec","cdc","cfc","cgc","chc"}

                
            };
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0} ",array[i,j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
