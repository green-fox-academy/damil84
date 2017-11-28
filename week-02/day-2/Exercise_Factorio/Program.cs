using System;

namespace Exercise_Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me the number of your choosing: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Factorio(number);
            Console.ReadLine();


        }
        static void Factorio(int number)
        {
            int f = number;
            for (int i = 1; i< number; i++)
            {
                f = f * i;
            }
            Console.WriteLine("The factorial of your given number is: " + f );
        }
    }
}