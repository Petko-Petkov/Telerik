using System;

namespace BobiAvocadoto
{
    class Program
    {
        private static uint bestComb = 0;
        private static uint currentComb = 0;
        private static uint bestBits = 0;
        static void Main(string[] args)
        {
            var hair = uint.Parse(Console.ReadLine());
            var count = uint.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                var comb = uint.Parse(Console.ReadLine());
                currentComb = comb;

                CompareCombs(hair, comb);
            }

            Console.WriteLine(bestComb);
        }

        private static void CompareCombs(uint hair, uint comb)
        {
            uint bitsCount = 0;

            while (hair > 0 || comb > 0)
            {
                var hairBit = hair & 1;
                var combBit = comb & 1;
                
                if (hairBit == combBit && hairBit == 1)
                {
                    bitsCount = 0;
                    break;
                }
                
                if (hairBit != combBit)
                {
                    bitsCount++;
                }
                hair >>= 1;
                comb >>= 1;
            }

            if (bitsCount > bestBits && bitsCount > 0)
            {
                bestBits = bitsCount;
                bestComb = currentComb;
            }
        }
    }
}
