using System;

namespace Exercise_AppendA
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me the number of your choosing: ");
            int number =Convert.ToInt32(Console.ReadLine());
            Sum(number);
            Console.ReadLine();


        }
        static void Sum(int number)
        {
            int a = number * (number + 1) / 2;
            Console.WriteLine(a);
        }
    }
}