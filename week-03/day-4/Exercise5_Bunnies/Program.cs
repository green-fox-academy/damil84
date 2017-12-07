using System;

namespace Exercise5_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give us the number of your Bunnies >>>");
            int bunnyNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + BunnyEarCounter(bunnyNumber));
            Console.ReadLine();
        }
        public static int BunnyEarCounter(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
                Console.WriteLine(number);
            {
                return 2 + BunnyEarCounter(number - 1);
            }
        }
    }
}
