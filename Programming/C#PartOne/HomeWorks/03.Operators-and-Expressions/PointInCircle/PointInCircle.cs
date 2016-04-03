/*Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).*/

namespace PointInCircle
{
    using System;

    class PointInCircle
    {
        static void Main()
        {
            var coorX = double.Parse(Console.ReadLine());
            var coorY = double.Parse(Console.ReadLine());

            //Finding the distance between (0, 0) and the point dimension via Pitagor 
            var hypotenuse = Math.Pow(coorX, 2) + Math.Pow(coorY, 2);
            var distance = Math.Sqrt(hypotenuse);

            //Cheking if the distance is smaller than the radius
            if (distance <= 2)
            {
                Console.WriteLine("yes {0:F2}", distance);
            }
            else
            {
                Console.WriteLine("no {0:F2}", distance);
            }
        }
    }
}
