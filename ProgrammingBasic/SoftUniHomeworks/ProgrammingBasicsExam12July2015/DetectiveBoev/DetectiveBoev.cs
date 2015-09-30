using System;

namespace DetectiveBoev
{
    class DetectiveBoev
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string encrypted = Console.ReadLine();

            int mask = 0; // tuka si pravim maska

            foreach (var symbol in secretWord) // razkodirvame s foreach
            {
                mask = mask + symbol;       //davame na maskata zbora na simvolite
            }

            while (mask > 9)        //masko po golqmo ot 9
            {
                int sum = 0;
                while (mask != 0)
                {
                    int reminder = mask % 10;
                    mask = mask / 10;
                    sum = sum + reminder;
                }
                mask = sum;
            }

            char[] decryptedMessage = new char[encrypted.Length];
            for (int i = 0; i < encrypted.Length; i++)
            {
                if (encrypted[i] % mask == 0)
                {
                    decryptedMessage[i] = (char)(encrypted[i] + mask);
                }
                else
                {
                    decryptedMessage[i] = (char)(encrypted[i] - mask);
                }
            }
            for (int i = decryptedMessage.Length - 1; i >= 0; i--)
            {
                Console.Write(decryptedMessage[i]);
            }
            Console.WriteLine();
        }
    }
}
