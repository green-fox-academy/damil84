using System;

namespace Exercise_IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 2, 3, 4, 5 };
            //other soultion: t[2] += 3;
            // Console.WriteLine("The incremented third elemenent is: " + t[2]);
            Console.WriteLine("The incremented third elemenent is: " + ++t[2]);
            Console.ReadLine();
        }
    }
}


