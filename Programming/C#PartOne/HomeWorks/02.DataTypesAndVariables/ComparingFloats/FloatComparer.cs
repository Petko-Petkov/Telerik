namespace ComparingFloats
{
    using System;

    class FloatComparer
    {
        static void Main(string[] args)
        {
            var first = Math.Abs(double.Parse(Console.ReadLine()));
            var second = Math.Abs(double.Parse(Console.ReadLine()));
            var diff = first - second;
            double epsilon = 0.000001f;
            
            bool equal = Math.Abs(first) - Math.Abs(second) <= epsilon;

            Console.WriteLine(first - second);

            if (equal)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
