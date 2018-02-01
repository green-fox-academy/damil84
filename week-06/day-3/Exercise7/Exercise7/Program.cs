using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear User!");
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "ACADEMI" }; Console.WriteLine();

            var stringFreq = from n in cities
                             orderby n
                             group n by n into grp
                             select new { grp.Key, Count = grp.Count() };

            var stringFreq2 = cities.OrderBy(n => n).GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            Console.WriteLine("Exercise solution with query syntax:");
            Console.WriteLine(string.Join(", ", stringFreq));
            Console.WriteLine();

            Console.WriteLine("Exercise solution with method syntax:");
            Console.WriteLine(string.Join(", ", stringFreq2));
            Console.ReadLine();
        }
    }
}
