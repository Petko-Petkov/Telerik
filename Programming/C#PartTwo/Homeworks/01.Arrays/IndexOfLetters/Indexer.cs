namespace IndexOfLetters
{
    using System;

    class Indexer
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var charArr = GetCharArray();
            GenerateOutput(charArr, input);
        }

        private static void GenerateOutput(char[] charArr, string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(Array.IndexOf(charArr, input[i]));
            }
        }

        private static char[] GetCharArray()
        {
            var charArr = new char[26];

            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = (char)(i + (int)'a');
            }

            return charArr;
        }
    }
}
