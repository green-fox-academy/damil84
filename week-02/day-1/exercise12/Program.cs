using System;

namespace exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            double surface;
            double volume;

            Console.WriteLine("Mennyi az a oldal értéke?:");
            Double.TryParse(Console.ReadLine(), out double a);

            Console.WriteLine("Mennyi a b oldal értéke?:");
            Double.TryParse(Console.ReadLine(), out double b);

            Console.WriteLine("Mennyi a c oldal értéke?:");
            Double.TryParse(Console.ReadLine(), out double c);

            surface = 2 * (a * b + a * c + b * c);
            Console.WriteLine("felszíne: " + surface + "négyzetméter");
            volume = (a * b * c);
            Console.WriteLine("térfogata: " + volume + "köbméter");
            Console.ReadLine();
        }
    }
}
