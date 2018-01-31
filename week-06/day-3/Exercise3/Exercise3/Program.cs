using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear User!");
            Console.WriteLine();
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = from n in numbers
                              where n > 0
                              orderby n
                              select n*n;

            var evenNumbers2 = numbers.Where(n => (n > 0)).OrderBy(n => n).Select(n => n*n);

            Console.WriteLine("Exercise1 solution with query syntax:");
            Console.WriteLine(string.Join(", ", evenNumbers));
            Console.WriteLine();

            Console.WriteLine("Exercise1 solution with method syntax:");
            Console.WriteLine(string.Join(", ", evenNumbers2));
            Console.ReadLine();
        }
    }
}
