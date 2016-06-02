using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Messages
{
    class Program
    {
        private static Dictionary<string, int> codex = new Dictionary<string, int> {
            {"cad", 0},
            {"xoz", 1},
            {"nop", 2},
            {"cyk", 3},
            {"min", 4},
            {"mar", 5},
            {"kon", 6},
            {"iva", 7},
            {"ogi", 8},
            {"yan", 9}};
        private static string[] strArr = new string[] { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan", };

        private static BigInteger first;
        private static BigInteger second;
        private static string operand;

        static void Main(string[] args)
        {
            ReadInput();
            CalculateOutput();
        }

        private static void CalculateOutput()
        {
            switch (operand)
            {
                case "+":
                    GetFinalMessage((first + second).ToString());
                    break;
                case "-":
                    GetFinalMessage((first - second).ToString());
                    break;
                default:
                    break;
            }
        }

        private static void GetFinalMessage(string value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in value)
            {
                sb.Append(strArr[int.Parse(item.ToString())]);
            }

            Console.WriteLine(sb);
        }

        private static void ReadInput()
        {
            var firstNumber = Console.ReadLine();
            operand = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            first = GetValue(firstNumber);
            second = GetValue(secondNumber);


        }

        private static BigInteger GetValue(string firstNumber)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < firstNumber.Length; i+=3)
            {
                var current = firstNumber.Substring(i, 3);

                output.Append(codex[current]);
            }

            return BigInteger.Parse(output.ToString());
        }
    }
}
