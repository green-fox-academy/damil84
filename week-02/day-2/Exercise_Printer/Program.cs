using System;

namespace Exercise_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "Canis Lupus", "Canis Rufus", "Canis Familiaris" };
            Printer(a);
            Console.ReadKey();
        }
        static void Printer(string[] array)
        {
            foreach (string item in array)
        {
            Console.WriteLine(item);
        }
        }
    }
}