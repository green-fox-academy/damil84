using System;

namespace ConsoleApp10
{
    class Dice
    {
        public static Random random = new Random();
        public int DiceValue { get; set; }

        public int GetCurrentNumber()
        {
            return DiceValue;
        }
                
        public void Roll()
        { 
            
            DiceValue = random.Next(1, 7);
        }

        public void ReRoll()
        {
            DiceValue = random.Next(1, 7);
        }
    }
}