namespace NthBit
{
    using System;

    class Bit
    {
        static void Main(string[] args)
        {
            var p = long.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            if (((p >> n) & 1) == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
