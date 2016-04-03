/* Write an expression that calculates rectangle’s area and perimeter by given width and height. 
 * The width and height should be read from the console.*/

namespace Rectangles
{
    using System;

    class Rectangles
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var area = width * height;
            var perimeter = 2 * width + 2 * height;

            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
        }
    }
}
