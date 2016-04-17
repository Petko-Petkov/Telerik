namespace BinaryToDecimal
{
    using System;

    class Program
    {
        static void Main()
        {
            var str = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(str, 2));
        }
    }
}
