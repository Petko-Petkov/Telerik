namespace NumberAsArray
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Numerics;

    class Numbers
    {
        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            var length = Console.ReadLine();
            var first = string.Join("", Console.ReadLine().Split(' ')).ToCharArray();
            var second = string.Join("", Console.ReadLine().Split(' ')).ToCharArray();

            GenerateDigits(first, second);
        }

        private static void GenerateDigits(char[] first, char[] second)
        {
            Array.Reverse(first);
            Array.Reverse(second);
            var firstNum = BigInteger.Parse(new string(first));
            var secondNum = BigInteger.Parse(new string(second));

            GenerateResult(firstNum + secondNum); 
        }

        private static void GenerateResult(BigInteger number)
        {
            var str = number.ToString().ToCharArray();
            Array.Reverse(str);
            var sb = new StringBuilder();

            foreach (var item in str)
            {
                sb.Append(item);
                sb.Append(' ');
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
