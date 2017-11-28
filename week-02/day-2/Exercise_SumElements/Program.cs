using System;

namespace Exercise_CompareLength
{
    class Program

    {
        static void Main(string[] args)
        {
            int[] p1 = new int[3];
            p1[0] = 1;
            p1[1] = 2;
            p1[2] = 3;

            int[] p2 = new int[2];
            p2[0] = 4;
            p2[1] = 5;

            if (p1.Length < p2.Length)
            {
                Console.WriteLine("p2 has more elements than p1");
            }
            else
            {
                Console.WriteLine("p1 has more elements than p2");
            }

            Console.ReadKey();
        }
    }
}