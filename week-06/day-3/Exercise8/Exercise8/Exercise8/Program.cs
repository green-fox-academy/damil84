using System;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear User!");
            Console.WriteLine("Type your text here!");
            string userString = Console.ReadLine();
            Console.WriteLine();

            var stringUpper1 = from upper in userString
                               where upper.ToString() == upper.ToString().ToUpper()
                               select upper;

            var stringUpper2 = userString.Where(c => char.IsUpper(c));

            Console.WriteLine("Exercise1 solution with query syntax:");
            Console.WriteLine(string.Join(", ", stringUpper1));
            Console.WriteLine();

            Console.WriteLine("Exercise1 solution with method syntax:");
            Console.WriteLine(string.Join(", ", stringUpper2));
            Console.ReadLine();
        }
    }
}