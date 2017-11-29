using System;

namespace Exercise_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] colors = new string[3][];
            colors[0] = new string[5] { "lime", "forest green", "olive", "pale green", "spring green" };
            colors[1] = new string[3] { "orange red", "red", "tomato" };
            colors[2] = new string[4] { "orchid", "violet", "pink", "hot pink" };
            Print(colors);
            Console.ReadLine();
        }

        private static void Print(string[][] array)
        {
            foreach (string[] array2 in array)
            {
                foreach (string element in array2)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("***************************");
            }
        }
    }
}
