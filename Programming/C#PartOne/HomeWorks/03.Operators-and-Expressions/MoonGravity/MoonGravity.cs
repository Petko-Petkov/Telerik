/* The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
 * The weight W should be read from the console. */

namespace MoonGravity
{
    using System;

    class MoonGravity
    {
        static void Main()
        {
            var weightOnEarth = double.Parse(Console.ReadLine());

            var weightOnMoon = (weightOnEarth * 17) / 100;

            //Write the calculated weight on the console
            Console.WriteLine("{0:F3}", weightOnMoon);
        }
    }
}
