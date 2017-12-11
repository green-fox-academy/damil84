using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var Animals = new Animal();
            Animals.Eat();
            Animals.Drink();
            Animals.Play();
        }
    }
}
