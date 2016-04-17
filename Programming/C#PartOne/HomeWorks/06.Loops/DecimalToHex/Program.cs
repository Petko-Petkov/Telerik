namespace DecimalToHex
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            var str = Convert.ToString(num, 16);
            Console.WriteLine(str.ToUpperInvariant());
        }
    }
}
