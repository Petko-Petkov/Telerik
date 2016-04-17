using System;

namespace Calculate
{
    class Program
    {
        static void Main()
        {
            double sum = 1;
            var inputN = double.Parse(Console.ReadLine());
            var inputX = double.Parse(Console.ReadLine());
            double factorial = 1;
            double powed = inputX;

            for (int i = 1; i <= inputN; i++)
            {
                factorial = CalculateFactorial(i);
                powed = Math.Pow(inputX, (double)i);
                sum += factorial / powed;
            }

            Console.WriteLine("{0:F5}", sum);
        }

        private static double CalculateFactorial(int num)
        {
            double output = 1;

            for (int i = num; i > 0; i--)
            {
                output *= i;
            }

            return output;
        }
    }
}
