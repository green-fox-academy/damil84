using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_Animal
{
    class Animal
    {
        public int HungerValue { get; set; }
        public int ThirstValue { get; set; }

        public void Animals()
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
