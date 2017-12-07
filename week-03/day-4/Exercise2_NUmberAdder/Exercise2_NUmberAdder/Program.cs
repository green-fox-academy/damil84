using System;

namespace Exercise2_NUmberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give us the number of your choosing >>>");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + NumberAdder(inputNumber));
            Console.ReadLine();
        }
        public static int NumberAdder(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number + NumberAdder(number - 1);
            }
        }
    }
}

