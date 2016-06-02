namespace EnglishDigit
{
    using System;

    class EnglishDigit
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            GetDigit(number);
        }

        private static void GetDigit(int number)
        {
            var digit = number % 10;
            PrintDigit(digit);
        }

        private static void PrintDigit(int digit)
        {
            switch (digit)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("zero");
                    break;
            }
        }
    }
}
