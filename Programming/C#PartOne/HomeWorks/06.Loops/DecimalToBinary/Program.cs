﻿namespace DecimalToBinary
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 2));
        }
    }
}
