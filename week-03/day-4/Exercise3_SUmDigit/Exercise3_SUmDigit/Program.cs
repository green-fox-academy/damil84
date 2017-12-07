using System;

namespace Exercise3_SUmDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give us the number of your choosing >>>");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the digits of your number is: " + SumDigit(inputNumber));
            Console.ReadLine();
        }

        public static int SumDigit(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                return (n % 10) + SumDigit(n / 10);
            }
        }
    }
}
