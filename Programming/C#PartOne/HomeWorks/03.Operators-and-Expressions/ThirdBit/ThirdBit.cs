namespace ThirdBit
{
    using System;

    class ThirdBit
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            if (((input >> 3) & 1) == 1)
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
