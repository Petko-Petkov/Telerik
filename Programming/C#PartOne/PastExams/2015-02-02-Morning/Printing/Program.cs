namespace Printing
{
    using System;

    class Program
    {
        private static double[] inputArray = new double[3];
        private const double sheetsPerRealm = 500;

        static void Main(string[] args)
        {
            ReadInput();
            CalculateOutput();
        }

        private static void CalculateOutput()
        {
            double students = inputArray[0];
            double sheetsPerStudent = inputArray[1];
            double realmCost = inputArray[2];
            double totalSheets = students * sheetsPerStudent;
            double realms = totalSheets / sheetsPerRealm;
            double totalPrice = realms * realmCost;

            Console.WriteLine("{0:F2}", totalPrice);
        }

        private static void ReadInput()
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
