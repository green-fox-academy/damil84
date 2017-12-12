using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            var Animals = new Animals();
            var dog = new Animals();
            var cow = new Animals();
            var chicken = new Animals();
            var pig = new Animals();
            var cat = new Animals();

            var farm = new Farm(new List<Animals>() { dog, cow, chicken, pig, cat }, 5);
            Console.WriteLine("Dog hunger value is: " + dog.HungerValue + " shit");

            dog.Eat();
            cow.Eat();
            Console.WriteLine("Dog hunger value is: " + dog.HungerValue + " shit");
            Console.ReadLine();





            //farm = new Farm(new List<Farm>() 

        }
    }
}
