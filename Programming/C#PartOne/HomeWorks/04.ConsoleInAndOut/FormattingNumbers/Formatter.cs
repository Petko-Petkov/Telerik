namespace FormattingNumbers
{
    using System;

    class Formatter
    {
        static void Main()
        {
            bool isValid = false;
            var inputA = 0;

            while (!isValid)
            {
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out inputA);
            }

            var binaryA = Convert.ToString(inputA, 2).PadLeft(10, '0');
            var inputB = float.Parse(Console.ReadLine());
            var inputC = float.Parse(Console.ReadLine());

            Console.WriteLine("|{0, 10:X}|{1, 10}|{2, 10:F2}|{3, 10:F3}|", inputA, binaryA, inputB, inputC);
        }
    }
}
