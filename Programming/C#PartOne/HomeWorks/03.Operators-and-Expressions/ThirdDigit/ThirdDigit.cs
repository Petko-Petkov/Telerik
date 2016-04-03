namespace ThirdDigit
{
    using System;

    class ThirdDigit
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("false 0");
                return;
            }

            number /= 100;

            var thirdDigit = number %= 10;

            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", thirdDigit);
            }
        }
    }
}
