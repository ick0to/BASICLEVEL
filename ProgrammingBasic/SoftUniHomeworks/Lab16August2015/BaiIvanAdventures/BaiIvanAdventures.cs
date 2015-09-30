using System;

namespace BaiIvanAdventures
{
    class BaiIvanAdventures
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());
            decimal alcohol = decimal.Parse(Console.ReadLine());
            decimal bought = 1;
            switch (n)
            {
                case 0: bought = money / 25M; break;
                case 1: bought = money / 21M; break;
                case 2: bought = money / 14M; break;
                case 3: bought = money / 17M; break;
                case 4: bought = money / 45M; break;
                case 5: bought = money / 59M; break;
                case 6: bought = money / 42M; break;
                
                default:
                    break;
            }
            string status;

            if (bought > 1.5m)
            {
                status = "very drunk";
            }
            else if (bought >= 1.0m)
            {
                status = "drunk";
            }
            else
            {
                status = "sober";
            }

            if (alcohol < bought)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends",
                    status, bought - alcohol);
            }
            else if (alcohol == bought)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted",status);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol",
                    status, alcohol - bought);
            }
        }
    }
}
