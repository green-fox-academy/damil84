using System;

namespace Exercise_DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ag = { 3, 4, 5, 6, 7 };

            for (int i = 0; i < ag.Length; i++)
            {
                Console.WriteLine("Original element: {0} ", ag[i]);
                ag[i] *= 2;
                Console.WriteLine("Doubled value of element: {0}", ag[i]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
