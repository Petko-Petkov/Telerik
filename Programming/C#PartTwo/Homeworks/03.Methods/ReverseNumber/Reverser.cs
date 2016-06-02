namespace ReverseNumber
{
    using System;

    class Reverser
    {
        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            var input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(new string(input));
        }
    }
}
