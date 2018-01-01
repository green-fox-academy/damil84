using System;

namespace AppendA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimals = { "kuty", "macsk", "cic" };
            for (int i = 0; i < nimals.Length; i++)
            {
                nimals[i] += "a";
                Console.WriteLine(nimals[i]);
            }
            Console.ReadLine();
        }
    }
}