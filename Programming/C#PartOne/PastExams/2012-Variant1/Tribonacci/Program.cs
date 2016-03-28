namespace Tribonacci
{
    using System;
    using System.Numerics;

    class TribonacciMain
    {
        static void Main()
        {
            var first = BigInteger.Parse(Console.ReadLine());
            var second = BigInteger.Parse(Console.ReadLine());
            var third = BigInteger.Parse(Console.ReadLine());
            var elementN = BigInteger.Parse(Console.ReadLine());
            BigInteger tmp = 0;

            if (elementN == 1)
            {
                Console.WriteLine(first);
            }
            else if (elementN == 2)
            {
                Console.WriteLine(second);
            }
            else if (elementN == 3)
            {
                Console.WriteLine(third);
            }
            else
            {
                for (int i = 3; i < elementN; i++)
                {
                    tmp = first + second + third;
                    first = second;
                    second = third;
                    third = tmp;
                }


                Console.WriteLine(tmp);
            }
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Linq;

//namespace Tribonacci
//{
//    class Program
//    {
//        private const int initialLength = 4;
//        private static List<BigInteger> outputArray = new List<BigInteger>();

//        static void Main(string[] args)
//        {
//            ReadInput();
//            var searchedNumber = outputArray[3];
//            outputArray[3] = outputArray[2] + outputArray[1] + outputArray[0];
//            for (int i = 4; i < searchedNumber; i++)
//            {
//                outputArray.Add( outputArray[i - 1] + outputArray[i - 2] + outputArray[i - 3]);
//            }

//            Console.WriteLine(outputArray[outputArray.Count - 1]);
//        }

//        private static void ReadInput()
//        {
//            for (int i = 0; i < initialLength; i++)
//            {
//                var currentNumber = BigInteger.Parse(Console.ReadLine());
//                outputArray.Add(currentNumber); 
//            }
//        }
//    }
//}

