using System;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear User!");
            Console.WriteLine();
            int[] numbers = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var ex5Numbers = from n in numbers
                             orderby n
                             group n by n into grp
                             select new { grp.Key, Count = grp.Count() };

            var ex5Numbers2 = numbers.OrderBy(n => n).GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            Console.WriteLine("Exercise1 solution with query syntax:");
            Console.WriteLine(string.Join(", ", ex5Numbers));
            Console.WriteLine();

            Console.WriteLine("Exercise1 solution with method syntax:");
            Console.WriteLine(string.Join(", ", ex5Numbers2));
            Console.ReadLine();
        }
    }
}