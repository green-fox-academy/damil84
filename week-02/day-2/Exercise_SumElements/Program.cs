using System;

namespace Exercise_SumElements
{
    class Program

    {
        static void Main(string[] args)
        {
            int[] r = new int[4];
            r[0] = 54;
            r[1] = 23;
            r[2] = 66;
            r[3] = 12;
            int result;
            result = r[1] + r[2];

            Console.WriteLine("The sum of the second an third element is: " + result);
            Console.ReadKey();
        }
    }
}