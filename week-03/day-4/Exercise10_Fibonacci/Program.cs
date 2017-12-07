using System;

namespace Exercise10_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give us the number you'd like to fibonaccied>>>");
            int ibputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + FibonacciNumber(ibputNumber));
            Console.ReadLine();
        }
        public static int FibonacciNumber(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
                Console.WriteLine(number);
            {
                return 2 + FibonacciNumber(number - 1);
            }
        }
    }
}
