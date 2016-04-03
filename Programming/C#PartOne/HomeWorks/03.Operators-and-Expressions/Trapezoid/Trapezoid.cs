/*Write an expression that calculates trapezoid's area by given sides a and b and height h. */

namespace Trapezoid
{
    using System;

    class Trapezoid
    {
        static void Main()
        {
            //Taking input data from the user
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            //Calculating and printing the area
            Console.WriteLine("{0:F7}", ((sideA + sideB) / 2) * height);
        }
    }
}
