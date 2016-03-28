namespace FirTree
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = int.Parse(Console.ReadLine());
            var dots = new string('.', inputNumber - 2);
            var firstLine = dots + '*' + dots;

            Console.WriteLine(firstLine);
            for (int i = 1; i < inputNumber - 1; i++)
            {
                dots = GenerateDots(i, inputNumber);
                var stars = GenerateStars(i);

                Console.WriteLine("{0}{1}{0}", dots, stars);
            }

            Console.WriteLine(firstLine);
        }

        private static object GenerateStars(int i)
        {
            return new string('*', i * 2 + 1);
        }

        private static string GenerateDots(int i, int inputNumber)
        {
            return new string('.', inputNumber - 2 - i);
        }


    }
}
