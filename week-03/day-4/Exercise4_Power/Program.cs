using System;

namespace Exercise4_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Pow(2, 10);
            Console.WriteLine(result); // 1024
            Console.ReadKey();
        }

        static public double Pow(double x, int y)
        {
            if (y == 0)
            {
                return 1.0;
            }
            else
            {
                return x * Pow(x, y - 1);

            } 
        }
    }
}
