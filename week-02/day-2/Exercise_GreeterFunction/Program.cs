using System;

namespace Exercise_GreeterFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            GreeterFunction(al);
            Console.ReadLine();
        }

        static void GreeterFunction(string al)
        {
            Console.WriteLine("Greetings dear, " + al + "!");
        }




    }
}