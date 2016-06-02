namespace TRES4Number
{
    using System;
    using System.Text;
    class Program
    {
        private static string[] digits = new string[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
        static void Main(string[] args)
        {
            var input = ulong.Parse(Console.ReadLine());
            var result = new StringBuilder();
            ulong numeralSystem = 9;

            do
            {
                var currentDigitIndex = (int)(input % numeralSystem);
                result.Insert(0, digits[currentDigitIndex]);
                input /= numeralSystem;
            } while (input > 0);

            Console.WriteLine(result.ToString());
        }
    }
}
