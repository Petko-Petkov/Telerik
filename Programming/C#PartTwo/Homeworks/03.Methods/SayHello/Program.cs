﻿namespace SayHello
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
