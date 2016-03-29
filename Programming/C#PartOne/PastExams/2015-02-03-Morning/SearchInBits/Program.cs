using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInBits
{
    class Program
    {
        private static int result = 0;
        static void Main(string[] args)
        {
            var pattern = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(4, '0');
            var length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                var num = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(30, '0');
                CompareAgainst(num, pattern);
            }

            Console.WriteLine(result);
        }

        private static void CompareAgainst(string num, string pattern)
        {
            while (num.Length > 3)
            {
                var strToCompare = num.Substring(num.Length - 4, 4);
                if (strToCompare == pattern)
                {
                    result++;
                }
                num = num.Substring(0, num.Length - 1);
            }
        }
    }
}
