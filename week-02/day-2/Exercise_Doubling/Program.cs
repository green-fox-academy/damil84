﻿using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int ak = 123;
            Console.WriteLine(Doubling(ak));
            Console.ReadLine();
        }

        public static int Doubling(int number)
        {
            return (2 * number);
        }
    }
}