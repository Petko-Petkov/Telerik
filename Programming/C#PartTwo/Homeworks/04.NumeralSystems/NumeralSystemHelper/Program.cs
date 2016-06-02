namespace NumeralSystemHelper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static Dictionary<int, char> hexValues = new Dictionary<int, char>()
        {
            { 0 , '0'},
            { 1 , '1'},
            { 2 , '2'},
            { 3 , '3'},
            { 4 , '4'},
            { 5 , '5'},
            { 6 , '6'},
            { 7 , '7'},
            { 8 , '8'},
            { 9 , '9'},
            { 10, 'A'},
            { 11, 'B'},
            { 12, 'C'},
            { 13, 'D'},
            { 14, 'E'},
            { 15, 'F'},
        };

        private static Dictionary<char, int> hexDecValues = new Dictionary<char, int>()
        {
            { '0', 0 },
            { '1', 1 },
            { '2', 2 },
            { '3', 3 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 7 },
            { '8', 8 },
            { '9', 9 },
            { 'A', 10},
            { 'B', 11},
            { 'C', 12},
            { 'D', 13},
            { 'E', 14},
            { 'F', 15},
        };

        private static Dictionary<char, string> hexBinaryValues = new Dictionary<char, string>()
        {
            { '0', "" },
            { '1', "1" },
            { '2', "10" },
            { '3', "11" },
            { '4', "100" },
            { '5', "101" },
            { '6', "110" },
            { '7', "111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'A', "1010"},
            { 'B', "1011"},
            { 'C', "1100"},
            { 'D', "1101"},
            { 'E', "1110"},
            { 'F', "1111"},
        };

        static void Main(string[] args)
        {
            //Task 1
            //var number = long.Parse(Console.ReadLine());
            //string decToBinary = DecimalToBinary(number, 2);
            //Console.WriteLine(decToBinary);

            //Task 2
            //var input = Console.ReadLine().ToCharArray();
            //long result = ToDecimal(input, 2);
            //Console.WriteLine(result);

            //Task 3
            //var number = long.Parse(Console.ReadLine());
            //string result = DecimalToHex(number, 16);
            //Console.WriteLine(result);

            //Task 4
            //var hex = Console.ReadLine().ToCharArray();
            //long result = HexToDecimal(hex, 16);
            //Console.WriteLine(result);

            //Task 5
            var hexArray = Console.ReadLine().ToCharArray();
            string result = HexToDecimal(hexArray);
            Console.WriteLine(result);
        }

        private static string HexToDecimal(char[] hexArray)
        {
            var result = "";

            foreach (var item in hexArray)
            {
                result += hexBinaryValues[item];
            }

            return result;
        }

        private static long HexToDecimal(char[] hex, int baseSystem)
        {
            long result = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                var current = hexDecValues[hex[hex.Length - i - 1]];
                long powed = (long)Math.Pow(baseSystem, i);
                result += current * powed;
            }

            return result;
        }

        private static string DecimalToHex(long number, int baseSystem)
        {
            string result = "";

            do
            {
                var position = (int)(number % baseSystem);
                result = hexValues[position] + result;
                number /= baseSystem;
            } while (number > 0);

            return result;
        }

        private static long ToDecimal(char[] input, int baseSystem)
        {
            long result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                long current = input[input.Length -1 - i] - '0';
                long powed = (long)Math.Pow(baseSystem, i);
                result += current * powed;
            }

            return result;
        }
        
        private static string DecimalToBinary(long number, int baseSystem)
        {
            var result = "";

            do
            {
                var bit = number % baseSystem;
                result = bit + result;
                number /= baseSystem;
            } while (number > 0);

            return result;
        }
    }
}
