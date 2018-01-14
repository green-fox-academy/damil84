using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dice1 = new Dice();

            var dices = new List<Dice>();
            for (int i = 0; i < 6; i++)
            {
                dices.Add(new Dice() { DiceValue = 6 });
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
