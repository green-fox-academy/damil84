using System;

namespace Exercise_SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third"};
            string tmp = abc[0];
            abc[0] = abc[2];
            abc[2] = tmp;


            for (int i = 0; i < abc.Length; i++)
            {
            Console.WriteLine(abc[i]);
            }
            Console.ReadLine();
        }

    }
}
