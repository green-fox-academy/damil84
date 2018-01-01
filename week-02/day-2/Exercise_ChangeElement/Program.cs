using System;

namespace Exercise_ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 8, 5, 6 };
            Console.WriteLine("Original fourth element is: " + s[3]);
            s[3] = 4;
            Console.WriteLine("The replaced fourth element now on is: " + s[3]);
            Console.Read();
        }
    }
}
