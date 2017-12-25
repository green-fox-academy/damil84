using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduction("Diós András", 33, 1.85);
            Console.ReadLine();
        }

        static void Introduction(string name, int age, double height)
        {
            Console.WriteLine(name);
            Console.WriteLine(age + " years old");
            Console.WriteLine(height + "cm tall");
        }
    }
}
