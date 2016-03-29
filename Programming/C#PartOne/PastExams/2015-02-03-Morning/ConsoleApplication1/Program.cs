namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = ReadInput();
            BigInteger result = 1;
            BigInteger output = 1;

            for (int i = 1; i < list.Count; i+=2)
            {
                if (i < 10)
                {
                    result *= CalculateProduct(list[i]);
                }
                else
                {
                    output *= CalculateProduct(list[i]);
                }
            }

            Console.WriteLine(result);
            if (list.Count > 10)
            {
                Console.WriteLine(output);
            }
        }

        private static long CalculateProduct(string v)
        {
            long result = 1;

            for (int i = 0; i < v.Length; i++)
            {
                var c = v[i];
                if (c == '0')
                {
                    continue;
                }
                else
                {
                    result *= sbyte.Parse(c.ToString());
                }
            }

            return result;
        }

        private static List<string> ReadInput()
        {
            var list = new List<string>();

            while (true)
            {
                var str = Console.ReadLine();

                if (str == "END")
                {
                    return list;
                }
                else
                {
                    list.Add(str);
                }
            }
        }
    }
}
