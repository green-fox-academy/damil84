using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear User!");
            Console.WriteLine();
            int[] numbers = { 3, 9, 2, 8, 6, 5 };

            var ex4Numbers = from n in numbers
                              where n*n > 20
                              orderby n
                              select n;

            var ex4Numbers2 = numbers.Where(n => (n*n > 20)).OrderBy(n => n);

            Console.WriteLine("Exercise1 solution with query syntax:");
            Console.WriteLine(string.Join(", ", ex4Numbers));
            Console.WriteLine();

            Console.WriteLine("Exercise1 solution with method syntax:");
            Console.WriteLine(string.Join(", ", ex4Numbers2));
            Console.ReadLine();
        }
    }
}
