using System;

namespace exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double surface;
            double volume;

            Console.WriteLine("Mennyi az a oldal értéke?:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Mennyi a b oldal értéke?:");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Mennyi a c oldal értéke?:");
            c = Int32.Parse(Console.ReadLine());

            surface = 2 * (a * b + a * c + b * c);
            Console.WriteLine("felszíne: " + surface + "négyzetméter");
            volume = (a * b * c);
            Console.WriteLine("térfogata: " + volume + "köbméter");
            Console.ReadLine();
        }
    }
}
