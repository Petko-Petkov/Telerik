namespace FourDigit
{
    using System;
    using System.Linq;

    class FourDigit
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            var sum = 0;
            string reversed = string.Empty;

            for (int i = 0; i < number.Length; i++)
            {
                reversed += number[number.Length - i - 1];
            }

            foreach (var digit in number)
            {
                sum += int.Parse(digit.ToString());
            }

            var lastToFirst = number[3] + number.Substring(0, 3);
            string mediumReversed = number[0].ToString() + number[2].ToString() + number[1].ToString() + number[3].ToString();

            Console.WriteLine(sum);
            Console.WriteLine(reversed);
            Console.WriteLine(lastToFirst);
            Console.WriteLine(mediumReversed);
        }
    }
}
