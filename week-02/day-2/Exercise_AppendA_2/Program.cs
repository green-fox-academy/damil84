using System;

namespace AppendA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "kuty", "macsk", "cic" };
            AA(animals);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }
            Console.ReadLine();
        }

        static string[] AA(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += "a";
            }
            return array;
        }
    }
}