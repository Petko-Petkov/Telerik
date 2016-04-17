namespace MultiplicationSign
{
    using System;

    class Sign
    {
        static void Main(string[] args)
        {
            var sign = 0;
            for (int i = 0; i < 3; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("0");
                    return;
                }

                if (num < 0)
                {
                    sign++;
                }
            }

            if (sign % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
