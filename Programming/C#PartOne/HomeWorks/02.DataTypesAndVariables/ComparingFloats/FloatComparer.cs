namespace ComparingFloats
{
    using System;

    class FloatComparer
    {
        static void Main(string[] args)
        {
            var first = Math.Abs(float.Parse(Console.ReadLine()));
            var second = Math.Abs(float.Parse(Console.ReadLine()));
            var diff = first - second;
            float epsilon = 0.000001f;
            
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
