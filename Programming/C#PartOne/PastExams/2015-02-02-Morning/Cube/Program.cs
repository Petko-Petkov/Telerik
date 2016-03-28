namespace Cube
{
    using System;

    class Program
    {
        private static int inputNumber;

        static void Main(string[] args)
        {
            inputNumber = int.Parse(Console.ReadLine());
            var dimensions = inputNumber * 2 - 1;
            var spaces = new string(' ', inputNumber - 1);
            var dots = new string(':', inputNumber);
            Console.WriteLine("{0}{1}",spaces, dots);

            for (int i = 0; i < inputNumber - 2; i++)
            {
                var innerSpaces = new string(' ', inputNumber - i - 2);
                var innerDots = new string('X', i);
                var slashes = new string('/', inputNumber - 2);

                Console.WriteLine("{0}:{1}:{2}:", innerSpaces, slashes, innerDots);
            }

            Console.WriteLine("{0}{1}:", dots, new string('X', inputNumber - 2));

            for (int i = 0; i < inputNumber - 2; i++)
            {
                var innerSpaces = new string(' ', inputNumber - 2);
                var innerXs = new string('X', inputNumber - 3 - i);
                var outerSpaces = new string(' ', i);

                Console.WriteLine(":{0}:{1}:", innerSpaces, innerXs);
            }

            Console.WriteLine("{0}{1}", dots, spaces);
        }
    }
}
