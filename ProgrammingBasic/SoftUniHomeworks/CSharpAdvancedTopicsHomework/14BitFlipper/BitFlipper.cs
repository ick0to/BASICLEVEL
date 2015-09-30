using System;

namespace _14BitFlipper
{
    class BitFlipper
    {
        static void Main(string[] args)
        {
            int[,,] matrix = new int [5,5,5];
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int g = 0; g < 5; g++)
                    {
                        k++;
                            matrix[i, j,g] = k; 
                        
                    }
 
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int g = 0; g < 5; g++)
                    {
                        Console.Write(matrix[j,i,g]);
                        
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
