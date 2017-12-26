using System;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original numbers are a= 123, b= 526");
            Console.WriteLine("Press Enter for swapping");
            Console.ReadLine();
            Functions calculations = new Functions();
            calculations.Calculations();
            Console.ReadLine();
        }
    }
}
