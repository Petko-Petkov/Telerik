namespace VariableLengthCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        private static StringBuilder input = new StringBuilder();
        private static Dictionary<int, char> dict = new Dictionary<int, char>();
        private static List<int> text = new List<int>();
        private static StringBuilder output = new StringBuilder();

        static void Main(string[] args)
        {
            ReadInput();
            ParseText();
            GenerateOutput();
            Console.WriteLine(output);
        }

        private static void GenerateOutput()
        {
            foreach (var num in text)
            {
                output.Append(dict[num]);
            }
        }

        private static void ParseText()
        {
            var length = 0;

            foreach (var ch in input.ToString())
            {
                if (ch == '0')
                {
                    if (length > 0)
                    {
                        text.Add(length);
                    }
                    length = 0;
                }
                else
                {
                    length++;
                }
            }
        }

        private static void ReadInput()
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

            foreach (var num in nums)
            {
                var current = Convert.ToString(num, 2).PadLeft(8, '0');
                input.Append(current);
            }

            var length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                var line = Console.ReadLine();
                var character = line[0];
                var digit = int.Parse(line.Substring(1, line.Length - 1));

                dict[digit] = character;
            }
        }
    }
}
