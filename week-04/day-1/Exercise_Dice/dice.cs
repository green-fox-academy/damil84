using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class dice
    {
        public static Random random = new Random();
        public int diceValue { get; set; }

        public int GetCurrentNumber()
        {
            return diceValue;
        }
                
        public void Roll()
        { 
            
            diceValue = random.Next(1, 7);
        }

        public void ReRoll()
        {
            diceValue = random.Next(1, 7);
        }
    }

}