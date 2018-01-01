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

            foreach (string item in abc)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
