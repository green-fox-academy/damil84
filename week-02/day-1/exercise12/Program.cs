using System;

namespace exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 3;
            double c = 2;
            double surface;
            double volume;

            surface = 2 * (a * b + a * c + b * c);
            Console.WriteLine("felszíne: " + surface + "négyzetméter");
            volume = (a * b * c);
            Console.WriteLine("térfogata: " + volume + "köbméter");
            Console.ReadLine();
        }
    }
}
