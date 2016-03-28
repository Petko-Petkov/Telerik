using System;

namespace Problem_1_Ship_Damage
{
    class Program
    {
        static void Main()
        {
            // Read the input
            int sx1 = Int32.Parse(Console.ReadLine());
            int sy1 = Int32.Parse(Console.ReadLine());
            int sx2 = Int32.Parse(Console.ReadLine());
            int sy2 = Int32.Parse(Console.ReadLine());
            int h = Int32.Parse(Console.ReadLine());
            int cx1 = Int32.Parse(Console.ReadLine());
            int cy1 = Int32.Parse(Console.ReadLine());
            int cx2 = Int32.Parse(Console.ReadLine());
            int cy2 = Int32.Parse(Console.ReadLine());
            int cx3 = Int32.Parse(Console.ReadLine());
            int cy3 = Int32.Parse(Console.ReadLine());

            // Find the hit points (apply symmetrics)
            cy1 = 2 * h - cy1;
            cy2 = 2 * h - cy2;
            cy3 = 2 * h - cy3;

            // Find the ship bounds
            int minX = Math.Min(sx1, sx2);
            int maxX = Math.Max(sx1, sx2);
            int minY = Math.Min(sy1, sy2);
            int maxY = Math.Max(sy1, sy2);

            int totalDamage = 0;

            // Check the corners damage
            if ((cx1 == minX || cx1 == maxX) && (cy1 == minY || cy1 == maxY))
            {
                totalDamage += 25; // Hit in the corner
            }
            if ((cx2 == minX || cx2 == maxX) && (cy2 == minY || cy2 == maxY))
            {
                totalDamage += 25; // Hit in the corner
            }
            if ((cx3 == minX || cx3 == maxX) && (cy3 == minY || cy3 == maxY))
            {
                totalDamage += 25; // Hit in the corner
            }

            // Check the borders damage
            if (((cx1 == minX || cx1 == maxX) && (cy1 > minY && cy1 < maxY)) ||
                ((cy1 == minY || cy1 == maxY) && (cx1 > minX && cx1 < maxX)))
            {
                totalDamage += 50; // Hit in the border
            }
            if (((cx2 == minX || cx2 == maxX) && (cy2 > minY && cy2 < maxY)) ||
                ((cy2 == minY || cy2 == maxY) && (cx2 > minX && cx2 < maxX)))
            {
                totalDamage += 50; // Hit in the border
            }
            if (((cx3 == minX || cx3 == maxX) && (cy3 > minY && cy3 < maxY)) ||
                ((cy3 == minY || cy3 == maxY) && (cx3 > minX && cx3 < maxX)))
            {
                totalDamage += 50; // Hit in the border
            }

            // Check the internal body damage
            if ((cx1 > minX) && (cx1 < maxX) && (cy1 > minY) && (cy1 < maxY))
            {
                totalDamage += 100; // Hit in the internal body
            }
            if ((cx2 > minX) && (cx2 < maxX) && (cy2 > minY) && (cy2 < maxY))
            {
                totalDamage += 100; // Hit in the internal body
            }
            if ((cx3 > minX) && (cx3 < maxX) && (cy3 > minY) && (cy3 < maxY))
            {
                totalDamage += 100; // Hit in the internal body
            }

            Console.WriteLine(totalDamage + "%");
        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace ShipDamage
//{
//    class Program
//    {
//        private const int inputLength = 11;
//        private static int[] inputArray;
//        private static int output = 0;
//        private static List<Point> pointsArray = new List<Point>();
//        private static Point upperLeftPoint;
//        private static Point downLeftPoint;

//        static void Main(string[] args)
//        {
//            ReadInput();
//            GeneratePoints();
//            for (int i = 0; i < 3; i++)
//            {
//                var currentPoint = pointsArray[i];
//                GenerateOuput(currentPoint);
//            }

//            Console.WriteLine(output + "%");
//        }

//        private static void GeneratePoints()
//        {
//            var offset = inputArray[4];
//            upperLeftPoint = new Point(inputArray[0], inputArray[1] - offset);
//            downLeftPoint = new Point(inputArray[2], inputArray[3] - offset);


//            for (int i = 5; i < inputArray.Length; i += 2)
//            {
//                var point = new Point(inputArray[i], Math.Abs(inputArray[i + 1]) + offset);
//                pointsArray.Add(point);
//            }
//        }

//        private static void GenerateOuput(Point point)
//        {
//            if (IsCorner(point))
//            {
//                output += 25;
//            }
//            else if (IsSide(point))
//            {
//                output += 50;
//            }
//            else if (IsInside(point))
//            {
//                output += 100;
//            }
//        }

//        private static bool IsInside(Point point)
//        {
//            if (upperLeftPoint.X < point.X && downLeftPoint.X > point.X
//                && upperLeftPoint.Y > point.Y && downLeftPoint.Y < point.Y)
//            {
//                return true;
//            }

//            return false;
//        }

//        private static bool IsSide(Point point)
//        {
//            if ((upperLeftPoint.X == point.X || downLeftPoint.X == point.X)
//                && upperLeftPoint.Y > point.Y && downLeftPoint.Y < point.Y)
//            {
//                return true;
//            }

//            return false;
//        }

//        private static bool IsCorner(Point point)
//        {
//            if ((upperLeftPoint.X == point.X && upperLeftPoint.Y == point.Y)
//                || (downLeftPoint.X == point.X && downLeftPoint.Y == point.Y))
//            {
//                return true;
//            }

//            return false;
//        }

//        private static void ReadInput()
//        {
//            inputArray = new int[11];
//            for (int i = 0; i < inputLength; i++)
//            {
//                var number = int.Parse(Console.ReadLine());
//                inputArray[i] = number;
//            }
//        }
//    }

//    public class Point
//    {
//        public Point(int x, int y)
//        {
//            this.X = x;
//            this.Y = y;
//        }

//        public int X { get; set; }
//        public int Y { get; set; }
//    }
//}
