using System;
using System.Linq;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear User!");
            Console.WriteLine("Type your text here, to creat a character array!");
            var userString = Console.ReadLine().ToCharArray();
            Console.WriteLine();

            var stringConvert1 = from c in userString
                               select c.ToString();
            string text1 = string.Join(string.Empty, stringConvert1);

            var stringConvert2 = userString.Select(c => char.ToString(c));
            string text2 = string.Join(string.Empty, stringConvert2);
            Console.WriteLine("Exercise solution with query syntax:");
            Console.WriteLine(text1);
            Console.WriteLine();

            Console.WriteLine("Exercise solution with method syntax:");
            Console.WriteLine(text2);
            Console.ReadLine();
        }
    }
}