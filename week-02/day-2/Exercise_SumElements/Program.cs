using System;

namespace Exercise_SumElements
{
    class Program

    {
        static void Main(string[] args)
        {
            int[] r = new int[4]
            { 54, 23, 66, 12};
            Console.WriteLine("The sum of the second an third element is: " + (r[1] + r[2]));
            Console.ReadKey();
        }
    }
}