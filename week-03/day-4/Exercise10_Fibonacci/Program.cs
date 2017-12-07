using System;

namespace Exercise10_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give us the number you'd like to fibonaccied>>>");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The {0}nth fibonacci number is: {1}", inputNumber, FibonacciNumber(inputNumber));
            Console.ReadLine();
            
        }

        public static int FibonacciNumber(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            else if (number == 1) 
            {
                return 1;
            }
            else
            {
                return FibonacciNumber(number - 1) + FibonacciNumber(number - 2);
            }
        }
    }
}
