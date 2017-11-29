using System;

namespace Exercise_PrintElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };
            Console.WriteLine("This array has the following elements: {0}", string.Join(", ", af));
            Console.ReadLine();
          
        }
    }
}