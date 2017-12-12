using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_Farm
{
    class Animals
    {
        public int HungerValue { get; set; }
        public int ThirstValue { get; set; }

        public Animal()
        {
            HungerValue = 50;
            ThirstValue = 50;
        }

        public void Eat()
        {
            HungerValue--;
        }

        public void Drink()
        {
            ThirstValue--;
        }

        public void Play()
        {
            HungerValue++;
            ThirstValue++;
        }
    }
}
