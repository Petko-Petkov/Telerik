using System;

namespace TextToNumber
{
    class Program
    {
        private static int number;
        private static string inputString;

        static void Main(string[] args)
        {
            ReadInput();
            ManipulateString();
        }

        private static void ManipulateString()
        {
            var result = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                var currentChar = inputString[i];
                if (Char.IsDigit(currentChar))
                {
                    result *= int.Parse(currentChar.ToString());
                }
                else if (Char.IsLetter(currentChar))
                {
                    if (Char.IsUpper(currentChar))
                    {
                        result += currentChar - 65;
                    }
                    else
                    {
                        result += currentChar - 97;
                    }
                }
                else
                {
                    result %= number;
                }
            }

            Console.WriteLine(result);
        }

        private static void ReadInput()
        {
            number = int.Parse(Console.ReadLine());
            inputString = Console.ReadLine().Split(new char[] { '@'}, StringSplitOptions.RemoveEmptyEntries)[0];
        }
    }
}
