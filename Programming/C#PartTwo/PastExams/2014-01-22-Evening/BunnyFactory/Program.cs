namespace BunnyFactory
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    class Program
    {
        private static List<int> cages = new List<int>();

        static void Main(string[] args)
        {
            ReadInput();
            IterateCages();

            var result = new StringBuilder();
            foreach (var item in cages)
            {
                result.Append(item + " ");
            }

            Console.WriteLine(result.ToString().Trim());
        }

        private static void IterateCages()
        {
            for (int i = 0; i < cages.Count; i++)
            {
                var sum = CalculateSum(i);

                if ((sum + i) >= cages.Count)
                {
                    return;
                }
                else
                {
                    CalculateProduct(i+1, sum + i);
                }
            }
        }
        
        private static void CalculateProduct(int start, int end)
        {
            BigInteger product = 1;
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                var currentDigit = cages[i];
                product *= currentDigit;
                sum += currentDigit;
            }

            string sb = string.Empty;
            sb += sum;
            sb += product;

            for (int j = end + 1; j < cages.Count; j++)
            {
                if (cages[j] > 1)
                {
                    sb += cages[j];
                }
            }

            var result = new List<int>();
            foreach (var ch in sb.ToString())
            {
                if ((ch - 48) > 1)
                {
                    result.Add(int.Parse(ch.ToString()));
                }
            }

            cages = result;
        }

        private static int CalculateSum(int index)
        {
            var sum = cages[0];

            for (int i = 1; i < index + 1; i++)
            {
                sum += cages[i];
            }

            return sum;
        }

        private static void ReadInput()
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    return;
                }

                cages.Add(int.Parse(line));
            }
        }
    }
}
