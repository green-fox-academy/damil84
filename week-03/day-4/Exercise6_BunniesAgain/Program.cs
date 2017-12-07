using System;

namespace Exercise6_BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give us the number of your Bunnies >>>");
            int bunnyNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + BunnyEarCounter2(bunnyNumber));
            Console.ReadLine();
        }
        public static int BunnyEarCounter2(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            if (number % 2 == 0)
            {
                return 3 + BunnyEarCounter2(number - 1);
            }
            else
            {
            return 2 + BunnyEarCounter2(number - 1);
            }
        }
    }
}
