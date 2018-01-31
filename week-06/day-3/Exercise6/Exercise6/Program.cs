using System;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear User!");
            Console.WriteLine("Type your text here!");
            string userString = Console.ReadLine();
            Console.WriteLine();

            var stringFreq = from n in userString
                             orderby n
                             group n by n into grp
                             select new { grp.Key, Count = grp.Count() };

            var stringFreq2 = userString.OrderBy(n => n).GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            Console.WriteLine("Exercise1 solution with query syntax:");
            Console.WriteLine(string.Join(", ", stringFreq));
            Console.WriteLine();

            Console.WriteLine("Exercise1 solution with method syntax:");
            Console.WriteLine(string.Join(", ", stringFreq2));
            Console.ReadLine();
        }
    }
}