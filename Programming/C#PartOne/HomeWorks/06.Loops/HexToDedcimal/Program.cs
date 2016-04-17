namespace HexToDedcimal
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var hex = Console.ReadLine();

            Console.WriteLine(Convert.ToInt64(hex, 16));
        }
    }
}
