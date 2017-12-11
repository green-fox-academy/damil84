using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            dice Dice1 = new dice();

            List<dice> dices = new List<dice>();
            for (int i = 0; i < 6; i++)
            {
                dices.Add(new dice() { diceValue = 6 });
            }

            for (int j = 0; j < dices.Count; j++)
            {
                dices[j].Roll();

                while (dices[j].GetCurrentNumber() != 6)
                {
                    dices[j].ReRoll();
                }
                Console.WriteLine(dices[j].GetCurrentNumber());
            }
            Console.ReadLine();
        }
    }
}
