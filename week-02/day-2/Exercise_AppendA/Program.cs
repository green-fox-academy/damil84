using System;

namespace Exercise_AppendA
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            appendA(am);
            Console.ReadLine();


        }
        static void appendA(string am)
        {
            Console.WriteLine(am + "a");
        }
    }
}
