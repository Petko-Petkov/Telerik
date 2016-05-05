using System;

namespace Feathers
{
    class Program
    {
        static void Main(string[] args)
        {
            double birds = double.Parse(Console.ReadLine());
            double feathers = double.Parse(Console.ReadLine());

            if (birds == 0 || feathers == 0)
            {
                Console.WriteLine("0.0000");
                return;
            }

            var avg = feathers / birds;
            if (birds % 2 != 0)
            {
                avg /= 317;
            }
            else
            {
                avg *= 123123123123;
            }

            Console.WriteLine("{0:F4}", avg);
        }
    }
}
