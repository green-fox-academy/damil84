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

            var string1 = from city in cities
                          where city.StartsWith("A") || city.EndsWith("I")
                          select city;


            var string2 = cities.Where(c => c.StartsWith("A") || c.EndsWith("I"));

            Console.WriteLine("Exercise solution with query syntax:");
            Console.WriteLine(string.Join(", ", string1));
            Console.WriteLine();

            Console.WriteLine("Exercise solution with method syntax:");
            Console.WriteLine(string.Join(", ", string2));
            Console.ReadLine();
        }
    }
}
