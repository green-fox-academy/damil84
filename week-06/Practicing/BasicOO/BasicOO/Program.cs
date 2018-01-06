using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter test = new Counter();
            Console.WriteLine("Példányosítottam");
            Console.WriteLine("Példányszám: " + Counter.dbCounter);

            for (int i = 0; i < 10; i++)
            {
                new Counter();
                Console.WriteLine("Létrehoztam 10 pédányt");
                Console.WriteLine("Példányszám: " + Counter.dbCounter);
            }
            Console.ReadLine();
        }
    }
}
